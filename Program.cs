using PointOfSaleSystem.Classes;

Inventory inv = new Inventory();
InputValidation iv = new InputValidation();

string LineItemAndListPrice = string.Empty;

bool continueLoop = true;

while (continueLoop)
{
    Console.Clear();

    inv.DrawInventoryTable();

    int input1 = iv.inputInInventoryRangeCheck(inv.Products, "Which Item would you like to buy?");
    int input2 = iv.intInputValidation("Which how many unit of this item would you like to buy?");

    inv.UpdateInventory(input1, input2);
}