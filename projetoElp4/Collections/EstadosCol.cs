using projetoElp4.MainWindow.Collection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Estados.Collections
{
    internal class EstadosCol : Colecoes<Estados>
    {
        public Estados PesquisarSigla(string UF)
        {
            foreach (var oEstado in aLista)
            {
                if (oEstado.Uf.Equals(UF))
                {
                    return oEstado;
                }
            }
            return null;
        }
    }
}
