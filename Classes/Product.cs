namespace PointOfSaleSystem.Classes
{
    public class Product
    {
        public int ProductId;
        public string Name;
        public int QuantityAvailable;
        public string Description;
        public decimal UnitPrice;
        public FoodCategory FoodCat;

        public Product(int productId, string name, FoodCategory foodCat, int quantityAvailable, string description, decimal unitPrice)
        {
            ProductId = productId;
            Name = name;
            FoodCat = foodCat;
            QuantityAvailable = quantityAvailable;
            Description = description;
            UnitPrice = unitPrice;
        }
    }
}
