using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4.MainWindow
{
    internal class Banco
    {
        private static string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ilan\OneDrive\sistemasDeInformacao\periodo4\ELP4\projetoElp4\projetoElp4\Database.mdf;Integrated Security=True";
        

        public static SqlConnection Abrir()
        {
            SqlConnection cnn = new SqlConnection(strcnn);
            cnn.Open();
            return cnn;
        }
    }
}
