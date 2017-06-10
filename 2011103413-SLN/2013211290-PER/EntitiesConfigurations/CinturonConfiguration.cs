using _2013211290_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013211290_PER.EntitiesConfigurations
{
    public class CinturonConfiguration:EntityTypeConfiguration<Cinturon>
    {
        public CinturonConfiguration()
        {
            ToTable("Cinturones");

            HasKey(c => c.CinturonId);
            //Propiedades
            Property(c => c.NumSerieCinturon)
                .IsRequired()
                .HasMaxLength(10);
            Property(c => c.CinturonId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
