namespace Data.Migrations
{
    using Domaine;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.MyFinanceContext>
    {
        //Console du Gestionnaire de package 

        //generer a l'aide de Commande  Enable-Migrations

        //Pour Ajouter Migration : Add-Migration nom-migration

            //exemple Add-Migration Adress
            // Update DataBase   update DataBase selon la derniére Migration
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Data.MyFinanceContext";
        }
        
        protected override void Seed(Data.MyFinanceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate<Category>(c =>c.Name,
                                                              new Category { Name="Matériels"}
                                                     );
        }
    }
}
