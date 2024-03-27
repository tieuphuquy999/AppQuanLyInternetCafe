using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class LichLamService
    {
        private readonly DBContext dbContext;

        public LichLamService()
        {
            dbContext = new DBContext();
        }

        public List<LichLam> GetLichLams()
        {
            return dbContext.LichLams.ToList();
        }

        public void XoaLichLam(LichLam lichLam)
        {
            dbContext.LichLams.Remove(lichLam);
            dbContext.SaveChanges();
        }

        public void ThemLichLam(LichLam lichLam)
        {
            dbContext.LichLams.Add(lichLam);
            dbContext.SaveChanges();
        }
    }
}
