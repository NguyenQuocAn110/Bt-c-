using System;

namespace bt2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Write("Hay nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            long ketqua = tong(n);
            Console.Write("Tong cac so 1 -> n {1} là: {0}", ketqua, n);
        }
        static long tong(int n)
        {

            long s = 0;
            int i = 1;
            for (; i < n; i++)
            {
                s += i;
            }
            return s;
        }
    }
}
