using Domaine;
using Data;
using ServicePattern;
using MyFinance.Data.Infrastructure;
using Data.Infrastructure;
using Infrastructure;

namespace Service
{
    public class ServiceProduct : Service<Product>, IserviceProduct
    {
        MyFinanceContext ctx = new MyFinanceContext();

        static IDatabaseFactory dbf = new DatabaseFactory();
        static IUnitOfWork uow = new UnitOfWork(dbf);

        public ServiceProduct() : base(uow)
        {

        }

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
