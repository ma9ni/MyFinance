using Domaine;
using System.Collections.Generic;
using System.Data.Entity;

namespace Data
{
    public class MyFinanceContext:DbContext
    {
        public MyFinanceContext():base("name=Alias")
        {
            Database.SetInitializer(new MyFinanceCtxInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
    //DropCreateDatabaseIfModelChanges
    //DropCreateDatabaseAlways

    public class MyFinanceCtxInitializer: DropCreateDatabaseAlways<MyFinanceContext>
    {
        protected override void Seed(MyFinanceContext context)
        {
            List<Category> cat = new List<Category> {};
            cat.Add(new Category { Name = "Legende" });
            cat.Add(new Category { Name = "Vetement" });
            context.Categories.AddRange(cat);
            context.SaveChanges();
        }
    }
}
