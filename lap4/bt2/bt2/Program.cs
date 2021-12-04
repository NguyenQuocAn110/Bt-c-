using System;

namespace bt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            Console.WriteLine("nhap 2 so ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            while (n < 0 || m < 0)
            {
                Console.WriteLine("nhap lai 2 so lon hon 0: ");
                n = Convert.ToInt32(Console.ReadLine());
                m = Convert.ToInt32(Console.ReadLine());
            }
            int a = n;
            int b = m;
            if (n > m)
            {
                a = m;
                b = n;
            }
            for (int x = a; x <= b; x++)
            {
                if (x % 7 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
