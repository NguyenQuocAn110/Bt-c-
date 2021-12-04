using System;

namespace bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine("a [{0}]=", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
