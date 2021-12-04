using System;

namespace bt1a
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 2, b = 0;
            if (b == 0)
            {
                Console.WriteLine("Error divide by zero");
            }
            else
            {
                Console.WriteLine("a/b = {0}", a / b);
                Console.ReadKey();
            }
    }
}
