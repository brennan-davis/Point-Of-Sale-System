namespace PointOfSaleSystem.Classes
{
    public class CartItem : Product
    {
        public decimal LinePrice;

        public CartItem(int prodId, string name, int quantity, decimal unitPrice) : base(prodId, name, quantity, unitPrice)
        {
            LinePrice = quantity * UnitPrice;
        }
    }
}
