using projetoElp4;
using projetoElp4._Paises.Collections;
using projetoElp4.MainWindow.Dao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1_ELP4.Daos
{
    public class PaisDao : Dao
    {
        public PaisDao()
        {

        }
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string ok = " ";
            string sql;
            if (oPais.Codigo == 0)
            {
                sql = "insert into paises(Pais, Sigla, Ddi, Moeda)";
            }
            else
            {
                sql = " update paises set Pais = @Pais, Sigla =@Sigla, Ddi = @Ddi, Moeda= @Moeda where Codigo= @Codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@Pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@Sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@Ddi", oPais.Ddi);
                cmd.Parameters.AddWithValue("@Moeda", oPais.Moeda);

                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@IDENTITY";
                ok = cmd.ExecuteScalar().ToString();
            }
            return ok;
        }
        public override string Excluir(object obj)
        {
            return " ";
        }
        public override object CarregaTudo()
        {
            PaisesCol colPaises = new PaisesCol();
            return colPaises;
        }

        public override object CarregaObj(int idobj)
        {
            return null;
        }
    }
}