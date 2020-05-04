using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr9
{

    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1);
            Fraction b = new Fraction(2);

            Console.WriteLine($"a = {a.get_digit()}");
            Console.WriteLine($"b = {b.get_digit()}");

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");

            Console.WriteLine($"a > b = {a > b}");
            Console.WriteLine($"a >= b = {a >= b}");
            Console.WriteLine($"a < b = {a < b}");
            Console.WriteLine($"a <= b = {a <= b}");
            Console.WriteLine($"a == b = {a == b}");
            Console.WriteLine($"a != b = {a != b}");

            Console.ReadLine();
        }
    }
}