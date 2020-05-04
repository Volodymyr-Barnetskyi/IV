using System;
using System.Collections.Generic;
using System.Text;

namespace pr9
{
    class Fraction
    {
        private double digit;
        public Fraction()
        {
            digit = 0;
        }

        public Fraction(double d)
        {
            digit = d;
        }

        public void toString()
        {
            Console.WriteLine($"Digit in string - {digit}");
        }
        public double get_digit()
        {
            return digit;
        }

        public void set_digit(double d)
        {
            digit = d;
        }
        public static double operator +(Fraction obj1, Fraction obj2)
        {
            double result;
            result = obj1.get_digit() + obj2.get_digit();
            return result;
        }

        public static double operator -(Fraction obj1, Fraction obj2)
        {
            double result;
            result = obj1.get_digit() - obj2.get_digit();
            return result;
        }

        public static double operator *(Fraction obj1, Fraction obj2)
        {
            double result;
            result = obj1.get_digit() * obj2.get_digit();
            return result;
        }

        public static double operator /(Fraction obj1, Fraction obj2)
        {
            double result;
            result = obj1.get_digit() / obj2.get_digit();
            return result;
        }

        public static bool operator !=(Fraction obj1, Fraction obj2)
        {
            if (obj1.get_digit() != obj2.get_digit())
                return true;
            return false;
        }
        public static bool operator ==(Fraction obj1, Fraction obj2)
        {
            if (obj1.get_digit() == obj2.get_digit())
                return true;
            return false;
        }

        public static bool operator <(Fraction obj1, Fraction obj2)
        {
            if (obj1.get_digit() < obj2.get_digit())
                return true;
            return false;
        }

        public static bool operator >(Fraction obj1, Fraction obj2)
        {
            if (obj1.get_digit() > obj2.get_digit())
                return true;
            return false;
        }

        public static bool operator <=(Fraction obj1, Fraction obj2)
        {
            if (obj1.get_digit() <= obj2.get_digit())
                return true;
            return false;
        }

        public static bool operator >=(Fraction obj1, Fraction obj2)
        {
            if (obj1.get_digit() >= obj2.get_digit())
                return true;
            return false;
        }
    }

}
