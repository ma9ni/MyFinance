using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domaine;

namespace Service
{
    public class ServiceCategory:IserviceCategory
    {
        MyFinanceContext ctx = new MyFinanceContext();

        public void addCategory(Category category)
        {
            ctx.Categories.Add(category);
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }
    }
}
