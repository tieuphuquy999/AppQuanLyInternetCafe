using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class MonService
    {
        private readonly DBContext dbContext;

        public MonService()
        {
            dbContext = new DBContext();
        }

        public List<Mon> GetMonTheoDanhMuc(String maDanhMuc)
        {
            return dbContext.Mons.Where(x => x.MaDanhMuc == maDanhMuc).ToList();
        }

        public void ThemMon(Mon mon)
        {
            dbContext.Mons.Add(mon);
            dbContext.SaveChanges();
        }

        public void XoaMon(Mon mon)
        {
            dbContext.Mons.Remove(mon);
            dbContext.SaveChanges();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }

    }
}
