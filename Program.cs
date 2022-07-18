using PointOfSaleSystem.Classes;

Inventory inv = new Inventory();

string LineItemAndListPrice = string.Empty;

bool continueLoop = true;

while (continueLoop)
{
    Console.Clear();

    inv.DrawInventoryTable();

    Console.WriteLine("Which Item would you like to buy?");
    bool input1IsInt = int.TryParse(Console.ReadLine(), out int input1);
    while (!input1IsInt)
    {
        Console.WriteLine("\nPlease input a valid item number:");
        input1IsInt = int.TryParse(Console.ReadLine(), out input1);
    }
    Console.WriteLine("Which how many unit of this item would you like to buy?");
    bool input2IsInt = int.TryParse(Console.ReadLine(), out int input2);
    while (!input2IsInt)
    {
        Console.WriteLine("\nPlease input a valid item number:");
        input2IsInt = int.TryParse(Console.ReadLine(), out input2);
    }

    inv.UpdateInventory(input1, input2);
}