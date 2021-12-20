using System;

namespace bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi: ");
            string document = Console.ReadLine();
            document = document.Replace(" ", string.Empty);
            while (document.Length > 0)
            {
                Console.Write(document[0] + ":");
                int count = 0;
                for (int a = 0; a < document.Length; a++)
                {
                    if(document[0]== document[a])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                document = document.Replace(document[0].ToString(), string.Empty);
            }
            Console.WriteLine("n/ ---- chuong trinh nay duoc chay boi an dep trai");
            Console.ReadKey();
        }
    }
}
