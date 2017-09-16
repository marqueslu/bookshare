using BookShare.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BookShare.Infra.Data.EntityConfig
{
    class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        public AutorConfiguration()
        {
            HasKey(a => a.AutorId);

            Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }        
    }
}
