using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.StringComparison;

namespace NguyenHoangHao
{
    public class DanhSachViecCanLam
    {
        public string Id { get; set; }
        private List<ViecCanLam> _danhSachViecCanLam;

        public DanhSachViecCanLam()
        {
            _danhSachViecCanLam = new List<ViecCanLam>();   // Khoi tao danh sach viec can lam
        }
        public DanhSachViecCanLam(List<ViecCanLam> danhSachViecCanLam)
        {
            _danhSachViecCanLam = danhSachViecCanLam; 
        }
        
        public void ThemViecLam(ViecCanLam viecCanLam)
        {
            _danhSachViecCanLam.Add(viecCanLam);    // Them viec can lam vao cuoi danh sach
            int id = _danhSachViecCanLam.Count;
            viecCanLam.Id = id.ToString();
        }

        public void HienThiDanhSachViecLam()
        {
            int i = 0;
            foreach (ViecCanLam item in _danhSachViecCanLam)
            {
                Console.WriteLine(item);
                i++;
            }
        }

        public bool KiemTraDanhSachRong()
        {
            if (_danhSachViecCanLam.Count == 0)
            {
                return true;
            }
            return false;
        }
        
        public bool KiemTraViecCanLamCoTonTaiTheoId(string id)
        {
            return _danhSachViecCanLam.Exists(item => item.Id == id);
        }
        
        public bool KiemTraViecCanLamCoTonTaiTheoTen(string tenViecCanLam)
        {
            return _danhSachViecCanLam.Exists(item => item.TenViecCanLam == tenViecCanLam);
        }
        
        public void XoaViecCanLam(string id)
        {
            foreach (var item in _danhSachViecCanLam)
            {
                if (item.Id == id)
                {
                    _danhSachViecCanLam.Remove(item);
                    break;
                }
            }
        }
        
        public List<ViecCanLam> LayDanhSachViecLam(string tenViecCanLam)
        {
            var newList = new List<ViecCanLam>();
            foreach (var item in _danhSachViecCanLam)
            {
                if (item.TenViecCanLam.Contains(tenViecCanLam.Trim()))
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
        
        public void CapNhatViecCanLam(ViecCanLam viecCanLam, string tenViecCanLam)
        {
            var list = new List<ViecCanLam>();
            foreach (var item in _danhSachViecCanLam)
            {
                if (item.TenViecCanLam == tenViecCanLam)
                {
                    item.TrangThai = viecCanLam.TrangThai;
                    break;
                }
            }
        }

        public void TimKiemViecCanLamTheoTen(string tukhoa = "")
        {
            int count = 0;
            foreach (var item in _danhSachViecCanLam)
            {
                if (item.TenViecCanLam.Contains(tukhoa.Trim())) 
                {
                    Console.WriteLine(item);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Khong tim thay viec can lam!");
            }
        }
        
        public void TimKiemViecCanLamTheoDoUuTien(int doUuTien)
        {
            int count = 0;
            foreach (var item in _danhSachViecCanLam)
            {
                if (item.DoUuTien == doUuTien) 
                {
                    Console.WriteLine(item);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Khong tim thay viec can lam!");
            }
        }
        
        //Hiển thị danh sách các việc cần làm theo độ ưu tiên giảm dần.
        public void SapXepViecCanLamTheoDoUuTien()
        {
            var list = new List<ViecCanLam>();
            list = _danhSachViecCanLam.OrderByDescending(item => item.DoUuTien).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}