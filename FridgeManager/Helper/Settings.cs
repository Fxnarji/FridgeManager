using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeManager.Helper
{
    public static class Settings
    {
        private const string SettingsFilePath = "data/settings.json";

        public static void SaveSettings(AppSettings settings)
        {
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(SettingsFilePath, json);
        }

        public static AppSettings LoadSettings()
        {
            if (File.Exists(SettingsFilePath))
            {
                string json = File.ReadAllText(SettingsFilePath);
                return JsonConvert.DeserializeObject<AppSettings>(json);
            }
            return new AppSettings();
        }

        //category handling
        public static void AddCategory(string newItem)
        {
            AppSettings settings = LoadSettings();
            settings.Categories.Add(newItem);
            settings.SearchCategories.Add(newItem);
            SaveSettings(settings);
        }
        public static void removeCategory(string oldItem)
        {
            AppSettings settings = LoadSettings();

            // Create new lists to hold the filtered categories
            List<string> categoriesCopy = new List<string>();
            List<string> searchCategoriesCopy = new List<string>();

            // Copy items from the original lists to the new lists, excluding the oldItem
            foreach (string item in settings.Categories)
            {
                if (!item.Equals(oldItem))
                    categoriesCopy.Add(item);
            }

            foreach (string item in settings.SearchCategories)
            {
                if (!item.Equals(oldItem))
                    searchCategoriesCopy.Add(item);
            }

            // Assign the new lists back to the settings object
            settings.Categories = null;
            settings.Categories = categoriesCopy;
            settings.SearchCategories = null;
            settings.SearchCategories = searchCategoriesCopy;

            // Save the modified settings
            SaveSettings(settings);
        }

        public static bool isInCategory(string input)
        {
            if (input == null)
                return false;

            AppSettings settings = LoadSettings();

            foreach (string item in settings.Categories)
            {
                if (input.Equals(item))
                    return true;
            }

            return false;
        }

        public static bool isInSearchCategory(string input)
        {
            if (input == null)
                return false;

            AppSettings settings = LoadSettings();

            foreach (string item in settings.SearchCategories)
            {
                if (input.Equals(item))
                    return true;
            }

            return false;
        }

        //maxDay handling
        public static void AddMaxDaysToSettings(int newDays)
        {
            AppSettings settings = LoadSettings();
            settings.maxDays = newDays;
            SaveSettings(settings);
        }
        public static int loadMaxDays()
        {
            AppSettings settings = LoadSettings();
            return settings.maxDays;
        }

    }
}
