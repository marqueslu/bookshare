using BookShare.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BookShare.Infra.Data.EntityConfig
{
    class LivroConfiguration : EntityTypeConfiguration<Livro>
    {

        public LivroConfiguration()
        {
            HasKey(l => l.LivroId);

            Property(l => l.Titulo)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(l => l.Categoria)
                .WithMany()
                .HasForeignKey(l => l.CategoriaId);

            HasRequired(l => l.Autor)
                .WithMany()
                .HasForeignKey(l => l.AutorId);
        }
    }
}
