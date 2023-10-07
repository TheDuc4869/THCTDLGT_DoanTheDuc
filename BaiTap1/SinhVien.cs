using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class SinhVien
    {
        public string maso;
        public string hoTen;
        private string chuyenNganh;
        private int namSinh;
        public float diemTB;
        private string loai;

        public SinhVien() { }

        public SinhVien(string maso, string hoTen, string chuyenNganh, int namSinh, float diemTB)
        {
            this.maso = maso;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
            
        }

        //Constructor for copy info -> svC
        public SinhVien(SinhVien c)
        {
            this.maso = c.maso;
            this.hoTen = c.hoTen;
            this.chuyenNganh = c.chuyenNganh;
            this.namSinh = c.namSinh;
            this.diemTB = c.diemTB;
        }

        public string Maso
        {
            get => maso;
            set => maso = value;
        }
        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }
        public string ChuyenNganh
        {
            get => chuyenNganh;
            set => chuyenNganh = value;
        }
        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }
        public float DiemTB
        {
            get => diemTB;
            set => diemTB = value;
        }

        public void InPut()
        {
            //Console.Write("Ma so Sinh Vien: ");
            //this.maso = Console.ReadLine();

            Console.Write("Name: ");
            this.hoTen = Console.ReadLine();


            Console.Write("Chuyen Nganh: ");
            this.chuyenNganh = Console.ReadLine();
            
            Console.Write("Nam Sinh: ");
            this.namSinh = int.Parse(Console.ReadLine());
            while (GetAge() > 70 || GetAge() < 17)
            {
                Console.WriteLine("Khong hop le");
                Console.Write("Nhap lai nam sinh: ");
                this.namSinh = int.Parse(Console.ReadLine());
            }

            Console.Write("Diem Trung Binh: ");
            diemTB = float.Parse(Console.ReadLine());
            while (this.diemTB < 0 || this.diemTB > 10)
            {
                Console.WriteLine("Diem khong hop le");
                Console.Write("Nhap lai diem trung binh: ");
                this.diemTB = float.Parse(Console.ReadLine());
            }
        }

        public void XepLoai()
        {
            if (this.diemTB < 5) {
                Console.WriteLine("Kem"); }
            else if (this.diemTB >= 5 && this.diemTB < 7){ ;
                Console.WriteLine("Trung Binh");}
            else if (this.diemTB >= 7 && this.diemTB < 8) { 
                Console.WriteLine("Kha");
            }
            else Console.WriteLine("Gioi");
        }
        public int GetAge()
        {
            return DateTime.Now.Year - namSinh;
        }
        public bool CheckAge()
        {
            if (GetAge() < 17 || GetAge() > 70)
                return false;
            return true;
        }

        public void Prinf_CheckAge()
        {
            if (CheckAge() == true)
                Console.WriteLine("Tuoi hop le");
            else Console.WriteLine("Tuoi khong hop le");
        }
       
        public bool CheckMark()
        {
            if (this.diemTB < 0 || this.diemTB > 10)
                return false;
            return true;
        }

        public void Prinf_CheckMark()
        {
            if (CheckMark() == true)
                Console.WriteLine("Diem hop le");
            else Console.WriteLine("Diem khong hop le");
        }
        


        public void OutPut()
        {
            Console.WriteLine( $"Ma so: {this.maso}  \nHo va Ten: {this.hoTen}  \nTuoi: {GetAge()}  \nChuyen Nganh: {this.chuyenNganh}  \nDiem Trung Binh: {this.diemTB} ");
        }
    }

}
