namespace Ngay3rework.Data
{
    public static class SeedData
    {
        public static List<Models.Category> Categories { get; } = new()
        {
            new Models.Category { id = 1, name = "Category 1" },
            new Models.Category { id = 2, name = "Category 2" },
            new Models.Category { id = 3, name = "Category 3" }
        };

        public static List<Models.Product> Products { get; } = new();
    }
}
