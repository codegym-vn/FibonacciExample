using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int fibonacciLength = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < fibonacciLength; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }
            Console.Write("\n");
            Console.Write("Enter the nth number of the Fibonacci Series: ");
            int fibonacciNumber = Convert.ToInt32(Console.ReadLine());
            fibonacciNumber = fibonacciNumber - 1;
            Console.Write(NthFibonacciNumber(fibonacciNumber));
            Console.ReadKey();
        }

        static int FibonacciSeries(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }
        static int NthFibonacciNumber(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
            }
        }

    }
}
