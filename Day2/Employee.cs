using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Employee
    {
        string Ten;
        int Tuoi;
        int DoanhSo;
        int Luong;

        public Employee()
        {
        }

        public Employee(string ten, int tuoi, int doanhSo)
        {
            Ten1 = ten;
            Tuoi1 = tuoi;
            DoanhSo1 = doanhSo;
        }

        public void Nhap()
        {
            Console.WriteLine("nhap ten:");
            this.Ten = Console.ReadLine();
            Console.WriteLine("nhap tuoi:");
            this.Tuoi = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap doanh so:");
            this.DoanhSo = Int32.Parse(Console.ReadLine());
            switch (this.DoanhSo)
            {
                case 10:
                case 9:
                case 8:
                    Console.WriteLine("Tuyet voi");
                    this.Luong = this.DoanhSo * 1000 * 5 / 100;
                    break;
                case 7:
                    Console.WriteLine("Rat Tot");
                    this.Luong = this.DoanhSo * 35;
                    break;
                case 6:
                    Console.WriteLine("Tot");
                    this.Luong = this.DoanhSo * 1000 * 2 / 100;
                    break;
                case 5:
                    Console.WriteLine("Co co gang");
                    this.Luong = this.DoanhSo * 5;
                    break;
                case 4:
                    Console.WriteLine("Kem");
                    this.Luong = this.DoanhSo * (-5);
                    break;
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Rat Kem");
                    this.Luong = this.DoanhSo * (-10);
                    break;
                default:
                    Console.WriteLine("Nhap sai");
                    break;

            }
        }

        public void HienThi()
        {
            Console.WriteLine("ten: " + this.Ten + " tuoi: " + this.Tuoi + " doanhso: " + this.DoanhSo * 1000 + " Luong: " + this.Luong);
        }

        public string Ten1 { get => Ten; set => Ten = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }
        public int DoanhSo1 { get => DoanhSo; set => DoanhSo = value; }
        public int Luong1 { get => Luong; set => Luong = value; }
    }
}
