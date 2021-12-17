using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double S1, S2, P1, P2;
            GetParam1(a1, b1, c1, out P1, out S1);
            GetParam2(a2, b2, c2, out P2, out S2);
            Console.WriteLine("Площадь первого треугольника {0}", S1);
            Console.WriteLine("Площадь второго треугольника {0}", S2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else Console.WriteLine("Площадь второго треугольника больше");          
            Console.ReadKey();
        }

        private static double GetParam1(int a1, int b1, int c1, out double P1, out double S1)
        {
            P1 = (a1 + b1 + c1) / 2;
            S1 = Math.Sqrt(P1 * (P1 - a1) * (P1 - b1) * (P1 - c1));
            return S1;
        }
        static double GetParam2(int a2, int b2, int c2, out double P2, out double S2)
        {
            P2 = (a2 + b2 + c2) / 2;
            S2 = Math.Sqrt(P2 * (P2 - a2) * (P2 - b2) * (P2 - c2));
            return S2;
        }
    } 
}

