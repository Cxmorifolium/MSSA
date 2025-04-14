class Program {
    static void Main(string[] args) {
        MathOperations TimeToMath = new MathOperations();

        Console.WriteLine($@"Please choose an operation by entering 1, 2, or 3:
            1. Addition
            2. Multiply
            3. Exit");

        int userInput = int.Parse(Console.ReadLine());

        if (userInput == 3) {
            Console.WriteLine("Goodbye!");
            return;
        }

        Console.WriteLine("Please enter the number of inputs (only 2 or 3): ");
        int integerInput = int.Parse(Console.ReadLine());

        //I think switch might be cleaner than if-if

        // Declare variables once outside of the switch
        int num1, num2, num3;

        switch (integerInput) {
            case 2:
                Console.WriteLine("Enter first number:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                num2 = int.Parse(Console.ReadLine());

                if (userInput == 1) {
                    Console.WriteLine($"The sum is: {MathOperations.Add(num1, num2)}");
                } else if (userInput == 2) {
                    Console.WriteLine($"The product is: {MathOperations.Multiply(num1, num2)}");
                }
                break;

            case 3:
                Console.WriteLine("Enter first number:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third number:");
                num3 = int.Parse(Console.ReadLine());

                if (userInput == 1) {
                    Console.WriteLine($"The sum is: {MathOperations.Add(num1, num2, num3)}");
                } else if (userInput == 2) {
                    Console.WriteLine($"The product is: {MathOperations.Multiply(num1, num2, num3)}");
                }
                break;

            default:
                Console.WriteLine("Invalid number of inputs. Please enter 2 or 3.");
                break;
        }
    }
}
