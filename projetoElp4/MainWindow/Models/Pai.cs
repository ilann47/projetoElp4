using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4
{
    internal class Pai
    {
        protected int codigo;
        protected string datCad;
        protected string datUltAlt;
        protected int coduso;   

        public Pai()
        {
            codigo = 0;
            datCad = "";
            datUltAlt = "";
            coduso = 0;
        }
        public Pai(int codigo, string datCad, string datUltAlt, int coduso)
        {
            this.codigo = codigo;
            this.datCad = datCad;
            this.datUltAlt = datUltAlt;
            this.coduso = coduso;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string DatCad
        {
            get { return datCad; }
            set { datCad = value; }
        }

        public string DatUltAlt
        {
            get { return datUltAlt; }
            set { datUltAlt = value; }
        }
    }
}
