using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ctrl+k+d

namespace @for
{
    class Program
    {
        static void for1()
        {
            Console.Write("K: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++) Console.Write(n+" ");

        }
        static void for2()
        {
            Console.Write("A<B, A: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for (int i = k; i < n; i++)
            {
                Console.Write(i + " ");
                x++;
            }
            Console.WriteLine("K= "+x);


        }
        static void Main(string[] args)
        {
            for2();
            Console.ReadKey();
        }
    }
}
