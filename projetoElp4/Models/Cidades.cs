using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4
{
    internal class Cidades : Pai
    {
        protected Estados oEstado;
        protected string cidade;
        protected string ddd;
        public Cidades() : base()
        {
            oEstado = new Estados();
            cidade = " ";
            ddd = " ";

        }
        public Cidades(int codigo, string datCad, string datUltAlt, int coduso, Estados oEstado, string ddd, string cidade) : base(codigo, datCad, datUltAlt, coduso)
        {
            this.ddd = ddd;
            this.cidade = cidade;
            this.oEstado = oEstado;
        }

        public string Ddd
        {
            get { return ddd; }
            set { ddd = value; }
        }

        public Estados OEstado
        {
            get { return oEstado; }
            set { oEstado = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }
}
