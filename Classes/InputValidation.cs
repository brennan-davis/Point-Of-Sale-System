namespace PointOfSaleSystem.Classes
{
    public class InputValidation
    {
        public int intInputValidation(string message)
        {
            Console.WriteLine(message);

            bool inputIsInt = int.TryParse(Console.ReadLine(), out int input);
            while (!inputIsInt)
            {
                Console.WriteLine("\nPlease input a valid item number:");
                inputIsInt = int.TryParse(Console.ReadLine(), out input);
            }

            return input;
        }

        public int inputInInventoryRangeCheck(List<Product> Products, string message)
        {
            Console.WriteLine(message);

            bool inputIsInt = int.TryParse(Console.ReadLine(), out int input);
            while (!inputIsInt || (input > Products.Count || input <= 0))
            {
                if (input > Products.Count || input <= 0)
                {
                    Console.WriteLine($"\nYour input must be between 1 - {Products.Count}. Please try again:");
                    inputIsInt = int.TryParse(Console.ReadLine(), out input);
                }
                else
                {
                    Console.WriteLine("\nPlease input a valid item number:");
                    inputIsInt = int.TryParse(Console.ReadLine(), out input);
                }
            }

            return input;
        }
    }
}
