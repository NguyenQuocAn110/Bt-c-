using System;

namespace bt4
{
    class Program
    {
        static void Main(string[] args)
        {
            string hoten;
            float diemtoan, diemvan;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Write("nhap ho & ten hoc sinh: ");

            hoten = Console.ReadLine();
            System.Console.Write("nhap diem toan: ");

            diemtoan = float.Parse(Console.ReadLine());
            System.Console.Write("nhap diem van: ");

            diemvan = float.Parse(Console.ReadLine());
            System.Console.WriteLine("_________________________________");

            Console.WriteLine("Diem TB: {0}", DiemTrungBinh(diemtoan, diemvan));
        }
        static float DiemTrungBinh(float diemtoan, float diemvan)
        {

            return (diemtoan + diemvan) / 2;
        }
    }
}
