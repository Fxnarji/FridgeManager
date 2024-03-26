namespace FridgeManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            dataGridView1 = new DataGridView();
            tb_MaxDays = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            bt_categoriesInteract = new Button();
            bt_AddItem = new Button();
            dtp_Expiration = new DateTimePicker();
            cb_CategoryAdd = new ComboBox();
            tb_Amount = new TextBox();
            tb_Desc = new TextBox();
            tb_Name = new TextBox();
            groupBox3 = new GroupBox();
            SaveLoad = new GroupBox();
            bt_Export = new Button();
            groupBox4 = new GroupBox();
            btSearch = new Button();
            groupBox5 = new GroupBox();
            lb_SearchResult = new Label();
            groupBox7 = new GroupBox();
            cb_Search = new ComboBox();
            groupBox6 = new GroupBox();
            tb_SearchName = new TextBox();
            groupBox8 = new GroupBox();
            tb_SearchDesc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SaveLoad.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImage = Properties.Resources.save;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(6, 24);
            button2.Name = "button2";
            button2.Size = new Size(98, 44);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += bt_Save_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1940, 602);
            dataGridView1.TabIndex = 2;
            // 
            // tb_MaxDays
            // 
            tb_MaxDays.Location = new Point(119, 35);
            tb_MaxDays.Name = "tb_MaxDays";
            tb_MaxDays.Size = new Size(93, 33);
            tb_MaxDays.TabIndex = 7;
            tb_MaxDays.Text = "7";
            tb_MaxDays.TextChanged += tb_MaxDays_Changed;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_MaxDays);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(478, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 118);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Input";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 8;
            label1.Text = "Mark Days";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_categoriesInteract);
            groupBox2.Controls.Add(bt_AddItem);
            groupBox2.Controls.Add(dtp_Expiration);
            groupBox2.Controls.Add(cb_CategoryAdd);
            groupBox2.Controls.Add(tb_Amount);
            groupBox2.Controls.Add(tb_Desc);
            groupBox2.Controls.Add(tb_Name);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 118);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add";
            // 
            // bt_categoriesInteract
            // 
            bt_categoriesInteract.BackgroundImage = Properties.Resources.add;
            bt_categoriesInteract.BackgroundImageLayout = ImageLayout.Zoom;
            bt_categoriesInteract.Location = new Point(169, 77);
            bt_categoriesInteract.Name = "bt_categoriesInteract";
            bt_categoriesInteract.Size = new Size(33, 33);
            bt_categoriesInteract.TabIndex = 6;
            bt_categoriesInteract.UseVisualStyleBackColor = true;
            bt_categoriesInteract.Click += bt_categoriesInteract_Click;
            // 
            // bt_AddItem
            // 
            bt_AddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_AddItem.Location = new Point(354, 77);
            bt_AddItem.Name = "bt_AddItem";
            bt_AddItem.Size = new Size(100, 33);
            bt_AddItem.TabIndex = 5;
            bt_AddItem.Text = "Add";
            bt_AddItem.UseVisualStyleBackColor = true;
            bt_AddItem.Click += bt_AddItem_Click;
            // 
            // dtp_Expiration
            // 
            dtp_Expiration.Format = DateTimePickerFormat.Short;
            dtp_Expiration.Location = new Point(209, 77);
            dtp_Expiration.Name = "dtp_Expiration";
            dtp_Expiration.Size = new Size(132, 33);
            dtp_Expiration.TabIndex = 4;
            // 
            // cb_CategoryAdd
            // 
            cb_CategoryAdd.FormattingEnabled = true;
            cb_CategoryAdd.Location = new Point(6, 77);
            cb_CategoryAdd.Name = "cb_CategoryAdd";
            cb_CategoryAdd.Size = new Size(157, 33);
            cb_CategoryAdd.TabIndex = 3;
            // 
            // tb_Amount
            // 
            tb_Amount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tb_Amount.Location = new Point(354, 30);
            tb_Amount.Name = "tb_Amount";
            tb_Amount.PlaceholderText = "Menge";
            tb_Amount.Size = new Size(100, 33);
            tb_Amount.TabIndex = 2;
            // 
            // tb_Desc
            // 
            tb_Desc.Location = new Point(112, 30);
            tb_Desc.Name = "tb_Desc";
            tb_Desc.PlaceholderText = "Besch";
            tb_Desc.Size = new Size(229, 33);
            tb_Desc.TabIndex = 1;
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(6, 30);
            tb_Name.Name = "tb_Name";
            tb_Name.PlaceholderText = "Name";
            tb_Name.Size = new Size(100, 33);
            tb_Name.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 136);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1952, 640);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Tag = "";
            groupBox3.Text = "Data";
            // 
            // SaveLoad
            // 
            SaveLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveLoad.Controls.Add(bt_Export);
            SaveLoad.Controls.Add(button2);
            SaveLoad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveLoad.Location = new Point(1854, 12);
            SaveLoad.Name = "SaveLoad";
            SaveLoad.Size = new Size(110, 118);
            SaveLoad.TabIndex = 8;
            SaveLoad.TabStop = false;
            SaveLoad.Text = "Speichern";
            // 
            // bt_Export
            // 
            bt_Export.BackgroundImage = Properties.Resources.export;
            bt_Export.BackgroundImageLayout = ImageLayout.Zoom;
            bt_Export.Location = new Point(6, 69);
            bt_Export.Name = "bt_Export";
            bt_Export.Size = new Size(98, 43);
            bt_Export.TabIndex = 2;
            bt_Export.UseVisualStyleBackColor = true;
            bt_Export.Click += bt_Export_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(btSearch);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(709, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(716, 118);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Suche";
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSearch.BackgroundImage = Properties.Resources.search;
            btSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btSearch.Location = new Point(654, 54);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(56, 56);
            btSearch.TabIndex = 3;
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox5.Controls.Add(lb_SearchResult);
            groupBox5.Location = new Point(559, 40);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(89, 70);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Anzahl";
            // 
            // lb_SearchResult
            // 
            lb_SearchResult.AutoSize = true;
            lb_SearchResult.Location = new Point(27, 34);
            lb_SearchResult.Name = "lb_SearchResult";
            lb_SearchResult.Size = new Size(28, 25);
            lb_SearchResult.TabIndex = 0;
            lb_SearchResult.Text = "--";
            lb_SearchResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cb_Search);
            groupBox7.Location = new Point(353, 40);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(200, 70);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Kategorie";
            // 
            // cb_Search
            // 
            cb_Search.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Search.FormattingEnabled = true;
            cb_Search.Location = new Point(6, 30);
            cb_Search.Name = "cb_Search";
            cb_Search.Size = new Size(188, 33);
            cb_Search.TabIndex = 0;
            cb_Search.UseWaitCursor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tb_SearchName);
            groupBox6.Location = new Point(6, 40);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(166, 70);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Name";
            // 
            // tb_SearchName
            // 
            tb_SearchName.Location = new Point(6, 30);
            tb_SearchName.Name = "tb_SearchName";
            tb_SearchName.Size = new Size(153, 33);
            tb_SearchName.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(tb_SearchDesc);
            groupBox8.Location = new Point(178, 40);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(166, 70);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "Beschribung";
            // 
            // tb_SearchDesc
            // 
            tb_SearchDesc.Location = new Point(6, 30);
            tb_SearchDesc.Name = "tb_SearchDesc";
            tb_SearchDesc.Size = new Size(153, 33);
            tb_SearchDesc.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1973, 788);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(SaveLoad);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            SaveLoad.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox tb_MaxDays;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tb_Desc;
        private TextBox tb_Name;
        private Button bt_AddItem;
        private DateTimePicker dtp_Expiration;
        private ComboBox cb_CategoryAdd;
        private TextBox tb_Amount;
        private GroupBox groupBox3;
        private Button bt_categoriesInteract;
        private GroupBox SaveLoad;
        private Button button1;
        private Button bt_Export;
        private GroupBox groupBox4;
        private Button btSearch;
        private GroupBox groupBox5;
        private Label lb_SearchResult;
        private GroupBox groupBox7;
        private ComboBox cb_Search;
        private GroupBox groupBox8;
        private TextBox tb_SearchDesc;
        private GroupBox groupBox6;
        private TextBox tb_SearchName;
    }
}