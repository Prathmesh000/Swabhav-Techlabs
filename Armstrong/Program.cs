using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int temp = inputNumber;
            int length = 0;

            while (temp > 0)
            {
                temp /= 10;
                length++;
            }

            temp = inputNumber;
            int rem, finalAnswer = 0;

            while (temp > 0)
            {
                rem = temp % 10;
                finalAnswer = finalAnswer + (int)Math.Pow(rem, length);
                temp /= 10;
            }

            if (inputNumber == finalAnswer)
            {
                Console.WriteLine("Your Number is ARMSTRONG");
            }
            else
            {
                Console.WriteLine("Your Number is not ARMSTRONG");
            }
        }
    }
}
