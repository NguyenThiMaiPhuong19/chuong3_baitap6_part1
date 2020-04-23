using System;
using System.Collections.Generic;
using System.Text;

namespace chuong3_VD1
{
    class SinhVien
    {
        public string MSV;
        private string HoTen;
        private int NamSinh;
        private double DiemLapTrinh;
        private double DiemCSDL;
        private double DiemTB;
       
        public SinhVien()
        {
            MSV = "";
            HoTen = "";
            NamSinh = 1990;
            DiemLapTrinh = DiemCSDL = DiemTB = 0;
        }

        public SinhVien(string HoTen,int NamSinh, double DiemLapTrinh, double DiemCSDL, double DiemTB )
        {
            Console.WriteLine("\n goi ham xay dung co 5 tham so");
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLapTrinh = DiemLapTrinh;
            this.DiemCSDL = DiemCSDL;
        }    

       
        public void nhap()
        {
            Console.WriteLine("nhap MSV");
            MSV = Console.ReadLine(); 
            Console.WriteLine("nhap ten sinh vien");
            HoTen = Console.ReadLine();
            Console.WriteLine("nhap nam sinh");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap diem lap trinh");
            DiemLapTrinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap diem CSDL");
            DiemCSDL = Convert.ToInt32(Console.ReadLine());
            
        }

        public void DIEMTB()
        {
            DiemTB = (DiemLapTrinh + DiemCSDL)*0.5;
        }

        public void diemhon8()
        {
            if (DiemTB > 8)
                Console.WriteLine("sinh vien do la: " + HoTen);
        }
        public void xuat()
        {
            Console.WriteLine("thong tin sinh vien \n Ma Sinh Vien : {0} \t Ho Ten : {1} \t Nam Sinh : {2} \t Diem Lap Trinh : {3} \t Diem CSDL : {4} \t Diem TB : {5} ", MSV, HoTen, NamSinh, DiemLapTrinh, DiemCSDL, DiemTB);
        }

        
     
    }

    
}
