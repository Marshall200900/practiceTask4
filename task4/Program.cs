using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Program
    {
        static double Input(string sentence, double minBorder = double.MinValue, double maxBorder = double.MaxValue)
        {
            double result = 0;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                ok = double.TryParse(Console.ReadLine(), out result);
                if (result < minBorder || result > maxBorder)
                {
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
        public static double FindRoot(double e, double a = 0, double b = 1,double root = 1)
        {
            root = (a + b) / 2;
            if (Math.Abs(b - a) > e)
            {
                double fa = Math.Pow(a, 4) + 2 * Math.Pow(a, 3) - a - 1;
                double fx = Math.Pow(root, 4) + 2 * Math.Pow(root, 3) - root - 1;
                if (fa * fx > 0)
                {
                    a = root;
                }
                else b = root;
                return FindRoot(e, a, b, root);
            }
            else return root;
                 
        }
        static void Main(string[] args)
        {
            double e = Input("Введите положительное число e: ");
            Console.WriteLine("Результат: "+FindRoot(e));
            Console.ReadKey();
        }
    }
}
