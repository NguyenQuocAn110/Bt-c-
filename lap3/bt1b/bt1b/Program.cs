using System;

namespace bt1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap he so cua phuong trinh ax2 + bx +c = 0");
            Console.Write("a = "); float a = float.Parse(Console.ReadLine());
            Console.Write("b = "); float b = float.Parse(Console.ReadLine());
            Console.Write("c = "); float c = float.Parse(Console.ReadLine());
            if (a != 0)
            {
                float delta = (b * b - 4 * a * c);
                Console.WriteLine("delta = {0}", delta);
                if (delta < 0)
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
                else if (delta > 0)
                {
                    Console.WriteLine("phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", ((-b) + Math.Sqrt(delta)) / 2 * a);
                    Console.WriteLine("x2 = {0}", ((-b) - Math.Sqrt(delta)) / 2 * a);
                }
                else if (delta == 0)
                {
                    Console.WriteLine("phương trình có nghiệm kép");
                    Console.WriteLine("x1 = x2 = {0}", -b / 2 * a);
                }
            }
            else
            {
                Console.WriteLine("phương trình có 1 nghiệm duy nhất");
                Console.WriteLine("x = {0}", -c / b);
            }
            Console.ReadKey();
            }
        } 
    }

