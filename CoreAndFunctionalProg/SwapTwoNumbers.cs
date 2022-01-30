using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProg
{
    internal class SwapTwoNumbers
    {
        public void swapTwoNum()
        {
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers after swapping: ");

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine("First num = " + a + "\nSecond num = " + b);
        }
    }
}
