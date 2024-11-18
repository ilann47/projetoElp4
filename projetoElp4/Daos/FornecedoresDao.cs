using projetoElp4._Paises.Collections;
using projetoElp4.MainWindow.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Fornecedores.Daos
{
    internal class FornecedoresDao : Dao
    {
        public FornecedoresDao() { }

        public override string Salvar(object obj)
        {
            return " ";
        }

        public override string Excluir(object obj)
        {
            return " ";
        }

        public override Object CarregaTudo()
        {
            PaisesCol paisesCol = new PaisesCol();
            return paisesCol;
        }

        public override Object CarregaObj(int IdObj)
        {
            return null;
        }
    }
}
