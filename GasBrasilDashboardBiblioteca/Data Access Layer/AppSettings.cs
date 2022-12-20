using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasBrasilDashboardBiblioteca.Data_Access_Layer
{
    public class AppSettings //classe para armazenar as conexões
    {
        public string ConnectionString { get; set; }
        public string ConnectionString2 { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        // "Server=localhost,1433;Database=GasBrasilDB;User ID=root;Password=root"
    }
}
