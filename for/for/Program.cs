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
            for (int i = 0; i < k; i++) Console.Write(n + " ");

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
            Console.WriteLine("K= " + x);

        }
        static void for3()
        {
            Console.Write("A<B, A: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            for (int i = n; i > k; i--)
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
                Console.WriteLine($"{i}kg ={ i * k} tenge");

            }


        }
        static void for5()
        {
            Console.Write("double A: ");
            double k = Convert.ToDouble(Console.ReadLine());
            for (double i = 0.1; i <= 1; i = i + 0.1)
            {
                Console.WriteLine($"{i}kg ={ k * i} tenge");

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
            int sum = 0;
            for (int i = a; i <= b; i++)
                sum += i * i;
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
                sum *= i;
            Console.WriteLine(sum);
        }
        static void for10()
        {
            Console.Write("int N: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= a; i++)
            {

                sum = sum + 1 / i;
                Console.Write($"+{1 / i}");
            }
            Console.WriteLine("=" + sum);
        }
        static void for11()
        {
            Console.Write("int N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 0; i <= n; i++)
            {
                sum += Math.Pow(n + i, 2);
            }
            Console.WriteLine("=" + sum);
        }
        static void for12()
        {
            Console.Write("int N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 1;
            for (double i = 1.1; i < n; i = i + 0.1)
            {
                sum *= i;
                Console.WriteLine(i);
            }
            Console.WriteLine("=" + sum);
        }
        static void for13()
        {
            Console.Write("int N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += -1 * Math.Pow(-1, i) + (-1 * Math.Pow(-1, i) * i / 10);

            }
            Console.WriteLine("=" + sum);
        }
        static void for14()
        {
            Console.Write("int N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= n; i = i + 2)
            {
                sum += i;
            }
            Console.WriteLine("=" + sum);
        }
        static void for15()
        {
            Console.Write("int A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("int N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 1;
            for (double i = 0; i < n; i++)
            {
                sum *= a;
            }
            Console.WriteLine("=" + sum);
        }
        static void for16()
        {
            Console.Write("float A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("int N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 1;
            for (double i = 0; i <= n; i++)
            {
                sum = Math.Pow(a, i);
                Console.WriteLine($"{a}^{i}={sum}");
            }

        }
        static void for17()
        {
            Console.Write("double A:");
            double a = int.Parse(Console.ReadLine());
            Console.Write("int N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 0; i <= n; i++)
            {
                sum += Math.Pow(a, i);
            }
            Console.WriteLine(sum);
        }
        static void for18()
        {
            Console.Write("double A:");
            double a = int.Parse(Console.ReadLine());
            Console.Write("int N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 0; i <= n; i++)
            {
                sum += Math.Pow(-1, i) * Math.Pow(a, i);

            }
            Console.WriteLine(sum);
        }
        static void for19()
        {
            Console.Write("double N:");
            double n = double.Parse(Console.ReadLine());
            double sum = 1;
            for (double i = 1; i <= n; i++)
                sum *= i;
            Console.WriteLine(sum);
        }
        static void for20()
        {
            Console.Write("double N:");
            double n = double.Parse(Console.ReadLine());
            double sum = 1;
            double  sum2=0;
            for (double i = 1; i <= n; i++)
            {
                sum *= i;
                sum2 += sum;
            }
                Console.WriteLine(sum2);
            }
        static void for21()
        {
            Console.Write("double N:");
            double n = double.Parse(Console.ReadLine());
            double sum = 1;
            double sum2 = 1;
            for (double i = 1; i <= n; i++)
            {
                sum *= i;
                sum2 += 1/sum;
            }
            Console.WriteLine(sum2);
            Console.WriteLine(Math.Exp(1));
        }
        static void for22()
        {
            Console.Write("double X:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("double N:");
            double n = double.Parse(Console.ReadLine());
            double sum = 1;
            double sum1 = 1;
            double sum2 = 1;
            for (double i = 1; i <= n; i++)
            {
                sum *= i;
                sum1 = Math.Pow(x, i);
                sum2 +=  sum1/ sum;
                Console.WriteLine(sum1);
            }
            Console.WriteLine(sum2);
            Console.WriteLine(Math.Exp(x));
        }
        static void Main(string[] args)
        {

            for22();
            Console.ReadKey();
        }
    }
}
