using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Models
{
    public class CategoryModel
    {
        private OnlineShopDbContext context = null;
        public CategoryModel()
        {
            context = new OnlineShopDbContext();
        }
        public List<Category> ListAll()
        {
            var list = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();
            return list;
        }
        public int Create(int? ID,string name, string alias, int? parentID, int? order, bool? status)
        {
            object[] parameters =
            {
                new SqlParameter ("@ID", ID),
                new SqlParameter("@Name", name),
                new SqlParameter("@Alias", alias),
                new SqlParameter("@ParentID", parentID),
                new SqlParameter("@order", order),
                new SqlParameter("@Status", status)
            };
            int res = context.Database.ExecuteSqlCommand("Sp_Category_Insert @ID, @Name, @Alias, @ParentID, @Order, @Status", parameters);
            return res;
        }
    }
}
