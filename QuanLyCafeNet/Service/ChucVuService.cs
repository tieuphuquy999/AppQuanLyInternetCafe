using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{    
    internal class ChucVuService
    {
        private readonly DBContext dbContext;
        public ChucVuService()
        {
            dbContext = new DBContext();
        }

        public List<ChucVu> GetChucVus()
        {
            return dbContext.ChucVus.ToList();
        }

        public void ThemChucVu(ChucVu chucVu)
        {
            dbContext.ChucVus.Add(chucVu);
            dbContext.SaveChanges();
        }

        public void XoaChucVu(ChucVu chucVu)
        {
            dbContext.ChucVus.Remove(chucVu);
            dbContext.SaveChanges();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }
    }


}
