using GasBrasilDashboardBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasBrasilDashboardBiblioteca.Data_Access_Layer
{
    public class TB_FATURAMENTO_CONTEXT : DbContext //classe para fazer a manipulação entre os modelos de dados e o banco
    {
        public TB_FATURAMENTO_CONTEXT() : base("TB_FATURAMENTO_CONTEXT") 
        {
        }

        public DbSet<TB_FATURAMENTO> CadastrosBrutos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //para remover nomes com plural da tabela
        }
    }
}
