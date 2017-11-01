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

            Property(l => l.Sinopse)
                .HasMaxLength(500);

            Property(l => l.SituacaoConserva)
                .IsRequired()
                .HasMaxLength(200);

            HasRequired(l => l.Categoria)
                .WithMany()
                .HasForeignKey(l => l.CategoriaId);

            HasRequired(l => l.Autor)
                .WithMany()
                .HasForeignKey(l => l.AutorId);

            HasRequired(l => l.Editora)
                .WithMany()
                .HasForeignKey(l => l.EditoraId);
        }
    }
}
