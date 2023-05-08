using ClientDetails.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientDetails.Repositorio.Config
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.TipoTarefa).IsRequired().HasMaxLength(50);
            builder.Property(u => u.DataExecucao).IsRequired();
            builder.Property(u => u.Colaborador).IsRequired().HasMaxLength(50);
        }
     }
}
