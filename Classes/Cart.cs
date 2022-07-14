using ConsoleTables;

namespace PointOfSaleSystem.Classes
{
    public class Cart
    {
        public List<CartItem> ItemsInCart { get; set; }
        public ConsoleTable CartTable = new ConsoleTable("ID", "Name", "Quantity", "Unit Price", "Line Price");

        public decimal CartTotal
        {
            get { return ItemsInCart.Select(p => p.Quantity * p.UnitPrice).Sum(); }
        }

        public Cart()
        {
            ItemsInCart = new List<CartItem>();
        }

        public void AddItemToCart(Product prod, int quantity)
        {
            ItemsInCart.Add(new CartItem(prod.ProductId, prod.Name, quantity, prod.UnitPrice));
        }

        public void DrawCartTable()
        {
            CartTable.Rows.Clear();

            Console.WriteLine("\n---SHOPPING CART---");

            foreach (CartItem prod in ItemsInCart)
                CartTable.AddRow(prod.ProductId, prod.Name, prod.Quantity, string.Format("{0:C}", prod.UnitPrice), string.Format("{0:C}", prod.LinePrice));
            CartTable.AddRow(null, null, null, "Cart Total:", string.Format("{0:C}", CartTotal));
            CartTable.Options.EnableCount = false;

            CartTable.Write(Format.Alternative);
        }
    }
}
