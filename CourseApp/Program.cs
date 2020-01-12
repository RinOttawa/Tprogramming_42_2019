using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double Mathhh(double x)
        {
            double y;
            y = Math.Pow(Math.Pow(Math.Asin(x), 2) + Math.Pow(Math.Cos(x), 4), 3);
            return y;
        }

        public static void Сalculation(double xH, double xK, double dx)
        {
            int i = 0;
            for (double x = xH; x <= xK; x = x + dx)
            {
                Console.WriteLine("{0} ", Mathhh(x));
                i++;
            }
        }

        public static void Сalculation2(List<double> b)
        {
            foreach (double i in b)
            {
               Console.WriteLine("{0} ", Mathhh(i));
            }
        }

        public static void Main()
        {
            Console.WriteLine("Task A:");
            Сalculation(0.26, 0.66, 0.08);
            Console.WriteLine("Task B:");
            List<double> b = new List<double>() { 0.1, 0.35, 0.4, 0.55, 0.6 };
            Сalculation2(b);
        }
    }
}