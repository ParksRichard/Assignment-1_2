namespace Assignment_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int int1, int2;
           
            Console.Write("Please enter numbers below to check if they are equal or not.");
            Console.WriteLine();

            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (int1 == int2)
                Console.WriteLine("{0} and {1} are equal.", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.", int1, int2);
            

                int i, sum = 0;

                Console.Write("\n\n");
                Console.Write("Find the sum of the first 10 natural numbers:\n");

                Console.Write("\n\n");

                Console.Write("The first 10 natural numbers are:\n");

                Console.WriteLine();

                for (i = 1; i <= 10; i++)
                {
                    sum = sum + i;
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();

                Console.Write("And the Sum of the above numbers is = {0}", sum);
            Console.WriteLine("");

            Console.Write("This is the Calculator Part.");

            Console.WriteLine("");

            string value;
            do
            {
                int res;
                Console.Write("Please enter your first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter a second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("The answer for this Addition:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("The answer for this Subtraction:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("The answer for this Multiplication:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("The answer for this Division:" + res);
                        break;
                    default:
                        Console.WriteLine("Nope, wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to play again?(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");

        }
         }
    }

