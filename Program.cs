using System;

namespace chuong3_VD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DanhSachSinhVien httt = new DanhSachSinhVien();
            httt.nhap();
            httt.sapxep();
            httt.xuat();
            httt.diemlonhon();
            Console.ReadLine();
        }
    }
}

    
