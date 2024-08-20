using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4
{

    internal class Interfaces
    {
        FrmConsultaPaises ofrmConsultaPaises;
        FrmConsultaCidades ofrmConsultaCidades;
        FrmConsultaEstados ofrmConsultaEstados;
        public Interfaces() {
            ofrmConsultaCidades = new FrmConsultaCidades();
            ofrmConsultaPaises = new FrmConsultaPaises();
            ofrmConsultaEstados = new FrmConsultaEstados();
        }
        public void PecaPaises()
        {
            ofrmConsultaPaises.Show();
        }
        public void PecaCidades()
        {
            ofrmConsultaCidades.Show();
        }
        public void PecaEstados()
        {
            ofrmConsultaEstados.Show();
        }
    }
}
