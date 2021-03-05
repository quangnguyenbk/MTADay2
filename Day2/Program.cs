using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nhan vien:");
            int numNV = Int32.Parse(Console.ReadLine());
            Employee[] employees = new Employee[numNV];
            for( int i = 0; i< numNV; i++)
            {
                Employee e = new Employee();
                e.Nhap();
                employees[i] = e;
            }

            Employee em= employees.Length > 0 ? employees[0] : null;
            int total = 0;
            foreach(Employee e in employees)
            {
                if (em.Luong1 < e.Luong1)
                {
                    em = e;
                }
                if ( e.Luong1 > 2000)
                {
                    total = total + 1;
                }
            }

            Console.WriteLine("Nhan vien co luong cao nhat la:");
            em.HienThi();
            Console.WriteLine("Tong so nhan vien co luong > 2000 la: " + total);
        }
    }
}
