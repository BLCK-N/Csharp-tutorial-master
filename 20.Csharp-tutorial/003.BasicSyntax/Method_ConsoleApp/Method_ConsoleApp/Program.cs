using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_ConsoleApp
{
    class Program
    {
        public int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }

        public void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        public int Sum2Number(out int a, out int b)
        {
            int a_tmp = 2;
            int b_tmp = 3;

            a = a_tmp;
            b = b_tmp;

            return a + b;
        }

        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine("a, b = {0}, {1}", a, b);

            Program p = new Program();

            int max = p.FindMax(a, b);
            Console.WriteLine("Max = " + max);

            p.Swap(ref a, ref b);
            Console.WriteLine("Swap a, b = {0}, {1}", a, b);

            int c, d;
            int s = p.Sum2Number(out c, out d);
            Console.WriteLine("c, d, s = {0}, {1}, {2}", a, b, s);

            Console.ReadKey();
        }
    }
}
