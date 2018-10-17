using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domaine;
using Data;

namespace Service
{
    public class ServiceProduct : IserviceProduct
    {
        MyFinanceContext ctx = new MyFinanceContext();

        public void AddProduct(Product product)
        {
            
            ctx.Products.Add(product);
        }


        public void Commit()
        {
            ctx.SaveChanges();
        }


    }
}
