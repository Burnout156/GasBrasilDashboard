using GasBrasilDashboardBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GasBrasilDashboardBiblioteca.Data_Access_Layer
{
    public class TB_FATURAMENTO_CONTEXT : DbContext //classe para fazer a manipulação entre os modelos de dados e o banco
    {
 

        public DbSet<TB_FATURAMENTO> Faturamentos { get; set; }

    }
}
