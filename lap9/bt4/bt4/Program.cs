using System;

namespace bt4
{
    class Program
    {
       public static void Main()
        {
            student[] DSSV;
            int n;
            Console.WriteLine("Nhap so luong sv:");
            n = int.Parse(Console.ReadLine());
            DSSV = new student[n];
            Console.WriteLine(" ====Nhap Danh Sach Sinh Vien====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new student();
                Console.Write("Nhap ma SV{0}:", i + 1);
                DSSV[i].Studentcode = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV{0}:");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap tuoi:");
                DSSV[i].Age =int.Parse (Console.ReadLine());
                Console.Write("Nhap DTB:");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("====Xuat Danh Sach Sinh Vien====");
            foreach (student sv in DSSV)
                sv.Show();
            Console.ReadLine();
        }
    }
}
