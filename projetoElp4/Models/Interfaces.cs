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
        FrmCadastroCidades ofrmCadastroCidades;
        FrmCadastroEstados ofrmCadastroEstados;
        FrmCadastroPaises ofrmCadastroPaises;
        public Interfaces() {
            ofrmConsultaCidades = new FrmConsultaCidades();
            ofrmConsultaPaises = new FrmConsultaPaises();
            ofrmConsultaEstados = new FrmConsultaEstados();
            ofrmCadastroCidades = new FrmCadastroCidades();
            ofrmCadastroEstados = new FrmCadastroEstados();
            ofrmCadastroPaises = new FrmCadastroPaises();
            ofrmConsultaPaises.SetFrmCadastro(ofrmCadastroPaises);
            ofrmConsultaEstados.SetFrmCadastro(ofrmCadastroEstados);
            ofrmConsultaCidades.SetFrmCadastro(ofrmCadastroCidades);
            ofrmCadastroEstados.setFrmConsultaPaises(ofrmConsultaPaises);
            ofrmCadastroCidades.setFrmConsultaEstado(ofrmConsultaEstados);
        }
        public void PecaPaises(Object obj)
        {
            ofrmConsultaPaises.ConhecaObj(obj);
            ofrmConsultaPaises.ShowDialog();
        }
        public void PecaCidades(Object obj)
        {
            ofrmConsultaCidades.ConhecaObj(obj);
            ofrmConsultaCidades.ShowDialog();
        }
        public void PecaEstados(Object obj)
        {
            ofrmConsultaEstados.ConhecaObj(obj);
            ofrmConsultaEstados.ShowDialog();
        }
    }
}
