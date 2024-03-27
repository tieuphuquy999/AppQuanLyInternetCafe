using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class CaLamService
    {
        DBContext dbContext;
        public CaLamService()
        {
            dbContext = new DBContext();
        }

        public List<CaLam> GetCaLams()
        {
            return dbContext.CaLams.ToList();
        }

    }
}
