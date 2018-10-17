using Data.Conventions;
using Data.MyConfigurations;
using Domaine;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext() : base("name=Alias")
        {
            Database.SetInitializer(new MyFinanceCtxInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            // modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Add(new KeyConvention());
            modelBuilder.Conventions.Add(new DataTime2Convetion());


            //Instancier les fluent API
            modelBuilder.Configurations.Add(new AdressConfigurations());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfigurations());

        }
    }
    //DropCreateDatabaseIfModelChanges
    //DropCreateDatabaseAlways

    public class MyFinanceCtxInitializer : DropCreateDatabaseAlways<MyFinanceContext>
    {
        protected override void Seed(MyFinanceContext context)
        {
            List<Category> cat = new List<Category> { };
            cat.Add(new Category { Name = "Legende" });
            cat.Add(new Category { Name = "Vetement" });
            context.Categories.AddRange(cat);
            context.SaveChanges();
        }
    }
}
