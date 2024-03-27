using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.View_Model
{
    public class MonDat
    {
        public string maMon { get; set; }
        public string tenMon { get; set; }
        public double donGia { get; set; }
        public string dvt { get; set; }
        public int soLuong { get; set; }
        public double thanhTien { get { return donGia * soLuong; } }

        public MonDat()
        {
            maMon = null;
            tenMon = null;
            donGia = 0;
            soLuong = 0;
        }
        public MonDat(Mon mon)
        {
            maMon = mon.MaMon;
            tenMon = mon.TenMon;
            donGia = mon.DonGia;
            dvt = mon.DVT;
        }
    }
}
