using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0501
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant for the monthly interest rate.
            const decimal INTEREST_RATE = 0.005m;

            // Local variables
            decimal balance;    // The account balance
            int months;         // The number of months
            int count = 1;      // Loop counter, initialzized with 1

            // Get the starting balance
            Console.Write("Enter the starting balance: ");
            balance = decimal.Parse(Console.ReadLine());

            // Get the number of months.
            Console.Write("Enter the number of months: ");
            months = int.Parse(Console.ReadLine());

            // The following loop calculates the ending balance
            while (count <= months)
            {
                // Add this month's interest to the balance.
                balance = balance + (INTEREST_RATE * balance);

                // Add one to the loop counter
                count = count + 1;
            }

            // Display the ending balance.
            Console.WriteLine("Ending Balance: " + balance.ToString("c"));
            Console.ReadLine();
        }
    }
}
