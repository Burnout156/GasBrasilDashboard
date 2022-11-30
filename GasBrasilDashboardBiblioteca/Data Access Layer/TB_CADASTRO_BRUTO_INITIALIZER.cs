using GasBrasilDashboardBiblioteca.Models;

namespace GasBrasilDashboardBiblioteca.Data_Access_Layer
{
    //classe para fazer a inicialização do banco de dados
    public class TB_CADASTRO_BRUTO_INITIALIZER : System.Data.Entity.DropCreateDatabaseIfModelChanges<TB_CADASTRO_BRUTO_CONTEXT>
    {
        protected override void Seed(TB_CADASTRO_BRUTO_CONTEXT context)
        {
            var CadastrosBrutos = new List<TB_CADASTRO_BRUTO>
            {
                new TB_CADASTRO_BRUTO { ID_CLIENTE = 1234, CLASSE_CONSUMO = "Residencial", MUNICIPIO = 'A', BAIRRO = "A1", COORD_UTMX = 1222334.23, COORD_UTMY = 12213.23, EXCLUIR = false, DATA_ARQUIVO = null },
                new TB_CADASTRO_BRUTO { ID_CLIENTE = 1235, CLASSE_CONSUMO = "Comercial", MUNICIPIO = 'B', BAIRRO = "B1", COORD_UTMX = 12132122.2, COORD_UTMY = 7777653.56, EXCLUIR = false, DATA_ARQUIVO = null }
            };

            CadastrosBrutos.ForEach(s => context.CadastrosBrutos.Add(s));
            context.SaveChanges();
        }
    }
}
