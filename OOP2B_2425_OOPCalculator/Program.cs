using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2B_2425_OOPCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplication(5,10));
            Console.WriteLine(Division(50, 5));

            int a = 5;
            int b = 6;

            Console.WriteLine($"{a} divided by {b} is {Division(a,b)} r {Modulo(a,b)}");

            Console.ReadKey();
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            int prod = 0;

            for(int x = 0; x < b; x++)
            {
                prod = Addition(prod, a);
            }

            return prod;
        }

        static int Division(int a, int b)
        {
            int quo = 0;

            while (a >= b)
            {
                a = Subtraction(a, b);
                quo = Addition(quo, 1);
            }

            return quo;
        }

        static int Modulo(int a, int b)
        {
            while (a >= b)
            {
                a = Subtraction(a, b);
            }

            return a;
        }
    }
}
