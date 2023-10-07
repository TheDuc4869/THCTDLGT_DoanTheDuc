using System;

namespace BaiTap2
{
    class Program
    {

        static void TestConstructor1()
        {
            IntArray obj = new IntArray(20); 
            Console.WriteLine("Gia tri mang phat sinh: ");
            obj.Xuat();
        }
        static void TestConstructor2() { 
            int[] a = { 4, 7, 9, 10, 20, 8, 3, 17, 10, 6 };
            IntArray obj = new IntArray(a);
            Console.WriteLine("Gia tri mang: ");
            obj.Xuat(); 
        }
        static void TestConstructor3()
        {
            IntArray obj1 = new IntArray();
            obj1.Nhap();
            Console.WriteLine("Gia tri mang: "); obj1.Xuat(); 
            IntArray obj2 = new IntArray(obj1);
            Console.WriteLine("\nGia tri mang copy: "); obj2.Xuat();
        }
        static void TestTimTuanTu()
        {
            int k, x, kq;
            Console.Write(">>Nhap so luong mang: ");
            int.TryParse(Console.ReadLine(), out k);
            IntArray obj = new IntArray(k);
            Console.WriteLine(">>Cac phan tu:"); 
            obj.Xuat();

            Console.Write("\n>>Gia tri can tim x = "); 
            int.TryParse(Console.ReadLine(), out x);

            kq = obj.TimTuanTu(x);
            if (kq == -1) 
                Console.WriteLine("->Khong ton tai {0}!", x); 
            else Console.WriteLine("->Co {0} tai vi tri {1}", x, kq);
        }

        static void TestTimNhiPhan()
        {
            int z, kqua;
            IntArray objC = new IntArray();
            objC.Nhap();
            
            Console.WriteLine(">>Cac phan tu: ");
            objC.Xuat();
     
            Console.Write("\n>>Gia tri can tim x = ");
            z = int.Parse(Console.ReadLine());

            kqua = objC.TimNhiPhan(z);
            if (z == kqua)
            {
                Console.WriteLine($"->Co {z} tai vi tri {kqua}");
            }
            else
            {
                Console.WriteLine($"->Khong ton tai {z}!");
            }
        }




        static void TestInterchangeSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InterchangeSort();
            Console.WriteLine("\n>>Interchange Sort:");
            objTam.Xuat();
        }

        static void TestInsertionSort(IntArray obj)
        {
            IntArray objTam = new IntArray(obj);
            Console.WriteLine("\n>>Mang ban dau:");
            objTam.Xuat();
            objTam.InsertionSort();
            Console.WriteLine("\n>>Insertion Sort:");
            objTam.Xuat();

        }

        static void Main(string[] args)
        {
            //TestConstructor1();
            //TestConstructor2();
            //TestConstructor3();

            //IntArray cb = new IntArray();
            //cb.Nhap();
            //cb.Xuat();
            //Console.WriteLine(cb.TimTuanTu(20));
            //Console.WriteLine(cb.TimNhiPhan(3));


            //IntArray objA = new IntArray(10);
            //objA.Xuat();
            //Console.WriteLine(objA.TimTuanTu(5));

            //IntArray objB = new IntArray(10);
            //Console.WriteLine(objB.TimNhiPhan(24));



            //TestTimTuanTu();
            TestTimNhiPhan();



            IntArray obj = new IntArray(10);
            TestInterchangeSort(obj); 
            TestInsertionSort(obj);

        }
    }


    public class IntArray
    {
        private int[] arr;

        //Properties
        public int[] Arr
        {
            get => arr;
            set => arr = value;
        }

        public IntArray() { }

        public IntArray(int k)
        {
            arr = new int[k];
            Random rd = new Random();
            for (int i = 0; i < k; i++)
            {
                arr[i] = rd.Next(1, 200);
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public IntArray(int[] a)
        {
            this.arr = a;
        }
        public IntArray(IntArray obj)
        {
            this.arr = obj.arr;
        }
        public IntArray(int[] a, int left, int right)
        {
            arr = new int[right - left + 1];
            for (int i = left; i < right; i++)
                this.arr[i] = a[i];
        }


        public int TimTuanTu(int x)
        {

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x) return i;
            }

            return -1;
        }
        public int TimNhiPhan(int x)
        {
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (x == mid)
                {
                    return mid;
                }
                else if (x > mid)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }

        public bool KiemTraKT(int n)
        {
            return n > 0 && n < 1000000;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Cach 2:
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}
        }

        public void HoanVi(ref int a, ref int b)
        {
            int tam = a;
            a = b;
            b = tam;
        }

        public void InterchangeSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] > arr[j])
                        HoanVi(ref arr[i], ref arr[j]);
        }
        public void InsertionSort()
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int j = i;
                while (j - 1 >= 0 && arr[j - 1] > arr[j])
                {
                    HoanVi(ref arr[j - 1], ref arr[j]);
                    j--;
                }
            }
        }
        public void BubbleSort()
        {
            int n = arr.Length;
            for (int i = n - 1; i > 0; i--)
                for (int j = n - 1; j > (n - 1) - i; j--)
                    if (arr[j - 1] > arr[j])
                        HoanVi(ref arr[j - 1], ref arr[j]);
        }
        public void SelectionSort()
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int vt = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[vt] > arr[j])
                        vt = j;
                HoanVi(ref arr[i], ref arr[vt]);
            }

        }

        public void Quicksort(int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(low, high);

                Quicksort(low, pivotIndex - 1);
                Quicksort(pivotIndex + 1, high);
            }
        }
        public int Partition(int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    HoanVi(ref arr[i], ref arr[j]);
                }
            }
            HoanVi(ref arr[i + 1], ref arr[high]);
            return i + 1;
        }

        public void ShellSort()
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
            }
        }
        public void ShakerSort()
        {
            int n = arr.Length, left = 0, right = n - 1;
            while (left < right)
            {
                int templeft = right;
                for (int i = right; i > left; i--)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        HoanVi(ref arr[i - 1], ref arr[i]);
                        templeft = i;
                    }
                }
                left = templeft;
                int tempright = left;
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        HoanVi(ref arr[i - 1], ref arr[i]);
                        tempright = i;
                    }
                }
                right = tempright;
            }
        }

        //public void MergeSort(int left, int right, int mid)
        //{
        //    if (left < right)
        //    {
        //        MergeSort(left, mid - 1, (right + left) / 2);
        //        MergeSort(mid + 1, right, (right + left) / 2);
        //        Merge(left, right, mid);
        //    }
        //}
        //public void Merge(int left, int mid, int right)
        //{
        //    int arr1 = mid - left + 1;
        //    int arr2 = right - mid;

        //    IntArray L = new IntArray(arr, 0, arr1);
        //    IntArray R = new IntArray(arr, 0, arr2);

        //    int i = 0, j = 0;
        //    //Gộp 2 mảng như turn base
        //    int k = left;
        //    while (i < arr1 && j < arr2)
        //    {
        //        if (L[i] <= R[j])
        //        {
        //            arr[k] = L[i];
        //            i++; 
        //        }
        //        else
        //        {
        //            arr[k] = R[j];
        //            j++;
        //        }
        //        k++;
        //    }
        //}


    }

}

