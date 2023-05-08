using ClientDetails.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientDetails.Repositorio.Config
{
    public class ContatoConfiguration : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Cargo).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Telefone).IsRequired().HasMaxLength(50);
            
        }
    }
}
