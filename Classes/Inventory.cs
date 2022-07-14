using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Classes
{
    internal class Inventory
    {
        public List<Product> CreateInventory()
        {
            List<Product> inventory = new List<Product>();

            inventory.Add(new Product(1, "Beans", Product.FoodCategory.Canned, 10, "A can of beans.", 1.65m));
            inventory.Add(new Product(2, "Chicken Thighs", Product.FoodCategory.Meat, 5, "Pack of 6 thighs.", 7.95m));
            inventory.Add(new Product(3, "Squash", Product.FoodCategory.Produce, 30, "One 8 ounce squash.", 0.99m));
            inventory.Add(new Product(4, "Tomato", Product.FoodCategory.Produce, 25, "One 6 ounce tomato.", 0.79m));
            inventory.Add(new Product(5, "Wheat Bread", Product.FoodCategory.Bread, 13, "A loaf of bread.", 1.99m));

            return inventory;
        }
    }
}
