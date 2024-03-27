using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class MayService
    {
        private readonly DBContext dbContext;

        public MayService()
        {
            dbContext = new DBContext();
        }

        public List<May> GetMays()
        {
            return dbContext.Mays.ToList();
        }
    }
}
