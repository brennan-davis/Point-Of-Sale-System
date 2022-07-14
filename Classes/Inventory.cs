using ConsoleTables;

namespace PointOfSaleSystem.Classes
{
    public enum FoodCategory
    {
        Produce,
        Frozen,
        Meat,
        Bread,
        Canned
    }

    public class Inventory
    {
        public List<Product> CreateInventory()
        {
            List<Product> inventory = new List<Product>();

            inventory.Add(new Product(1, "Beans", FoodCategory.Canned, 10, "A can of beans.", 1.65m));
            inventory.Add(new Product(2, "Chicken Thighs", FoodCategory.Meat, 5, "Pack of 6 thighs.", 7.95m));
            inventory.Add(new Product(3, "Squash", FoodCategory.Produce, 30, "One 8 ounce squash.", 0.99m));
            inventory.Add(new Product(4, "Tomato", FoodCategory.Produce, 25, "One 6 ounce tomato.", 0.79m));
            inventory.Add(new Product(5, "Wheat Bread", FoodCategory.Bread, 13, "A loaf of bread.", 1.99m));

            return inventory;
        }

        public void DrawInventoryTable(List<Product> inventory)
        {
            var invTable = new ConsoleTable("ID", "Name", "Units Available", "Category", "Description", "Unit Price");

            foreach (Product prod in inventory)
                invTable.AddRow(prod.ProductId, prod.Name, prod.QuantityAvailable, prod.FoodCat, prod.Description, string.Format("{0:C}", prod.UnitPrice));

            invTable.Write(Format.Alternative);
        }
    }
}
