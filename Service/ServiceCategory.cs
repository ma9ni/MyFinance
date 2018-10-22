using Domaine;
using Data.Infrastructure;
using Infrastructure;
using MyFinance.Data.Infrastructure;
using ServicePattern;

namespace Service
{
    public class ServiceCategory: Service<Category>, IserviceCategory
    {
        //    MyFinanceContext ctx = new MyFinanceContext();

        static IDatabaseFactory dbf = new DatabaseFactory();
        static IUnitOfWork uow = new UnitOfWork(dbf);

        //  RepositoryBase<Category> repo = new RepositoryBase<Category>(dbf);

        public ServiceCategory(): base(uow)
        {

        }


        public void addCategory(Category NewElem) 
        {

            //  dbf.DataContext.Categories.Add(NewElem);
            //uow.getRepository<Category>().Add(NewElem);

        }
        public void Commit()
        {

            uow.Commit();
        }
    }
}

