using System;

namespace Valiutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (looping())
            {

            }

            static bool looping()
            {
                Console.WriteLine("Euros convert to:");
                Console.WriteLine("[1] USD, [2] PLN, [3] BYR");
                string[] currName = { "USD", "PLN", "BYR" };
                decimal[] currRatio = { 1.00M, 4.73M, 2.52M };
                int userOption;
                bool goodToGo1 = int.TryParse(Console.ReadLine(), out userOption);
                if (goodToGo1 && userOption > 0 && userOption < 4)
                {
                    Console.WriteLine("Enter amount of Euros");
                    decimal amountEuros = Convert.ToDecimal(Console.ReadLine());
                    decimal toGive = amountEuros * currRatio[userOption - 1];
                    Console.WriteLine("You will get {0:0.00} {1:0.00}", toGive, currName[userOption - 1]);
                }
                Console.WriteLine("Exit? y/n");
                if (Console.ReadLine() == "y")
                {
                    return false;
                }
                return true;
            }
        }
    }
}
