using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class DanhMucService
    {
        private readonly DBContext dbContext;

        public DanhMucService()
        {
            dbContext = new DBContext();
        }

        public List<DanhMuc> GetDanhMucs()
        {
            return dbContext.DanhMucs.ToList();
        }

        public void ThemDanhMuc(DanhMuc d)
        {
            dbContext.DanhMucs.Add(d);
            dbContext.SaveChanges();
        }
        public void XoaDanhMuc(DanhMuc d)
        {
            dbContext.DanhMucs.Remove(d);
            dbContext.SaveChanges();
        }
        public void saveChange()
        {
            dbContext.SaveChanges();
        }

    }
}
