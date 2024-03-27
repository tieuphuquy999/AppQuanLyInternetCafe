using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class AccountKHService
    {
        private readonly DBContext dbContext;

        public AccountKHService()
        {
            dbContext = new DBContext();
        }

        public void ThemAcc(AccountKH accountKH)
        {
            dbContext.AccountKHs.Add(accountKH);
            dbContext.SaveChanges();
        }

        public void XoaAcc(AccountKH accountKH)
        {
            dbContext.AccountKHs.Remove(accountKH);
            dbContext.SaveChanges();
        }

        public List<AccountKH> GetAccountKHs()
        {
            return dbContext.AccountKHs.ToList();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }
    }
}
