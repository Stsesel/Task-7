using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetParam(a, out S, out V);
            Console.WriteLine(S);
            Console.WriteLine(V);
            Console.ReadKey();
        }

        static void GetParam(int a, out double S, out double V)
        {
            S = 6 * (Math.Pow(a, 2));
            V = Math.Pow(a, 3);

        }
    }
}
