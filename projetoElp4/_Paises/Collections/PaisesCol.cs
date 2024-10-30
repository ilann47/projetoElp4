using projetoElp4.MainWindow.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Paises.Collections
{
    internal class PaisesCol : Colecoes<Paises>
    {
        public Paises PesquisarSigla(string sigla)
        {
            foreach(var oPais in aLista)
            {
                if (oPais.Sigla.Equals(sigla))
                {
                    return oPais;
                }
            }
            return null;
        }
    }

}
