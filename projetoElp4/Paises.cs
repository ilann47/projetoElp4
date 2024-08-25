using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4
{
    internal class Paises : Pai
    {
        protected string pais;
        protected string sigla;
        protected string ddi;
        protected string moeda;

        public Paises() : base()
        {
            pais = "";
            sigla = "";
            ddi = "";
            moeda = "";
        }

        public Paises(int codigo, string datCad, string datUltAlt, int coduso, string pais, string sigla, string ddi, string moeda)
            : base(codigo, datCad, datUltAlt, coduso)
        {
            this.pais = pais;
            this.sigla = sigla;
            this.ddi = ddi;
            this.moeda = moeda;
        }

        public string Pais
        {
            get { return pais; }
            set { this.pais = value; }
        }

        public string Sigla
        {
            get { return sigla; }
            set { this.sigla = value; }
        }

        public string Ddi
        {
            get { return ddi; }
            set { this.ddi = value; }
        }

        public string Moeda
        {
            get { return moeda; }
            set { this.moeda = value; }
        }
    }
}
