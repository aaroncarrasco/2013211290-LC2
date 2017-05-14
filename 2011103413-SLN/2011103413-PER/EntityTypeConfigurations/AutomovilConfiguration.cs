using _2013211290_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013211290_PER.EntityTypeConfigurations
{
    public class AutomovilConfiguration : EntityTypeConfiguration<Automovil>
    {

        public AutomovilConfiguration()
        {
            Property(v => v.AutomovilId)
                .IsRequired();

        }

    }
}
