using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangHao
{
    internal class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("=================== QUAN LY VIEC CAN LAM ===================");
            Console.WriteLine("= 1. Them viec can lam:                                    =");
            Console.WriteLine("= 2. Xoa viec can lam:                                     =");
            Console.WriteLine("= 3. Cap nhat viec can lam:                                =");
            Console.WriteLine("= 4. Tim kiem viec can lam:                                =");
            Console.WriteLine("= 5. Sap xep viec can lam theo do uu tien giam dan:        =");
            Console.WriteLine("= 6. Hien thi danh sach viec can lam:                      =");
            Console.WriteLine("= 7. Thoat chuong trinh.                                   =");
            Console.WriteLine("============================================================");
        }

        public static bool CheckDanhSachRong(DanhSachViecCanLam danhSachViecCanLam)
        {
            bool checkDanhSachRong = danhSachViecCanLam.KiemTraDanhSachRong();
            if (checkDanhSachRong)
            {
                Console.WriteLine("Danh sach rong.");
                return true;
            }
            return false;
        }
        
        public static void Main(string[] args)
        {
            DanhSachViecCanLam danhSachViecCanLam = new DanhSachViecCanLam();
            XuLy xuLy = new XuLy();
            string selection;
            do
            {
                ShowMenu();
                Console.Write("Nhap lua chon cua ban: ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.Clear();
                        xuLy.LuaChon1(danhSachViecCanLam);
                        break;
                    case "2":
                        Console.Clear();
                        if (CheckDanhSachRong(danhSachViecCanLam)) break;
                        xuLy.LuaChon2(danhSachViecCanLam);
                        break;

                    case "3":
                        Console.Clear();
                        if (CheckDanhSachRong(danhSachViecCanLam)) break;
                        xuLy.LuaChon3(danhSachViecCanLam);
                        break;
                    case "4":
                        Console.Clear();
                        if(CheckDanhSachRong(danhSachViecCanLam)) break;
                        xuLy.LuaChon4(danhSachViecCanLam);
                        break;
                    case "5":
                        Console.Clear();
                        if (CheckDanhSachRong(danhSachViecCanLam)) break;
                        xuLy.LuaChon5(danhSachViecCanLam);
                        break;
                    case "6":
                        Console.Clear();
                        if (CheckDanhSachRong(danhSachViecCanLam)) break;
                        xuLy.LuaChon6(danhSachViecCanLam);
                        break;
                    case "7":
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            } while (selection != "7");
        }
    }
}