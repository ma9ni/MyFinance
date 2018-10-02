using Data;
using Domaine;
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
       //     Category c1 = new Category { Name="Medicament"};
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

        }
    }
}
