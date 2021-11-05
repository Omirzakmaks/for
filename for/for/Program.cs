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
        static void for3()
        {
            Console.Write("A<B, A: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for (int i = n; i >k; i--)
            {
                Console.Write(i + " ");
                x++;
            }
            Console.WriteLine("K= " + x);

        }
        static void for4()
        {
            Console.Write("double A: ");
            double k = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}kg ={ i* k} tenge");
                
            }
            

        }
        static void for5()
        {
            Console.Write("double A: ");
            double k = Convert.ToDouble(Console.ReadLine());
            for (double i = 0.1; i <= 1; i=i+0.1)
            {
                Console.WriteLine($"{i}kg ={ k*i} tenge");

            }


        }
        static void for6()
        {
            Console.Write("double A: ");
            double k = Convert.ToDouble(Console.ReadLine());
            for (double i = 1; i <= 2; i = i + 0.2)
            {
                Console.WriteLine($"{i}kg ={ k * i} tenge");

            }
         }
        static void for7()
        {
            Console.Write("A<B int A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("A<B int B:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++)
                sum = sum + i;
                Console.WriteLine(sum);
        }
        static void for9()
        {
            Console.Write("A<B int A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("A<B int B:");
            int b = Convert.ToInt32(Console.ReadLine());
            int  sum = 0;
            for (int i = a; i <= b; i++)
            sum += i*i;
            Console.WriteLine(sum);
        }
        static void for8()
        {
            Console.Write("A<B int A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("A<B int B:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = a; i <= b; i++)
                sum *=i;
            Console.WriteLine(sum);
        }
        static void for10()
        {
            Console.Write("double N: ");
            int  a = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= a; i++)
            {
                
                sum =sum + 1 / i;
                Console.Write($"+{1/i}");
            }
            Console.WriteLine("="+sum);
        }
        static void Main(string[] args)
        {
            for10();
            Console.ReadKey();
        }
    }
}
