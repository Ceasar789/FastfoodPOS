using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "[1] [P50 Cheese Burgir]", "[2] [P40 Fries]", "[3] [P35 Sundae]", "[4] [P100 JollyPares]" };
            string usrchoice;
            int start;
            int receiptcd1 = 00123; int receiptcd2 = 00124; int receiptcd3 = 00125; int receiptcd4 = 00126;


            do
            {
                Console.WriteLine("Welcome to Mcdollibee Binan! Please press [1] to Order.");
                start = Convert.ToInt32(Console.ReadLine());

                if (start != 1)
                {
                    Console.WriteLine("Invalid Input. Please press [1] to start ordering.");
                }

            } while (start != 1);

            do
            {
                Console.WriteLine("Mcdollibee MENU:");
                foreach (string item in menu)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Choose your order by pressing numbers [1-4], or press [0] to exit.");
                usrchoice = Console.ReadLine();

                switch (usrchoice)
                {
                    case "1":
                        Console.WriteLine(" Cheese Burgir Added!");
                        break;
                    case "2":
                        Console.WriteLine(" Fries Added!");
                        break;
                    case "3":
                        Console.WriteLine(" Sundae Added!");
                        break;
                    case "4":
                        Console.WriteLine(" JollyPares Added!");
                        break;
                    case "0":
                        Console.WriteLine("Thank you for Coming! See You Again!");
                        break;
                    default:
                        Console.WriteLine(" Invalid Input! Please choose [1-4] only.");
                        break;
                }

            } while (usrchoice != "0");
        }
    }
}
