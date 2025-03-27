using System;
using System.Collections.Generic;

namespace fixedwmethds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "[1] [P50 Cheese Burgir]", "[2] [P40 Fries]", "[3] [P35 Sundae]", "[4] [P100 JollyPares]" };
            List<string> receiptHistory = new List<string>();

            ShowWelcomeMessage();
            int start = GetUserChoice();

            while (start == 1)
            {
                List<string> currentOrder = new List<string>(); 
                ShowMenu(menu);

                string usrchoice;
                while ((usrchoice = GetUserChoiceForOrder()) != "0")
                {
                    ProcessOrder(usrchoice, currentOrder);
                }

                string serviceChoice = GetServiceChoice();
                string receipt = GenerateReceipt(currentOrder, serviceChoice);
                receiptHistory.Add(receipt); 
                Console.WriteLine(receipt); 

                Console.WriteLine("Would you like to make another order? (Press [1] for Yes, [0] for No)");
                start = Convert.ToInt32(Console.ReadLine());

                if (start == 0)
                {
                    Console.WriteLine("Thank you for coming! See you again!");
                    break;
                }
            }
        }

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to Mcdollibee Binan! Please press [1] to Order.");
        }
        static int GetUserChoice()
        {
            int choice;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice != 1)
                {
                    Console.WriteLine("Invalid Input. Please press [1] to start ordering.");
                }
            } while (choice != 1);
            return choice;
        }
        static void ShowMenu(string[] menu)
        { 
            Console.WriteLine("Mcdollibee MENU:");
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
        }
        static string GetUserChoiceForOrder()
        {
            Console.WriteLine("Choose your order by pressing numbers [1-4], or press [0] to exit.");
            return Console.ReadLine();
        }
        static void ProcessOrder(string usrchoice, List<string> currentOrder)
        {
            switch (usrchoice)
            {
                case "1":
                    currentOrder.Add("Cheese Burgir");
                    Console.WriteLine("Cheese Burgir Added!");
                    break;
                case "2":
                    currentOrder.Add("Fries");
                    Console.WriteLine("Fries Added!");
                    break;
                case "3":
                    currentOrder.Add("Sundae");
                    Console.WriteLine("Sundae Added!");
                    break;
                case "4":
                    currentOrder.Add("JollyPares");
                    Console.WriteLine("JollyPares Added!");
                    break;
                default:
                    Console.WriteLine("Invalid Input! Please choose [1-4] only.");
                    break;
            }
        }

        static string GetServiceChoice()
        {
            string serviceChoice;
            do
            {
                Console.WriteLine("Please choose your service type: [1] Dine-in or [2] Takeout");
                serviceChoice = Console.ReadLine();
                if (serviceChoice != "1" && serviceChoice != "2")
                {
                    Console.WriteLine("Invalid input! Please select [1] for Dine-in or [2] for Take-out.");
                }
            } while (serviceChoice != "1" && serviceChoice != "2");

            return serviceChoice == "1" ? "Dine-in" : "Takeout";
        }
        static string GenerateReceipt(List<string> currentOrder, string serviceChoice)
        {
            int totalAmount = 0;
            string receipt = "\n--- Mcdollibee Receipt ---\n";
            receipt += $"Service: {serviceChoice}\n";
            receipt += "Ordered Items:\n";

            foreach (string item in currentOrder)
            {
                receipt += $"{item}\n";
                totalAmount += GetItemPrice(item);
            }
            receipt += $"Total: P{totalAmount}\n";
            receipt += "--- Thank you for your order! ---\n";
            return receipt;
        }
        static int GetItemPrice(string item)
        {
            switch (item)
            {
                case "Cheese Burgir":
                    return 50;
                case "Fries":
                    return 40;
                case "Sundae":
                    return 35;
                case "JollyPares":
                    return 100;
                default:
                    return 0;
            }
        }
    }
}

