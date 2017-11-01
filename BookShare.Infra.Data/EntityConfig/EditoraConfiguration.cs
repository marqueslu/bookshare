using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Infra.Data.EntityConfig
{
    public class EditoraConfiguration : EntityTypeConfiguration<Editora>
    {

        public EditoraConfiguration()
        {
            HasKey(e => e.EditoraId);

            Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(150);

        }
       
    }
}
