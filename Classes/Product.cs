namespace PointOfSaleSystem.Classes
{
    public class Product
    {
        public int ProductId;
        public string Name;
        public int Quantity;
        public string Description;
        public decimal UnitPrice;
        public FoodCategory FoodCat;

        public Product(int productId, string name, FoodCategory foodCat, int quantity, string description, decimal unitPrice)
        {
            ProductId = productId;
            Name = name;
            FoodCat = foodCat;
            Quantity = quantity;
            Description = description;
            UnitPrice = unitPrice;
        }

        public Product(int productId, string name, int quantity, decimal unitPrice)
        {
            ProductId = productId;
            Name = name;
            Quantity = quantity;
            Description = string.Empty;
            UnitPrice = unitPrice;
        }
    }
}
