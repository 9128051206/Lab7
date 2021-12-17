using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1= Convert.ToInt32(Console.ReadLine());
            int c1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S1 = {0}, S2 = {1}", Geron(a1, b1, c1), Geron(a2, b2, c2));
            Console.Read();
        }
        static double Geron(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
