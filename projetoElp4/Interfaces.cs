using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4
{

    internal class Interfaces
    {
    //    FrmConsultaPaises ofrmConsultaPaises;
  //      FrmConsultaCidades ofrmConsultaCidades;
//        FrmConsultaEstados ofrmConsultaEstados;
        FrmCadastroCidades ofrmCadastroCidades;
        FrmCadastroEstados ofrmCadastroEstados;
        FrmCadastroPaises ofrmCadastroPaises;
        public Interfaces() {
      //      ofrmConsultaCidades = new FrmConsultaCidades();
        //    ofrmConsultaPaises = new FrmConsultaPaises();
          //  ofrmConsultaEstados = new FrmConsultaEstados();
            ofrmCadastroCidades = new FrmCadastroCidades();
            ofrmCadastroEstados = new FrmCadastroEstados();
            ofrmCadastroPaises = new FrmCadastroPaises();
        }
        public void PecaPaises()
        {
  //          ofrmConsultaPaises.ShowDialog();
        }
        public void PecaCidades()
        {
  //          ofrmConsultaCidades.Show();
        }
        public void PecaEstados()
        {
   //         ofrmConsultaEstados.Show();
        }
    }
}
