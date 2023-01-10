using GasBrasilDashboardBiblioteca.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasBrasilDashboardBiblioteca.Mappings
{
    public class TB_FATURAMENTO_MAP : IEntityTypeConfiguration<TB_FATURAMENTO>
    {
        public void Configure(EntityTypeBuilder<TB_FATURAMENTO> builder)
        {
            // Tabela
            builder.ToTable("TB_FATURAMENTO");

            // Chave Primária
            builder.HasKey(x => x.ID_CLIENTE);

            // Identity
            builder.Property(x => x.ID_CLIENTE)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.DATA_REFERENCIA)
                .IsRequired()
                .HasColumnName("DATA_REFERENCIA")
                .HasColumnType("DATETIME")
                .HasMaxLength(80);

            builder.Property(x => x.CONSUMO_M3)
                .IsRequired()
                .HasColumnName("CONSUMO_M3")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.DATA_ARQUIVO)
                .IsRequired()
                .HasColumnName("DATA_ARQUIVO")
                .HasColumnType("DATETIME")
                .HasMaxLength(80);

            // Índices
            builder
                .HasIndex(x => x.ID_CLIENTE, "ID_CLIENTE")
                .IsUnique();
        }
    }
}
