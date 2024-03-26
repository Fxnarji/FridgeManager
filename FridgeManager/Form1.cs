using System.Data;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;
using FridgeManager.Helper;
using System.Runtime;
using Microsoft.VisualBasic;
using System.Linq;
using System.Windows.Forms;

namespace FridgeManager
{
    public partial class Form1 : Form
    {

        // data Table:
        DataTable table = new DataTable("ListOfGroceries");
        DataTable searchResultsTable = new DataTable("Search");
        string filePathTable = "data/table.xml";
        private bool isSearchOpen = false;



        public Form1()
        {
            InitializeComponent();
            loadEverything();
            refreshDataTable();
            dataGridView1.DataBindingComplete += DataGridViewInventory_DataBindingComplete;

        }

        #region UI Elements

        private void bt_Save_Click(object sender, EventArgs e)
        {
            saveDataTable();
        }

        private void bt_Export_Click(object sender, EventArgs e)
        {

        }

        private void bt_categoriesInteract_Click(object sender, EventArgs e)
        {
            string newItem = cb_CategoryAdd.Text; // Get the text from the TextBox

            if (Settings.isInCategory(newItem))
            {
                MessageBox.Show("Name nicht möglich :(");
                return;
            }

            if (!cb_CategoryAdd.Items.Contains(newItem))
            {
                cb_CategoryAdd.Items.Add(newItem); // Add the item if it doesn't exist
            }

            Settings.AddCategory(newItem); // Save the updated list to settings
            cb_CategoryAdd.Text = string.Empty;
        }

        private void bt_AddItem_Click(object sender, EventArgs e)
        {
            float amount;
            string cat;


            if (Settings.isInCategory(cb_CategoryAdd.Text))
                cat = cb_CategoryAdd.Text;
            else
            {
                MessageBox.Show("ungültige Kategorie - bitte erst hinzufügen :)");
                return;
            }


            if (!float.TryParse(tb_Amount.Text, out amount))
            {
                MessageBox.Show("bitte nur nummern eintragen!");
            }

            addRow(
                tb_Name.Text,
                amount,
                cat,
                tb_Desc.Text,
                dtp_Expiration.Value);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (!isSearchOpen)
            {
                OpenSearch(tb_Name.Text, cb_Search.Text, tb_SearchDesc.Text);
                isSearchOpen = true;
                return;
            }
            CloseSearch();
            isSearchOpen = false;
            
        }


        //text boxes
        private void tb_MaxDays_Changed(object sender, EventArgs e)
        {
            int days;
            if (int.TryParse(tb_MaxDays.Text, out days))
            {
                Settings.AddMaxDaysToSettings(days);
            }
            else
                return;

            formatRows(days);
        }

        #endregion

        #region functionality methods

        //random stuff functions
        private DataRow generateRandomRow()
        {
            DataRow row = table.NewRow();

            List<string> names = new List<string>
            {
                "Banane",
                "Apple",
                "Milk",
                "Toast",
                "Bred"
            };


            List<string> category = new List<string>
            {
                "Fruits",
                "drinks",
                "dairy"
            };

            List<string> desc = new List<string>
            {
                "",
                "",
                "in slices"
            };

            Random random = new Random();

            int rndID = table.Rows.Count;
            int rndNames = random.Next(0, names.Count);
            int rndCat = random.Next(0, category.Count);
            int rndDesc = random.Next(0, desc.Count);
            float rndAmount = random.Next(0, 3000);

            row["ID"] = rndID;
            row["Name"] = names[rndNames];
            row["Amount"] = rndAmount;
            row["Category"] = category[rndCat];
            row["Description"] = desc[rndDesc];
            row["ExpirationDate"] = getRandomDay();

            return row;
        }
        private static DateTime getRandomDay()
        {
            int day, month, year;

            Random random = new Random();
            day = random.Next(1, 28);
            month = random.Next(1, 13);
            year = random.Next(2023, 2030);

            return new DateTime(year, month, day);
        }


        //saving and loading
        private void loadEverything()
        {
            loadSettings();
            loadDataTable();
        }
        private void loadSettings()
        {
            AppSettings settings = Settings.LoadSettings();

            foreach (string item in settings.Categories)
            {
                cb_CategoryAdd.Items.Add(item);
            }

            foreach (string item in settings.SearchCategories)
            {
                cb_Search.Items.Add(item);
            }

            tb_MaxDays.Text = Settings.loadMaxDays().ToString();

        }
        private void loadDataTable()
        {

            if (!File.Exists(filePathTable))
            {
                MessageBox.Show("No Data Table found at: " + filePathTable);
                return;
            }
            DataTable dataTable;
            // Deserialize XML to DataTable
            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
            using (StreamReader reader = new StreamReader(filePathTable))
            {
                dataTable = (DataTable)serializer.Deserialize(reader);
            }
            table = dataTable;



        }


        private void saveDataTable()
        {

            // Serialize DataTable to XML
            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
            using (StreamWriter writer = new StreamWriter(filePathTable))
            {
                serializer.Serialize(writer, table);
            }
        }
        private void refreshDataTable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }

        //data handling
        private void addRow(string name, float amount, string category, string desc, DateTime date)
        {
            int Id = table.Rows.Count + 1;
            DataRow row = table.NewRow();

            row["ID"] = Id;
            row["Name"] = name;
            row["Amount"] = amount;
            row["Category"] = category;
            row["Description"] = desc;
            row["ExpirationDate"] = date;

            table.Rows.Add(row);
        }
        private void addRow(DataRow row)
        {
            table.Rows.Add(row);
        }

        //visual
        private void formatRows(int days)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime expirationDate = Convert.ToDateTime(row.Cells["ExpirationDate"].Value);

                TimeSpan difference = expirationDate - DateTime.Now;

                if (difference.TotalDays <= 0)
                    row.DefaultCellStyle.BackColor = Color.Red;
                else if (difference.TotalDays <= days)
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void DataGridViewInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            formatRows(Settings.loadMaxDays());
        }

        //search
        private void OpenSearch(string searchName, string searchCategory, string searchDescription)
        {
            populateSearch(searchName, searchCategory, searchDescription);
            this.BackColor = Color.Red;
            dataGridView1.DataSource = searchResultsTable;

        }
        private void CloseSearch()
        {
            dataGridView1.DataSource = table;
            this.BackColor = Color.White;
        }
        private void populateSearch(string searchCat, string searchName, string searchDesc)
        {
            
            if (searchCat.ToLower().Equals("alles"))
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row["Name"].ToString().Contains(searchName)
                        && row["Description"].ToString().Contains(searchDesc))
                        searchResultsTable.Rows.Add(row);

                }
                return;
            }

            if (searchCat.ToLower().Equals("fast abgelaufen"))
            {
                foreach (DataRow row in table.Rows)
                {
                    bool valid = false;
                    DateTime expirationDate = Convert.ToDateTime(row["ExpirationDate"]);

                    TimeSpan difference = expirationDate - DateTime.Now;

                    if (difference.TotalDays <= 0)
                        valid = true;

                    if (valid
                        && row["Name"].ToString().Contains(searchName)
                        && row["Description"].ToString().Contains(searchDesc))
                        searchResultsTable.Rows.Add(row);
                }
                return;
            }
            foreach(DataRow row in table.Rows)
            {
                if (row["Category"].ToString().Contains(searchCat)
                    && row["Name"].ToString().Contains(searchName)
                    && row["Description"].ToString().Contains(searchDesc))

            }
        }

    }

    #endregion

}