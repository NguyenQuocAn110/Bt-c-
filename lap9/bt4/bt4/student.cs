using System;
using System.Collections.Generic;
using System.Text;

namespace bt4
{
    class student
    {
        private int s_code;
        private string s_name;
        private int s_age;
        private float s_mark;
        public student()
        {
            s_code = 1;
            s_name = "Nguyen Quoc An";
            s_age = 18;
            s_mark = 8;
        }
        public student(student stu)
        {
            s_code = stu.s_code;
            s_name = stu.s_name;
            s_age = stu.s_age;
            s_mark = stu.s_mark;
        }
        public student(int code,string ten,int tuoi,float dtb)
        {
            s_code = code;
            s_name = ten;
            s_age = tuoi;
            s_mark = dtb;
        }
        public int Studentcode
        {
            get { return s_code; }
            set { s_code = value; }
        }
        public string Name
        {
            get { return s_name; }
            set { s_name = value; }
        }
        public int Age
        {
            get { return s_age; }
            set { s_age = value; }
        }
        public float Mark
        {
            get { return s_mark; }
            set { s_mark = value; }
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0}", this.s_code);
            Console.WriteLine("Ten SV{0}", this.s_name);
            Console.WriteLine("Tuoi {0}", this.s_age);
            Console.WriteLine("Diem TB{0}", this.s_mark);
        }
    }
}
