using System;

namespace BaiTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            //SinhVien ChinChin = new SinhVien();
            //Console.WriteLine("Thong tin sinh vien:");
            //ChinChin.InPut();
            //Console.Write($"Kiem tra tuoi: ");
            //ChinChin.Prinf_CheckAge();
            //Console.Write($"Kiem tra diem trung binh: ");
            //ChinChin.Prinf_CheckMark();
            //ChinChin.OutPut();
            //Console.Write("Xep loai: ");
            //ChinChin.XepLoai();



            //TestSinhVien();
            TestMangSinhVien();
            Console.ReadKey();
        }

        static void TestSinhVien()
        {
            //SinhVien svA = new SinhVien();
            //svA.InPut();
            //Console.WriteLine();
            //Console.WriteLine("Thong tin svA: ");
            //svA.OutPut();
            //Console.Write("Xep loai: ");
            //svA.XepLoai();

            //SinhVien svB = new SinhVien("18DH001", "Lam Thanh Ngoc", "CNPM", 2000, 7.6F);
            //svB.OutPut();
            //Console.Write("Xep loai: ");
            //svB.XepLoai();

            //Console.WriteLine();

           

            

            //SinhVien svC = new SinhVien(svB);   
            
            //Console.Write("Cap nhat ten cho svC: ");
            //svC.hoTen = Console.ReadLine();
            //Console.Write("Cap nhat diem cho svC: ");
            //svC.diemTB = float.Parse(Console.ReadLine());
            //svC.OutPut();
            //Console.Write("Xep Loai: ");
            //svC.XepLoai();

            //svB.OutPut();
            //Console.Write("Xep loai: ");
            //svB.XepLoai();

                

        }
        static void TestMangSinhVien()  
        { 
            MangSinhVien dssv = new MangSinhVien(); 
            dssv.Nhap(); 
            Console.WriteLine("Danh sach sinh vien:"); 
            dssv.Xuat();
           
        }

    }
}
