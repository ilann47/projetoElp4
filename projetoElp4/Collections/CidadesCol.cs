using projetoElp4.MainWindow.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Cidades.Collection
{
    internal class CidadesCol : Colecoes<Cidades>
    {
        public Cidades PesquisarSigla(string DDD)
        {
            foreach (var aCidade in aLista)
            {
                if (aCidade.Ddd.Equals(DDD))
                {
                    return aCidade;
                }
            }
            return null;
        }
    }
}
