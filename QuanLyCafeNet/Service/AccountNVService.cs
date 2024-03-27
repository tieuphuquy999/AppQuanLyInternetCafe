using QuanLyCafeNet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafeNet.Service
{
    internal class AccountNVService
    {
        private readonly DBContext dbContext;

        public AccountNVService()
        {
            dbContext = new DBContext();
        }

        public List<AccountNV> GetAccountNVs()
        {
            return dbContext.AccountNVs.ToList();
        }

        public void AddAcc(AccountNV accountNV)
        {
            dbContext.AccountNVs.Add(accountNV);
            dbContext.SaveChanges();
        }

        public void RemoveAcc(AccountNV accountNV)
        {
            dbContext.AccountNVs.Remove(accountNV);
            dbContext.SaveChanges();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }
    }
}
