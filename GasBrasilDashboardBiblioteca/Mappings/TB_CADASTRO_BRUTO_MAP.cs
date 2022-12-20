using GasBrasilDashboardBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GasBrasilDashboardBiblioteca.Mappings
{
    public class TB_CADASTRO_BRUTO_MAP : IEntityTypeConfiguration<TB_CADASTRO_BRUTO>
    {
        public void Configure(EntityTypeBuilder<TB_CADASTRO_BRUTO> builder)
        {
            // Tabela
            builder.ToTable("TB_CADASTRO_BRUTO");

            // Chave Primária
            builder.HasKey(x => x.ID_CLIENTE);

            // Identity
            builder.Property(x => x.ID_CLIENTE)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.CLASSE_CONSUMO)
                .IsRequired()
                .HasColumnName("CLASSE_CONSUMO")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.MUNICIPIO)
                .IsRequired()
                .HasColumnName("MUNICIPIO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            // Índices
            builder
                .HasIndex(x => x.ID_CLIENTE, "ID_CLIENTE")
                .IsUnique();
        }
    }
}
