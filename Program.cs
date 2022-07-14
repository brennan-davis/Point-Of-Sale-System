using PointOfSaleSystem.Classes;

Inventory inv = new Inventory();

string LineItemAndListPrice = string.Empty;

bool continueLoop = true;

while (continueLoop)
{
    Console.Clear();

    inv.DrawInventoryTable();

    Console.WriteLine("Which Item would you like to buy?");
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine("Which how many unit of this item would you like to buy?");
    int input2 = int.Parse(Console.ReadLine());

    inv.UpdateInventory(input, input2);

    Console.ReadLine();
}