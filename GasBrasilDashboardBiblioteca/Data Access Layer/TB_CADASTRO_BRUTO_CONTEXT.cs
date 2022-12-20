
using GasBrasilDashboardBiblioteca.Mappings;
using GasBrasilDashboardBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GasBrasilDashboardBiblioteca.Data_Access_Layer
{
    public class TB_CADASTRO_BRUTO_CONTEXT : DbContext //classe para fazer a manipulação entre os modelos de dados e o banco
    {
        private readonly AppSettings _settings;
        public DbSet<TB_CADASTRO_BRUTO> CadastrosBrutos { get; set; }

        public TB_CADASTRO_BRUTO_CONTEXT(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer(_settings.ConnectionString2);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TB_CADASTRO_BRUTO_MAP());
        }
    }
}
