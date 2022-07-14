using PointOfSaleSystem.Classes;

Inventory inv = new Inventory();

List<Product> inventory = inv.CreateInventory();

inv.DrawInventoryTable(inventory);