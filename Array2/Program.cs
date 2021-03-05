using System;

namespace Array2
{
    class Program
    {
        static int[] arr;
        static int[] arb;
        static void Main(string[] args)
        {
            do
            {
                ShowMenu();
                int x = Int32.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Step1();
                        break;
                    case 2:
                        Step2();
                        break;
                    case 3:
                        Step3();
                        break;
                    case 4:
                        Step4();
                        break;
                    case 5:
                        Step5();
                        break;
                    case 6:
                        Step6();
                        break;
                    case 7:
                    default:
                        return;
                }
                Console.WriteLine();
            } while (true);
        }

        static void Step1()
        {
            Console.WriteLine("Nhap so phan tu:");
            int num = Int32.Parse(Console.ReadLine());
            arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        static void Step2()
        {
            Console.WriteLine("Mang sap xep theo thu tu giam dan:");
            arb = (int[])arr.Clone();
            Array.Sort(arb, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));
            foreach (int i in arb)
            {
                Console.Write(i + " ");
            }
        }

        static void Step3()
        {
            Console.WriteLine("Mang ban dau la:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        static void Step4()
        {
            arb = (int[])arr.Clone();
            Array.Sort(arb, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));
            Console.WriteLine("phan tu lon nhat:" + arb[0]);
            Console.WriteLine("phan tu nho nhat:" + arb[arb.Length - 1]);
        }

        static void Step5()
        {
            int total = 0;
            int numEven = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    total = total + arr[i];
                    numEven++;
                }
            }
            Console.WriteLine("Tong cac phan tu co chi so chan la:" + numEven);
            Console.WriteLine("Trung binh cong cac phan tu co chi so chan la:" + (double)total / numEven);
        }

        static void Step6()
        {
            arb = (int[])arr.Clone();
            Array.Sort(arb, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));
            int SoPhanTuLN = 1;
            for (int i = 1; i < arb.Length; i++)
            {
                if (arb[i] == arb[0])
                {
                    SoPhanTuLN++;
                }
            }
            Console.WriteLine("So phan tu lon nhat la:" + SoPhanTuLN);
        }
        static void ShowMenu()
        {
            Console.WriteLine("1.Nhap thong tin mang");
            Console.WriteLine("2.Sap xep mang (giam dan)");
            Console.WriteLine("3.Hien thong tin ve mang");
            Console.WriteLine("4.In ra phan tu lon nhat/nho nhat");
            Console.WriteLine("5.Tinh tong va trung binh cong cac phan tu co chi so chan trong mang");
            Console.WriteLine("6.In ra so luong cua cac phan tu co gia tri lon nhat");
            Console.WriteLine("7.Thoat");
        }
    }
}
