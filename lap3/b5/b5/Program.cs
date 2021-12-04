using System;

namespace b5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("nhap so kilomets: ");
            float a = float.Parse(Console.ReadLine());
            if (a <= 1)
            {
                Console.Write("so tien thanh toan: {0} dong", a = 15000);

            }
            else if (a > 1 && a <= 5)
            {
                Console.Write("so tien thanh toan: {0} dong", 1 * 15000 + (a - 1) + 13500);

            }
            else if (a > 5 && a <= 120)
            {
                Console.Write("so tien thanh toan: {0} dong", (1 * 15000 + 4 * 13500) + (a - 5) * 11000);

            }
            else if (a > 120)
            {
                double b = ((1 * 15000 + 4 * 13500) + ((a - 5) * 11000));
                Console.Write("so tien thanh toan: {0} dong", (b * 0.9));
            }
            else
            {
                Console.Write("moi ban nhap so km");
            }
            Console.ReadKey();
        }
    }
}
