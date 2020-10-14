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

        public static List<double> Сalculation(double xH, double xK, double dx)
        {
            int i = 0;
            List<double> output = new List<double>();
            for (double x = xH; x <= xK; x = x + dx)
            {
                output.Add(Mathhh(x));
                Console.WriteLine(Mathhh(x));
                i++;
            }

            return output;
        }

        public static List<double> Сalculation2(List<double> b)
        {
            List<double> output = new List<double>();
            foreach (double i in b)
            {
               output.Add(Mathhh(i));
               Console.WriteLine(Mathhh(i));
            }

            return output;
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