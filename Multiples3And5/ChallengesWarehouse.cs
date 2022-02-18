using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class ChallengesWarehouse
    {
        public static void Multiples3And5()
        {
            int num = 1;
            int sum = 0;

            Console.WriteLine($"Sum of all the multiples of 3 or 5 below 1000: ");

            while (num < 1000)
            {
                //check if num is divisable by 3 or 5 but not both and adds it to the sum
                if (num % 3 == 0 || num % 5 == 0)
                {
                    //Console.WriteLine(num);
                    sum += num;
                }

                num++;
            }

            Console.WriteLine(sum);
        }

        public static void FibonacciEvenSum()
        {
            //An Fibonacci sequence is a series of numbers when the next
            // number is found by adding up the two numbers before it.

            //if you want to run the sequence from 0
            //xn = 0
            //xnMinus1 = 1

            //This is set up to start at 1 and go and in sequence till it reaches an upper limit

            long xn = 1;
            long xnMinus1 = 0;
            long xnPlaceHolder = 0;

            Console.WriteLine("\nCoding Challenge 2: FibonacciEvenSum");

            while (xn <= 4000000)
            {
                //write the number if it is an even number
                if (xn % 2 == 0)
                {
                    Console.Write(xn + " ");
                }
                
                //put xn into a placeholder, xn = next number in sequence, put original value of xn into xnMinus1
                xnPlaceHolder = xn;
                xn = xn + xnMinus1;
                xnMinus1 = xnPlaceHolder;
            }

            Console.WriteLine();
        }

        public static void TenDigitFibonacci()
        {
            long xn = 0;
            long xnMinus1 = 1;
            long xnPlaceHolder = 0;
            int index = 0;

            Console.WriteLine("\nCoding Challenge 3: TenDigitFibonacci");

            //This will loop till the fibanacci sequence goes over 10 digits
            while (xn <= 1000000000)
            {

                //Console.WriteLine($"{xn} ");
                //Console.WriteLine($"F{index}");
                index++;

                //put xn into a placeholder, xn = next number in sequence, put original value of xn into xnMinus1
                xnPlaceHolder = xn;
                xn = xn + xnMinus1;
                xnMinus1 = xnPlaceHolder;
            }
            //This will print the Number and the index of the fibonacci sequence
            Console.WriteLine($"First Number over 10 digits: {xn}");
            Console.WriteLine($"       Index of that number: F{index}");

        }

        public static void LongestCollatz()
        {
            int start = 2;
            int terms = 0;
            int longestRun = 0;


            Console.WriteLine("\nChoding Challenge 4: LongestCollatz");

            while (start <= 1000)
            {
                int n = start;
                int loopTerms = 1;

                //Console.WriteLine(n);

                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    //Console.WriteLine(n);
                    loopTerms++;
                }
                if (loopTerms > terms)
                {
                    terms = loopTerms;
                    longestRun = start;
                }
                start++;
            }
            Console.WriteLine($"The number with the longest chain: {longestRun}");
            Console.WriteLine($"                            Terms: {terms}");
        }
    }
}
