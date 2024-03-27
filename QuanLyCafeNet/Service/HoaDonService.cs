using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class HoaDonService
    {
        private readonly DBContext dbContext;

        public HoaDonService()
        {
            dbContext = new DBContext();
        }

        public List<HoaDon> GetHoaDons()
        {
            return dbContext.HoaDons.ToList();
        }
        public void AddHoaDon(HoaDon hoaDon)
        {
            dbContext.HoaDons.Add(hoaDon);
            dbContext.SaveChanges();
        }
    }
}
