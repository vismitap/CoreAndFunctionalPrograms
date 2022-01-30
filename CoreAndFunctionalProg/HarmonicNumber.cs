using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAndFunctionalProg
{
    public class HarmonicNumber
    {
        public void CalHarmonicNo()
        {
            Console.WriteLine("Enter a number N: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double ans = 0;
            string ansStr = "";
            int j = 1;
            if (num != 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    ans += ((double)1 / i);
                    if (j == 1)
                    {
                        ansStr += "1 / 1";
                    }
                    ansStr += $" + 1 / {j++}";

                }
            }
            else
            {
                Console.WriteLine("The number should be > 0");
            }
           
            Console.WriteLine(ansStr+" = " + ans);

        }

    }
} 
