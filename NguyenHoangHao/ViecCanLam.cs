using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace NguyenHoangHao
{
    public class ViecCanLam 

    {
    private string _tenViecCanLam;
    private int _doUuTien;
    private string _moTa;
    private string _trangThai;
    private string _id;

    public ViecCanLam()
    {
        _tenViecCanLam = "";
        _doUuTien = 0;
        _moTa = "";
        _trangThai = "";
        _id = "";
    }

    public ViecCanLam(string tenViecCanLam, int doUuTien, string moTa, string trangThai)
    {
        _tenViecCanLam = tenViecCanLam;
        _doUuTien = doUuTien;
        _moTa = moTa;
        _trangThai = trangThai;
    }

    public string TenViecCanLam
    {
        get => _tenViecCanLam;
        set => _tenViecCanLam = value;
    }

    public int DoUuTien
    {
        get => _doUuTien;
        set
        {
            if (value >= 1 && value <= 5)
            {
                _doUuTien = value;
            }
            else
            {
                Console.WriteLine("Do uu tien phai nam trong khoang tu 1 den 5.");
            }
        }
    }

    public string MoTa
    {
        get => _moTa;
        set => _moTa = value;
    }

    public string TrangThai
    {
        get => _trangThai;
        set => _trangThai = value;
    }

    public string Id
    {
        get => _id;
        set => _id = value;
    }

    public void NhapThongTinViecCanLam()
    {
        Console.WriteLine("Nhap ten viec can lam: ");
        _tenViecCanLam = Console.ReadLine();
        do
        {
            Console.WriteLine("Nhap do uu tien: ");
            try
            {
                _doUuTien = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Sai dinh dang.");
            }
            
            if (_doUuTien < 1 || _doUuTien > 5)
            {
                Console.WriteLine("Do uu tien nam trong tu 1 den 5. Vui long nhap lai!");
            }
        } while (_doUuTien < 1 || _doUuTien > 5);

        Console.WriteLine("Nhap mo ta: ");
        _moTa = Console.ReadLine();
        
        _trangThai = "Chua hoan thanh";
    }

    public override string ToString()
    {
        return
            $"ID: {_id} | Ten viec can lam: {_tenViecCanLam} | Do uu tien: {_doUuTien} | Mo ta: {_moTa} | Trang thai: {_trangThai}";
    }
    }
}