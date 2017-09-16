using BookShare.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BookShare.Infra.Data.EntityConfig
{
    class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            HasKey(c => c.CategoriaId);
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            
        }
    }
}
