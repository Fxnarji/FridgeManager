namespace FridgeManager.Helper
{
    public class AppSettings
    {
        public List<string> Categories { get; set; } = new List<string>();
        public List<string> SearchCategories { get; set; } = new List<string>();
        public int maxDays { get; set; }
    }
}
