using System;

namespace bt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hay nhap so dau tien: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("hay nhap so thu hai: ");
            int secondNum = int.Parse(Console.ReadLine());

            
            while ((firstNum <= 0) || (secondNum < firstNum))
            {
                Console.Write("hay nhap lai so dau tien: ");
                firstNum = int.Parse(Console.ReadLine());
                Console.Write("hay nhap lai so thu hai: ");
                secondNum = int.Parse(Console.ReadLine());
            }

            
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 7 == 1) System.Console.WriteLine(i);
            }
        }
    }
}
