namespace Methods_Gentry_Nylen
{
    internal class Program
    {
        // Function to multiply two integers
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        // Function to welcome the user
        static void Welcome(string name)
        {
            Console.WriteLine($"Hello, {name}! It is nice to meet you!");
        }

        // Function to say farewell
        static void Farewell()
        {
            Console.WriteLine("Have a fantastic day!");
        }

        // Main function
        static void Main()
        {
            // Step 1: Multiply two integers
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = Multiply(num1, num2);
            Console.WriteLine($"The result of multiplying {num1} and {num2} is: {result}");

            // Step 2: Welcome the user
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            Welcome(userName);

            // Step 3: Farewell the user
            Farewell();
        }
    }
}