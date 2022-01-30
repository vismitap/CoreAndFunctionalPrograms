using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProg
{
    internal class QuotientRemainder
    {
        public void calQuotientRemainder()
        {
            Console.WriteLine("Enter the dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            double quotient = dividend/divisor;
            Console.WriteLine($"\nThe Quotient is of {dividend}/{divisor} is: "+quotient);

            double remainder = dividend%divisor;
            Console.WriteLine($"The Remainer is of {dividend}/{divisor} is: "+remainder);

        }
    }
}
