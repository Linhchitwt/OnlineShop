using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;
namespace Models
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel() {
            context = new OnlineShopDbContext();
        }
        public bool Login(string userName, string passwork)
        {
            var sqlParams = new SqlParameter[]
            {
                new SqlParameter("@US", userName),
                new SqlParameter("@PA", passwork)
            };
            var res = context.Database.SqlQuery<bool>("test_account @US,@PA", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
