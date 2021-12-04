using System;

namespace b4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            if (b + c >= a || a + c >= b || a + b >= c)
            {
                Console.WriteLine("3 so tren la canh cua mot tam giac");
            }
            else
                Console.WriteLine("3 so tren khong phai la canh cua mot tam giac");
            Console.ReadKey();
        }
    }
}
