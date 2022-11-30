using GasBrasilDashboardBiblioteca.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GasBrasilDashboardBiblioteca.Data_Access_Layer
{
    public class TB_CADASTRO_BRUTO_CONTEXT : DbContext //classe para fazer a manipulação entre os modelos de dados e o banco
    {
        public TB_CADASTRO_BRUTO_CONTEXT() : base("TB_CADASTRO_BRUTO_CONTEXT")
        {
        }

        public DbSet<TB_CADASTRO_BRUTO> CadastrosBrutos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //para remover nomes com plural da tabela
        }
    }
}
