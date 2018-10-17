using Domaine;
using System.Data.Entity.ModelConfiguration;

namespace Data.MyConfigurations
{
    public class ProductConfigurations: EntityTypeConfiguration<Product>
    {
        public ProductConfigurations()
        {
            //Configuration de l'association * à *
            //changer le nom de table de l'association  entre Product et Provider
            HasMany(a => a.Providers).WithMany(p => p.Products).
                Map(t => 
                        {
                            //leftKey =>table Product
                            //RightKey =>table Providers
                            t.ToTable("Providings");
                            t.MapLeftKey("ProductKey");
                            t.MapRightKey("ProviderKey");
                        }
                );

            //Configuration de l'heritage Table per Herarchie
                                //Nom De Champ          //Valeur de Champs
            Map<Bilogical>(b => b.Requires("IsBilogical").HasValue(1));
            Map<Chemical>(b => b.Requires("IsBilogical").HasValue(0));


            //Configuration de l'association * à 1

            HasRequired(p => p.Category).WithMany(c => c.Products).
                HasForeignKey(p => p.CategoryId).WillCascadeOnDelete(false);
        }
    }
}
