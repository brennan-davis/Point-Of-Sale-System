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

        int input1;
        int input2;

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
            bool isAvailableInQuantityDesired = false;

            while (!isAvailableInQuantityDesired)
            {
                input1 = 0;
                input2 = 0;

                if (Products[prodId - 1].Quantity > 0 && quantityDesired <= Products[prodId - 1].Quantity)
                {
                    Products[prodId - 1].Quantity -= quantityDesired;

                    ShoppingCart.AddItemToCart(Products[prodId - 1], quantityDesired);

                    isAvailableInQuantityDesired = true;

                    Console.Clear();

                    DrawInventoryTable();
                }
                else
                {
                    if (Products[prodId - 1].Quantity == 0)
                    {
                        Console.WriteLine($"\nSorry, we have no {Products[prodId - 1].Name} available. Please select a new product you'd like to buy.");
                        bool input1IsInt = int.TryParse(Console.ReadLine(), out input1);
                        while (!input1IsInt)
                        {
                            Console.WriteLine("\nPlease input a valid item number:");
                            input1IsInt = int.TryParse(Console.ReadLine(), out input1);
                        }
                        Console.WriteLine("Which how many unit of this item would you like to buy?");
                        bool input2IsInt = int.TryParse(Console.ReadLine(), out input2);
                        while (!input2IsInt)
                        {
                            Console.WriteLine("\nPlease input a valid item number:");
                            input2IsInt = int.TryParse(Console.ReadLine(), out input2);
                        }
                        UpdateInventory(input1, input2);
                    }
                    else
                        Console.WriteLine($"\nSorry, we only have {Products[prodId - 1].Quantity} {Products[prodId - 1].Name} available.\nPlease input a new quantity you'd like to buy:");

                    bool quantityDesiredIsInt = int.TryParse(Console.ReadLine(), out quantityDesired);
                    while (!quantityDesiredIsInt || quantityDesired > Products[prodId - 1].Quantity)
                    {
                        if (!quantityDesiredIsInt)
                        {
                            Console.WriteLine($"\nPlease input a valid integer for quantity of {Products[prodId - 1].Name} desired:");
                            quantityDesiredIsInt = int.TryParse(Console.ReadLine(), out quantityDesired);
                        }
                        else
                        {
                            Console.WriteLine($"\nOnly {Products[prodId - 1].Quantity} {Products[prodId - 1].Name} are available.\nPlease input a new quantity you'd like to buy that falls into this range:");
                            quantityDesiredIsInt = int.TryParse(Console.ReadLine(), out quantityDesired);
                        }
                    }
                }
            }

            //if (input1 != 0 && input2 != 0)
            //    UpdateInventory(input1, input2);


        }
    }
}
