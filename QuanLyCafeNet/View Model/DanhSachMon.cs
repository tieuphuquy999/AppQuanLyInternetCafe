using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.View_Model
{
    public class DanhSachMon
    {
        public String IDMay { set; get; }
        public List<MonDat> danhSachMon;
        public DanhSachMon()
        {
            danhSachMon = new List<MonDat>();
        }

        public void ThemMon(MonDat mon)
        {
            MonDat temp = danhSachMon.Where(m => m.maMon == mon.maMon).FirstOrDefault();
            if (temp == null)
                danhSachMon.Add(mon);
            else
                temp.soLuong += mon.soLuong;
        }
        public void XoaMon(MonDat mon)
        {
            danhSachMon.Remove(mon);
        }
        public List<MonDat> GetDanhSachMonDat()
        {
            return danhSachMon;
        }
    }
}
