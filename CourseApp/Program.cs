using System;

namespace CourseApp
{
    public class Program
    {
        public static void Сalculation(double x_h, double x_k, double dx)
        {
            double y;
            for (double x = x_h; x <= x_k; x = x + dx)
            {
                y = Math.Pow(Math.Pow(Math.Asin(x), 2) + Math.Pow(Math.Cos(x), 4), 3);
                Console.WriteLine(y + " ");
            }
        }

        public static void Сalculation2()
        {
            double y2;
            double[] b = { 0.1, 0.35, 0.4, 0.55, 0.6 };
            for (int i = 0; i < 5; i++)
            {
                y2 = Math.Pow(Math.Pow(Math.Asin(b[i]), 2) + Math.Pow(Math.Cos(b[i]), 4), 3);
                Console.WriteLine(y2 + " ");
            }
        }

        public static void Main()
        {
            Console.WriteLine("Task A:");
            Сalculation(0.26, 0.66, 0.08);
            Console.WriteLine("Task B:");
            Сalculation2();
        }
    }
}