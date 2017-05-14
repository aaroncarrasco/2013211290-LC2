using _2013211290_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013211290_PER.EntityTypeConfigurations
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {

        public AsientoConfiguration()
        {
            Property(v => v.AsientoId)
                .IsRequired();


            HasRequired(v => v.Cinturon)
                .WithRequiredPrincipal(c => c.Asiento)
                ;

        }

    }

    
}
