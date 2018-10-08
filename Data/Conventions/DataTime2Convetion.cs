using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Conventions
{
    public class DataTime2Convetion :Convention
    {
        //DateTime To DateTime2
        public DataTime2Convetion()
        {
            this.Properties<DateTime>()
                .Configure(d => d.HasColumnType("datetime2"));
        }
    }
}
