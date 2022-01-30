using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProg
{
    internal class LargestAmongThreeNum
    {
        public void determineLargest()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the first number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            int largestAmongTwo = firstNum > secondNum ? firstNum : secondNum;
            int largestAmongThree = largestAmongTwo > thirdNum ? largestAmongTwo : thirdNum;

            Console.WriteLine("The largest number among three numbers is: " + largestAmongThree);
        }
    }
}
