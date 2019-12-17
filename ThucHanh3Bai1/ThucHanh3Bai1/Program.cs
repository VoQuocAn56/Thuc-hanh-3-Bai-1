using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            TienDien tienDien = new TienDien();
            TienDienMoi tienDienMoi = new TienDienMoi();
            Console.WriteLine("Tien dien");
            tienDien.Nhap();
            tienDien.HienThi();

            Console.WriteLine("\nTien dien moi");
            tienDienMoi.Nhap();
            tienDienMoi.HienThi();
            Console.ReadKey();
        }
    }
}
