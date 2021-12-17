using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double P, S;
            GetParam(a, out S, out P);
            Console.WriteLine(P);
            Console.WriteLine(S);
            Console.ReadKey();
        }
        static void GetParam (int a, out double S, out double P)
        {
            S = a * a * a;
            P = 6 * a * a;
        }
    }
}
