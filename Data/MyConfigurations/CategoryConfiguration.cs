using Domaine;
using System.Data.Entity.ModelConfiguration;

namespace Data.MyConfigurations
{
    public class CategoryConfiguration: EntityTypeConfiguration<Category>
    {
        //ctor +2*tab => constructeur par default
        public CategoryConfiguration()
        {
            //Changer le nom de table
            ToTable("MyCategories");

            HasKey(a => a.CategoryId);
            //la propretie Name est obligatoire et avoire taille 50 
            Property(a => a.Name).HasMaxLength(50).IsRequired();
        }
    }
}
