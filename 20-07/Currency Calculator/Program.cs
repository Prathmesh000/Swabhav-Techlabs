using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount: ");
            long inputAmount = Convert.ToInt64(Console.ReadLine());

            if (!NumberOfDenominations(inputAmount))
            {
                Console.WriteLine("Amount not Valid");
            };
        }

        static bool NumberOfDenominations(long inputAmount)
        {
            if (inputAmount > 50000 || inputAmount % 100 != 0)
            {
                return false;
            }

            long[] denominations = { 2000, 500, 200, 100 };
            long[] countOfEachDenomination = new long[4];

            int index = 0;

            foreach(long denomination in denominations)
            {
                countOfEachDenomination[index] = inputAmount / denomination;
                inputAmount = inputAmount % denomination;
                index++;
            }

            index = 0;

            foreach(int count in countOfEachDenomination)
            {
                Console.WriteLine(denominations[index] + ":" + count);
                Console.WriteLine();
                index++;
            }
            return true;
            
        }
    }
}
