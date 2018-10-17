using Data;
using Domaine;
using Service;
using System;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFinanceContext ctx = new MyFinanceContext();
            //Product p1 = new Product { Name = "Tomate",Description="Rouge",Quantity=2};
            //ctx.Products.Add(p1);
            Category c1 = new Category { Name="Ahmeed"};
          //  ctx.Categories.Add(c1);
          //  ctx.SaveChanges();
            Console.WriteLine("Base crée");
            Console.ReadKey();

            //Console du Gestionnaire de package 

            //generer a l'aide de Commande  Enable-Migrations

            //Pour Ajouter Migration : Add-Migration nom-migration

            //exemple Add-Migration Adress
            // Update DataBase   update DataBase selon la derniére Migration

            //Update DataBase TargetMigration


            ServiceCategory sc = new ServiceCategory();
            sc.addCategory(c1);
            sc.Commit();
            Console.WriteLine("Category Ajouter");
            Console.ReadKey();

            ServiceProduct sp = new ServiceProduct();
            Product p1 = new Product();
            p1.Name = "Delice";
            p1.Quantity=1;
            p1.price = 1250;
            p1.Category = c1;

            sp.AddProduct(p1);
            sc.Commit();
            Console.WriteLine("Produit Ajouter");
            Console.ReadKey();

            

        }
    }
}
