using System;

namespace b3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số thứ ba: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số thứ tư: ");
            int d = int.Parse(Console.ReadLine());
            int max = (a >= b && a >= c && a >= d) ? a : ((b >= c && b >= d) ? b : (c >= d) ? c : d);
            int min = (a < b && a < c && a < d) ? a : ((b < c && b < d) ? b : (c < d) ? c : d);
            Console.WriteLine(" max trong bốn số {0}, {1}, {2], {3} là {4}", a, b, c, d, max);
            Console.WriteLine(" min trong bốn số {0}, {1}, {2}, {3} là {4}", a, b, c, d, min);
            Console.ReadKey();
        }
    }
}
