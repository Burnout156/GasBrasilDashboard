using System.ComponentModel.DataAnnotations.Schema;

namespace GasBrasilDashboardBiblioteca.Models
{
    public class TB_CADASTRO_BRUTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_CLIENTE;
        public string CLASSE_CONSUMO;
        public char MUNICIPIO;
        public string BAIRRO;
        public double COORD_UTMX;
        public double COORD_UTMY;
        public bool EXCLUIR;
        public DateTime? DATA_ARQUIVO;


    }
}
