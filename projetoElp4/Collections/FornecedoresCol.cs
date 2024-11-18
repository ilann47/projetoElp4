using projetoElp4.MainWindow.Collection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Fornecedores.Collection
{
    internal class FornecedoresCol : Colecoes<Fornecedores>
    {
        public Fornecedores PesquisarSigla(string NomeFornecedor)
        {
            foreach (var oFornecedor in aLista)
            {
                if (oFornecedor.NomeFornecedor.Equals(NomeFornecedor))
                {
                    return oFornecedor;
                }
            }
            return null;
        }
    }
}
