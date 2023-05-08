using ClientDetails.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientDetails.Repositorio.Config
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Endereco).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Telefone).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Segmento).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Cnpj).IsRequired().HasMaxLength(50);
            builder.Property(u => u.CodSistema).IsRequired().HasMaxLength(50);
            builder.Property(u => u.CodExterno).IsRequired().HasMaxLength(50);
        }
    }
}
