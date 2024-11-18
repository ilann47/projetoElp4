using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4
{
    internal class Estados : Pai
    {
        protected string UF;
        protected string estado;
        protected Paises oPais;

        public Estados() : base()
        {
            UF = " ";
            estado = " ";
            oPais = new Paises();
        }
        public Estados(int codigo, string datCad, string datUltAlt, int coduso, Paises oPais, string UF, string estado) : base(codigo, datCad, datUltAlt, coduso)
        {
            this.UF = UF;
            this.estado = estado;
            this.oPais = oPais; 
        }

        public string Uf
        {
            get { return UF; }
            set { UF = value; }
        }

        public Paises OPais
        {
            get { return oPais; }
            set { oPais = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
