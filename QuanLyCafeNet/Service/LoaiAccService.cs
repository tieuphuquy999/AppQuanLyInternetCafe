using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class LoaiAccService
    {
        private readonly DBContext dbContext;

        public LoaiAccService()
        {
            dbContext = new DBContext();
        }

        public List<LoaiACC> GetLoaiACCs()
        {
            return dbContext.LoaiACCs.ToList();
        }

        public void ThemLoaiAcc(LoaiACC d)
        {
            dbContext.LoaiACCs.Add(d);
            dbContext.SaveChanges();
        }
        public void XoaLoaiAcc(LoaiACC d)
        {
            dbContext.LoaiACCs.Remove(d);
            dbContext.SaveChanges();
        }
        public void saveChange()
        {
            dbContext.SaveChanges();
        }
    }
}
