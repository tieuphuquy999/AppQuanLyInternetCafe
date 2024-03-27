using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class KhachHangService
    {
        private readonly DBContext dbContext;

        public KhachHangService()
        {
            dbContext = new DBContext();
        }

        public List<KhachHang> GetKhachHangs()
        {
            return dbContext.KhachHangs.ToList();
        }

        public void ThemKhach(KhachHang khach)
        {
            dbContext.KhachHangs.Add(khach);
            dbContext.SaveChanges();
        }

        public void XoaKhach(KhachHang khach)
        {
            dbContext.KhachHangs.Remove(khach);
            //dbContext.SaveChanges();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }
    }
}
