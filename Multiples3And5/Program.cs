using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;

            while (num < 1000)
            {
                //check if num is divisable by 3 and adds it to the sum
                if(num % 3 == 0)
                {
                    //Console.WriteLine(num);
                    sum += num;
                }

                //checks if num is divisable by 5 and adds it to the sum
                if (num % 5 == 0)
                {
                    //Console.WriteLine(num);
                    sum += num;
                }

                num++;
            }

            Console.WriteLine($"Sum of all the multiples of 3 or 5 below 1000: {sum:n0}");

        }
    }
}
