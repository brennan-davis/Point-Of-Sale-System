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
        public Cart ShoppingCart = new Cart();
        ConsoleTable InvTable = new ConsoleTable("ID", "Name", "Units Available", "Category", "Description", "Unit Price");
        public List<Product> Products { get; set; }

        public Inventory()
        {
            Products = new List<Product>()
            {
                new Product(1, "Beans", FoodCategory.Canned, 10, "A can of beans.", 1.65m),
                new Product(2, "Chicken Thighs", FoodCategory.Meat, 5, "Pack of 6 thighs.", 7.95m),
                new Product(3, "Squash", FoodCategory.Produce, 30, "One 8 ounce squash.", 0.99m),
                new Product(4, "Tomato", FoodCategory.Produce, 25, "One 6 ounce tomato.", 0.79m),
                new Product(5, "Wheat Bread", FoodCategory.Bread, 13, "A loaf of bread.", 1.99m)
            };
        }


        public void DrawInventoryTable()
        {
            InvTable.Rows.Clear();

            Console.WriteLine("\n---STORE INVENTORY---");

            foreach (Product prod in Products)
                if (prod.Quantity > 0)
                    InvTable.AddRow(prod.ProductId, prod.Name, prod.Quantity, prod.FoodCat, prod.Description, string.Format("{0:C}", prod.UnitPrice));
            InvTable.Options.EnableCount = false;

            InvTable.Write();

            if (ShoppingCart.ItemsInCart.Count > 0)
            {
                ShoppingCart.DrawCartTable();
            }
        }

        public void UpdateInventory(int prodId, int quantityDesired)
        {
            Products[prodId - 1].Quantity -= quantityDesired;

            ShoppingCart.AddItemToCart(Products[prodId - 1], quantityDesired);

            Console.Clear();

            DrawInventoryTable();
        }
    }
}
