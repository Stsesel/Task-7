using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
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


            double S1;
            double S2;
            GetParam1(a1, b1, c1, out S1);
            GetParam2(a2, b2, c2, out S2);
            Console.WriteLine(S1);
            Console.WriteLine(S2);
            

            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
                Console.ReadKey();
            }
            
            if (S1 < S2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
                Console.ReadKey();
            }

            Console.ReadKey();
        }


        static void GetParam1(int a1, int b1, int c1, out double S1)
        {
            int p1 = 0;
            p1 = (a1 + b1 + c1) / 2;
            S1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            
        }
        static void GetParam2(int a2, int b2, int c2, out double S2)
        {
            int p2 = 0;
            p2 = (a2 + b2 + c2) / 2;
            S2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));

        }


    }

}




