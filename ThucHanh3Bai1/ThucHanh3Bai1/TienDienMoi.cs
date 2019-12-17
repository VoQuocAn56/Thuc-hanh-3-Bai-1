using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3Bai1
{
    class TienDienMoi:TienDien
    {
        int DinhMuc;

        public TienDienMoi() : base() {
            DinhMuc = 0;
        }

        public TienDienMoi(string HoTen, string DiaChi, int SCTDThangNay, int SCTDThangTruoc, int dinhmuc)
            : base(HoTen, DiaChi, SCTDThangNay, SCTDThangTruoc) {
            DinhMuc = dinhmuc;
        }

        public override void Nhap()
        {
            KiemTraDinhMuc();
            Console.Write("Nhap ho ten: ");
            string hoten = Console.ReadLine();
            NhapHoTen(hoten);

            Console.Write("Nhap dia chi: ");
            string DiaChi = Console.ReadLine();
            NhapDiaChi(DiaChi);

            KiemTraSCTDThangNay();
            KiemTraSCTDThangTruoc();       
        }

        public override void HienThi()
        {
            Console.WriteLine();
            int SCTDThangNay = LaySoCongToDienThangNay();
            int SCTDThangTruoc = LaySoCongToDienThangTruoc();
            int SCTDTieuThu = SoCongDienDaDung(SCTDThangNay, SCTDThangTruoc);
            int ThanhTien = TinhTien(SCTDThangTruoc, SCTDThangNay);
            Console.WriteLine("Dinh muc: {0}", DinhMuc);
            Console.WriteLine("Ho ten: {0}", LayHoTen());
            Console.WriteLine("Dia chi: {0}", LayDiaChi());
            Console.WriteLine("So cong to dien thang nay: {0}", SCTDThangNay);
            Console.WriteLine("So cong to dien thang truoc: {0}", SCTDThangTruoc);
            Console.WriteLine("So cong to dien thieu thu: {0}", SCTDTieuThu);
            Console.WriteLine("Thanh tien {0}", ThanhTien);
        }

        public override int TinhTien(int SCTDThangTruoc, int SCTDThangNay)
        {
            Console.WriteLine("tinh tien 2");
            int SCTDTieuThu = SoCongDienDaDung(SCTDThangTruoc, SCTDThangNay);

            if (SCTDTieuThu < DinhMuc) {
                return base.TinhTien(SCTDThangTruoc, SCTDThangNay);
            }
            else{
                return SCTDTieuThu * 1600;
            }
           
        }

        public override void KiemTraSCTDThangNay()
        {
            bool KiemTra = false;
            do
            {
                try
                {
                    Console.Write("Nhap so cong to dien thang nay: ");
                    int SCTDThangNay = int.Parse(Console.ReadLine());
                    if (SCTDThangNay < 0)
                    {
                        Console.WriteLine("so cong to dien phai lon hon 0");
                        KiemTra = true;
                    }
                    else
                    {
                        if (SCTDThangNay < DinhMuc)
                        {
                            Console.WriteLine("so cong to dien phai lon hon dinh muc");
                            KiemTra = true;
                        }
                        else
                        {
                            NhapSoCongToDienThangNay(SCTDThangNay);
                            KiemTra = false;
                        }
                    }
                }
                catch
                {
                    KiemTra = true;
                    Console.WriteLine("Du lieu phai la so");
                }
            } while (KiemTra);
        }

        public override void KiemTraSCTDThangTruoc()
        {
            bool KiemTra = false;
            do
            {
                try
                {
                    Console.Write("Nhap so cong to dien thang truoc: ");
                    int SCTDThangTruoc = int.Parse(Console.ReadLine());
                    if (SCTDThangTruoc < 0)
                    {
                        Console.WriteLine("so cong to dien phai lon hon 0");
                        KiemTra = true;
                    }
                    else
                    {
                        if (SCTDThangTruoc < DinhMuc)
                        {
                            Console.WriteLine("so cong to dien phai lon hon dinh muc");
                            KiemTra = true;
                        }
                        else
                        {
                            NhapSoCongToDienThangTruoc(SCTDThangTruoc);
                            KiemTra = false;
                        }
                    }
                }
                catch
                {
                    KiemTra = true;
                    Console.WriteLine("Du lieu phai la so");
                }
            } while (KiemTra);
        }

        public void KiemTraDinhMuc() {
            bool KiemTra = false;
            do
            {
                try
                {
                    Console.Write("Nhap dinh muc: ");
                    DinhMuc = int.Parse(Console.ReadLine());
                    if (DinhMuc < 0)
                    {
                        Console.WriteLine("so cong to dien phai lon hon 0");
                        KiemTra = true;
                    }
                    else KiemTra = false;
                }
                catch
                {
                    KiemTra = true;
                    Console.WriteLine("Du lieu phai la so");
                }
            } while (KiemTra);
        }
    }
}
