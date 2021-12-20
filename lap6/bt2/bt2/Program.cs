using System;

namespace bt2
{
    class Program
    {
        static double Luythua(float x, int n)
        {
            double t = 1;
            for (int i = 1; i <= n; i++)
            {
                t *= x;
            }
            return t;
        }
        static double tong(int n, float x)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Luythua(x, i);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Write("Nhap luy thua: ");
            float x = float.Parse(Console.ReadLine());
            System.Console.Write("Hay nhap n: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("\n");
            System.Console.WriteLine(tong(n, x));
            {

            }
        }
    }
}
