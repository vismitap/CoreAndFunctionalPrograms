using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Core And Functional Programs\n");
           
            bool flag = true;

            CoinFlip coin = new CoinFlip();
            LeapYear year = new LeapYear();
            pow2 pow = new pow2();
            HarmonicNumber num = new HarmonicNumber();
            Factors factors = new Factors();
            QuotientRemainder ans = new QuotientRemainder();

            while (flag)
            {
                Console.WriteLine("\nEnter 0 for Exit\n" +
               "1 for FlipCoin\n" +
               "2 for LeapYear\n" +
               "3 for PowerOf2\n" +
               "4 for HarmonicNumber\n" +
               "5 for PrimeFactors\n" +
               "6 for QuotientAndRemainder\n" +
               "7 for SwapTwoNumbers\n" +
               "8 for EvenOdd\n" +
               "9 for VowelOrConsonant\n" +
               "10 for LargestAmongThree\n");

                Console.WriteLine("Enter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 0:
                        flag = false;
                        break;

                    case 1:
                        coin.CalCoinFlipPerecnt();
                        break;

                    case 2:
                        year.IsLeapYear();
                        break;

                    case 3:
                        pow.CalPow2();
                        break;

                    case 4:
                        num.CalHarmonicNo();
                        break;

                    case 5:
                        factors.Factor();
                        break;

                    case 6:
                        ans.calQuotientRemainder();
                        break;



                }
            }

            
        }
    }
}
