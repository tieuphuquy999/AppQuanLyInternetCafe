using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class ThongKeService
    {
        private readonly DBContext dbContext;

        public ThongKeService()
        {
            dbContext = new DBContext();
        }

        public List<ThongKe> GetThongKes()
        {
            return dbContext.ThongKes.ToList();
        }
        public void AddThongKe(ThongKe thongKe)
        {
            dbContext.ThongKes.Add(thongKe);
            dbContext.SaveChanges();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }
    }
}
