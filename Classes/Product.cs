using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Classes
{
    public class Product
    {
        public int productId;
        public string name;
        public int quantityAvailable;
        public string description;
        public decimal unitPrice;
        public FoodCategory foodCategory;

        public enum FoodCategory
        {
            Produce,
            Frozen,
            Meat,
            Bread,
            Canned
        }

        public Product(int ProductId, string Name, FoodCategory foodCat, int QuantityAvailable, string Description, decimal UnitPrice)
        {
            productId = ProductId;
            name = Name;
            foodCategory = foodCat;
            quantityAvailable = QuantityAvailable;
            description = Description;
            unitPrice = UnitPrice;
        }
    }
}
