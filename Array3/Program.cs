using System;

namespace Array3
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
            Console.WriteLine("Nhap mang:");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        static void Step2()
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
        }

        static void Step3()
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i];
            }
            Console.WriteLine("Trung binh cong cac phan tu co chi so chan la:" + (double)total / arr.Length);
        }

        static void Step5()
        {
            int SoPhanTuLN = 0;
            for (int i = 0; i < arb.Length; i++)
            {
                if (arb[i] == 5)
                {
                    SoPhanTuLN++;
                }
            }
            Console.WriteLine("So phan tu bang 5 la:" + SoPhanTuLN);
        }
        static void ShowMenu()
        {
            Console.WriteLine("1.Nhap thong tin mang");
            Console.WriteLine("2.Hien thi du lieu cua mang");
            Console.WriteLine("3.Tinh gia tri trung binh cua cac phan tu trong mang");
            Console.WriteLine("4.Tim gia tri lon nhat trong mang");
            Console.WriteLine("5.Dem so luong cac phan tu co gia tri la 5");
        }
    }
}
