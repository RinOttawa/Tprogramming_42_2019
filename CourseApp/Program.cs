using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var y = (a * Math.Pow(x, 2)) + (b * x);
            return y;
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            return new double[0];
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const double a = 2.2;
            const double b = 3.8;
            var resSingle = MyFunction(a, b, 4);
            Console.WriteLine(resSingle);
            var x = new double[] { 1, 2, 3, 4, 5 };
            var taskBRes = TaskB(a, b, x);
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y = {item}");
            }

            Console.ReadLine();
        }
    }
}
