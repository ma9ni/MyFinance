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
        }
    }
}
