using System;

namespace Array4
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
                string x = Console.ReadLine();
                switch (x)
                {
                    case "a":
                        Step1();
                        break;
                    case "b":
                        Step2();
                        break;
                    case "c":
                        Step3();
                        break;
                    case "d":
                        Step4();
                        break;
                    case "e":
                        Step5();
                        break;
                    case "f":
                        Step6();
                        break;
                    case "g":
                        Step7();
                        break;
                    case "h":
                        Step8();
                        break;
                    case "i":
                        Step9();
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
            
        }

        static void Step2()
        {
            Console.WriteLine("Nhap mang:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
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
            Console.WriteLine("Mang sap xep theo thu tu giam dan:");
            arb = (int[])arr.Clone();
            Array.Sort(arb, new Comparison<int>(
                  (i1, i2) => i2.CompareTo(i1)));
            foreach (int i in arb)
            {
                Console.Write(i + " ");
            }
        }

        static void Step5()
        {
            int total = 0;
            int numEven = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    total = total + arr[i];
                    numEven++;
                }
            }
            Console.WriteLine("Tong cac phan tu co chi so chan la:" + total);
        }

        static void Step6()
        {
            Console.WriteLine("Gia tri:");
            int value = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Vi tri:");
            int pos = Int32.Parse(Console.ReadLine());
            int[] arTemp = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                    arTemp[i] = arr[i];   
            }
            arTemp[pos] = value;
            for (int i = pos; i < arr.Length; i++)
            {
                arTemp[i+1] = arr[i];
               
            }
            arr = arTemp;

        }

        static void Step7()
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

        static void Step8()
        {
            bool isDX = true;
            for(int i = 0; i < arr.Length/2+1; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    isDX = false;
                    break;
                }   
            }
            Console.WriteLine(isDX ? "Doi xung" : "Khong doi xung");
        }

        static void Step9()
        {
            Array.Reverse(arr);
            Console.WriteLine();
            Step3();
        }
        static void ShowMenu()
        {
            Console.WriteLine("a.Nhap vao so phan tu cua mang");
            Console.WriteLine("b.Nhap mang");
            Console.WriteLine("c.In mang");
            Console.WriteLine("d.Sap xep mang theo thu tu giam dan");
            Console.WriteLine("e.In ra tong so cac so chan co trong mang");
            Console.WriteLine("f.Chen mot phan tu vao mang");
            Console.WriteLine("g.In ra tong so phan tu co gia tri lon nhat");
            Console.WriteLine("h.Kiem tra tinh doi xung cua mang");
            Console.WriteLine("i.Dao nguoc mang");
        }
    }
}
