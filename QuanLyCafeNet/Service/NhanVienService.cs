using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class NhanVienService
    {
        private readonly DBContext dbContext;

        public NhanVienService()
        {
            dbContext = new DBContext();
        }

        public List<NhanVien> GetNhanViens()
        {
            return dbContext.NhanViens.ToList();
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            dbContext.NhanViens.Add(nhanVien);
            dbContext.SaveChanges();
        }

        public void XoaNhanVien(NhanVien nhanVien)
        {
            dbContext.NhanViens.Remove(nhanVien);
            dbContext.SaveChanges();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }
    }
}
