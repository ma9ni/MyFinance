using Domaine;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MyConfigurations
{
    public class AdressConfigurations: EntityTypeConfiguration<Adress>
    {
        public AdressConfigurations()
        {
            Property(c => c.City).IsRequired();
            Property(c => c.StreetAddress).HasMaxLength(50);
        }
    }
}
