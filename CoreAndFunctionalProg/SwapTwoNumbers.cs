using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProg
{
    internal class SwapTwoNumbers
    {
        public void SwapTwoNum()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers after swapping: ");

            firstNum += secondNum;
            secondNum = firstNum - secondNum;
            firstNum -= secondNum;

            Console.WriteLine("First num = " + firstNum + "\nSecond num = " + secondNum);
        }
    }
}
