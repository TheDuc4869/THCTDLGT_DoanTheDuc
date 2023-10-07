using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class MangSinhVien
    {
        private SinhVien[] a;
        private int sl;
        internal SinhVien[] A { get => a; set => a = value; }

        public MangSinhVien() { }
        public MangSinhVien(SinhVien[] a) {
            this.a = a;
        }
        public bool TonTai(string msx, int vt)
        {
            for (int i = 0; i < vt; i++)
            {
                if (a[i].Maso.CompareTo(msx) == 0)
                    return true;
            }
            return false;
        }


        public void Nhap()
        {
            Console.Write("Nhap so luong sinh vien: ");
            sl = int.Parse(Console.ReadLine());
            a = new SinhVien[sl];
            for (int i = 0; i <= sl-1 ; i++)
            {
                a[i] = new SinhVien();
                Console.Write("Nhap ma so: ");
                string maso = Console.ReadLine();
                while (TonTai(maso, i))
                {
                   Console.Write("Ma so sinh vien da ton tai! \nNhap lai ma so: ");
                   maso = Console.ReadLine();
                }
                
                
                a[i].maso = maso;
                a[i].InPut();
            }
        }
        public void Xuat()
        {
            for (int i = 1; i <= sl; i++)
            {
                a[i-1].OutPut();
            }
        }
    }
}
