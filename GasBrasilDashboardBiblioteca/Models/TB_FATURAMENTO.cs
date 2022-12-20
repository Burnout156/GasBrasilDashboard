using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GasBrasilDashboardBiblioteca.Models
{
    public class TB_FATURAMENTO
    {
        public int ID_CLIENTE;
        public DateTime? DATA_REFERENCIA;
        public double? CONSUMO_M3;
        public DateTime? DATA_ARQUIVO;
    }
}
