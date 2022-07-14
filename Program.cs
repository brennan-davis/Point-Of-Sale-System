using PointOfSaleSystem.Classes;

Inventory inv = new Inventory();
List<Product> inventory = inv.CreateInventory();

foreach (Product prod in inventory)
{
    Console.WriteLine($"Product ID: {prod.productId}\nProduct Name: {prod.name}\nAvailable Units: {prod.quantityAvailable}\nCategory: {prod.foodCategory}\nDescription: {prod.description}\nUnit Price: {prod.unitPrice}\n");
}