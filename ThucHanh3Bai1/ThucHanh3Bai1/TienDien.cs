using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3Bai1
{
    class TienDien
    {
        string HoTen;
        string DiaChi;
        int SCTDThangNay;
        int SCTDThangTruoc;

        public TienDien() {
            this.HoTen = "";
            this.DiaChi = "";
            this.SCTDThangNay = 0;
            this.SCTDThangTruoc = 0;
        }

        public TienDien(string HoTen, string DiaChi, int SCTDThangNay, int SCTDThangTruoc) {
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
            this.SCTDThangNay = SCTDThangNay;
            this.SCTDThangTruoc = SCTDThangTruoc;
        }

        public int SoCongDienDaDung(int SCTDThangTruoc, int SCTDThangNay) {
            return SCTDThangTruoc - SCTDThangNay;
        }

        public virtual int TinhTien(int SCTDThangTruoc, int SCTDThangNay) {
            return SoCongDienDaDung(SCTDThangTruoc, SCTDThangNay) * 1200;
        }

        public virtual void Nhap() {
            Console.Write("nhap ho va ten: ");
            this.HoTen = Console.ReadLine();
            Console.Write("nhap dia chi: ");
            this.DiaChi = Console.ReadLine();

            KiemTraSCTDThangNay();
            KiemTraSCTDThangTruoc();
        }

        public virtual void HienThi() {
            Console.WriteLine();
            int SCTDTienThu = SoCongDienDaDung(SCTDThangTruoc, SCTDThangNay);
            int ThanhTien = TinhTien(SCTDThangTruoc, SCTDThangNay);

            Console.WriteLine("ho va ten: {0}", HoTen);
            Console.WriteLine("dia chi: {0}", DiaChi);
            Console.WriteLine("so cong to dien thang truoc: {0}", SCTDThangTruoc);
            Console.WriteLine("so cong to dien thang nay: {0}", SCTDThangNay);
            Console.WriteLine("So cong to dien tieu thu: {0}", SCTDTienThu);
            Console.WriteLine("Tinh tien: {0}", ThanhTien);
        }

        public virtual void KiemTraSCTDThangTruoc() {
            bool KiemTra = false;
            do
            {
                try
                {
                    do
                    {
                        Console.Write("nhap so cong to dien thang truoc: ");
                        this.SCTDThangTruoc = int.Parse(Console.ReadLine());
                        if (SCTDThangTruoc < 0)
                        {
                            Console.WriteLine("Du lieu phai lon hon 0");
                            KiemTra = true;
                        }
                        else KiemTra = false;
                    } while (KiemTra);

                }
                catch{
                    KiemTra = true;
                    Console.WriteLine("Du lieu phai la so");
                }
            } while (KiemTra);
        }

        public virtual void KiemTraSCTDThangNay()
        {
            bool KiemTra = false;
            do
            {
                try
                {
                    do
                    {
                        Console.Write("nhap so cong to dien thang nay: ");
                        this.SCTDThangNay = int.Parse(Console.ReadLine());
                        if (SCTDThangNay < 0)
                        {
                            Console.WriteLine("Du lieu phai lon hon 0");
                            KiemTra = true;
                        }
                        else KiemTra = false;
                    } while (KiemTra);

                }
                catch
                {
                    KiemTra = true;
                    Console.WriteLine("Du lieu phai la so");
                }
            } while (KiemTra);
        }

        //so cong to dien thang nay
        public int LaySoCongToDienThangNay() {
            return SCTDThangNay;
        }
        public void NhapSoCongToDienThangNay(int _SCTDThangNay)
        {
            this.SCTDThangNay = _SCTDThangNay;
        }

        //so cong to dien thang truoc
        public int LaySoCongToDienThangTruoc() {
            return SCTDThangTruoc;
        }
        public void NhapSoCongToDienThangTruoc(int _SCTDThangTruoc)
        {
            this.SCTDThangTruoc = _SCTDThangTruoc;
        }

        //hoten
        public string LayHoTen()
        {
            return HoTen;
        }
        public void NhapHoTen(string _HoTen)
        {
            this.HoTen = _HoTen;
        }

        //dia chi
        public string LayDiaChi()
        {
            return DiaChi;
        }
        public void NhapDiaChi(string _DiaChi)
        {
            this.DiaChi = _DiaChi;
        }
    }
}
