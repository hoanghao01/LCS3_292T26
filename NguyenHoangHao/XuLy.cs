using System;
using System.Collections.Generic;

namespace NguyenHoangHao
{
    public class XuLy
    {
        //dsvcl = danh sach viec can lam
        public void LuaChon1(DanhSachViecCanLam dsvcl)
        {
            Console.WriteLine("Them viec can lam: ");
            ViecCanLam viecCanLam = new ViecCanLam();
            viecCanLam.NhapThongTinViecCanLam();
            dsvcl.ThemViecLam(viecCanLam);
            Console.WriteLine("==> Them thanh cong! <==");
        }
        public void LuaChon2(DanhSachViecCanLam dsvcl)
        {   
            Console.WriteLine("Xoa viec can lam: ");
            dsvcl.HienThiDanhSachViecLam();
            Console.WriteLine("Nhap id viec can lam ban muon xoa: ");
            string id = Console.ReadLine();
            bool checkExist = dsvcl.KiemTraViecCanLamCoTonTaiTheoId(id);
            
            if (checkExist)
            {
                            
                string key;
                do
                {
                    Console.WriteLine("Ban co chac chan muon xoa khong? (Y/N)");
                    key = Console.ReadLine();
                                
                } while (key != "Y" && key != "y" && key != "N" && key != "n");
                            
                if (key == "N" || key == "n")
                {
                    Console.WriteLine("Huy xoa viec can lam.");
                    return;
                }
                dsvcl.XoaViecCanLam(id);
                Console.WriteLine("==> Xoa thanh cong. <==");
            }
            else
            {
                Console.WriteLine("Viec can lam khong ton tai.");
            }
        }
        public void LuaChon3(DanhSachViecCanLam dsvcl)
        {
            Console.WriteLine("Cap nhat viec can lam: ");
            dsvcl.HienThiDanhSachViecLam();
            Console.WriteLine("Nhap ten viec can lam ban muon cap nhat: ");
            string tenViecCanLam = Console.ReadLine();
            var list = dsvcl.LayDanhSachViecLam(tenViecCanLam);

            if (list.Count == 1)
            {
                var toDoUpdate = list[0];
                if (toDoUpdate.TrangThai == "Hoan thanh")
                {
                    Console.WriteLine("Viec can lam da hoan thanh. Khong the cap nhat.");
                    return;
                }
                toDoUpdate.TrangThai = "Hoan thanh";
                dsvcl.CapNhatViecCanLam(toDoUpdate, tenViecCanLam);
                Console.WriteLine("==> Cap nhat thanh cong. <==");
            }
            else if (list.Count != 0 && list.Count > 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Nhap id viec can lam ban muon cap nhat: ");
                string idViecCanLam = Console.ReadLine();
                bool checkExistById = dsvcl.KiemTraViecCanLamCoTonTaiTheoId(idViecCanLam);
                
                if (checkExistById)
                {
                    var toDoUpdate = list.Find(item => item.Id == idViecCanLam);
                    if (toDoUpdate.TrangThai == "Hoan thanh")
                    {
                        Console.WriteLine("Viec can lam da hoan thanh. Khong the cap nhat.");
                        return;
                    }
                    toDoUpdate.TrangThai = "Hoan thanh";
                    dsvcl.CapNhatViecCanLam(toDoUpdate, tenViecCanLam);
                    Console.WriteLine("==> Cap nhat thanh cong. <==");
                }
                else
                {
                    Console.WriteLine("Viec can lam khong ton tai.");
                }
                
            }
            else
            {
                Console.WriteLine("Viec can lam khong ton tai.");
            }
        }
        public void LuaChon4(DanhSachViecCanLam dsvcl)
        {
            Console.WriteLine("Tim kiem viec can lam: ");
            dsvcl.HienThiDanhSachViecLam();
            Console.WriteLine("Ban muon tim kiem theo ten hay do uu tien (1: Ten, 2: Do uu tien): ");
            int key = int.Parse(Console.ReadLine());
            if (key == 1)
            {
                Console.WriteLine("Nhap ten viec can lam ban muon tim kiem: ");
                string tenViecCanLamTimKiem = Console.ReadLine();
                dsvcl.TimKiemViecCanLamTheoTen(tenViecCanLamTimKiem);
            }
            else if (key == 2)
            {
                Console.WriteLine("Nhap do uu tien ban muon tim kiem: ");
                int doUuTienTimKiem = int.Parse(Console.ReadLine());
                dsvcl.TimKiemViecCanLamTheoDoUuTien(doUuTienTimKiem);
            }
            
        }
        public void LuaChon5(DanhSachViecCanLam dsvcl)
        {
            Console.WriteLine("Sap xep viec can lam theo do uu tien giam dan: ");
            dsvcl.SapXepViecCanLamTheoDoUuTien();
        }
        public void LuaChon6(DanhSachViecCanLam dsvcl)
        {
            Console.WriteLine("Hien thi toan bo danh sach viec can lam: ");
            dsvcl.HienThiDanhSachViecLam();
        }
        
    }
}