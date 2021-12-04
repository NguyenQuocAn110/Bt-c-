using System;

namespace bt5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hay nhap so n: ");
            string n = Console.ReadLine();

            for (int i = 0; i < n.Length; i++)
            {
                sum += (int)(n[i] - '0');
            }
            Console.WriteLine("Tong cac so den n: {0}", sum);
            Console.ReadKey();
        }
    }
}
