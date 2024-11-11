using projetoElp4._Fornecedores.View.FrmCadastro;
using projetoElp4._Fornecedores.View.FrmConsulta;
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
        FrmConsultaFornecedores oFrmConsultaFornecedores;
        FrmCadastroFornecedores oFrmCadastroFornecedores;
        FrmCadastroCidades ofrmCadastroCidades;
        FrmCadastroEstados ofrmCadastroEstados;
        FrmCadastroPaises ofrmCadastroPaises;

        public Interfaces() {
            ofrmConsultaCidades = new FrmConsultaCidades();
            ofrmConsultaPaises = new FrmConsultaPaises();
            ofrmConsultaEstados = new FrmConsultaEstados();
            oFrmConsultaFornecedores = new FrmConsultaFornecedores();
            ofrmCadastroCidades = new FrmCadastroCidades();
            ofrmCadastroEstados = new FrmCadastroEstados();
            ofrmCadastroPaises = new FrmCadastroPaises();
            oFrmCadastroFornecedores = new FrmCadastroFornecedores();   
            ofrmConsultaPaises.SetFrmCadastro(ofrmCadastroPaises);
			ofrmConsultaEstados.SetFrmCadastro(ofrmCadastroEstados);
			ofrmCadastroEstados.setFrmConsultaPaises(ofrmConsultaPaises);
			ofrmConsultaCidades.SetFrmCadastro(ofrmCadastroCidades);
            ofrmCadastroCidades.setFrmConsultaEstado(ofrmConsultaEstados);
            oFrmConsultaFornecedores.SetFrmCadastro(oFrmCadastroFornecedores);
            oFrmCadastroFornecedores.setFrmConsultaCidades(ofrmConsultaCidades);

        }
        public void PecaPaises(Object obj, Object Controller)
        {
            ofrmConsultaPaises.ConhecaObj(obj, Controller);
            ofrmConsultaPaises.ShowDialog();
        }
        public void PecaCidades(Object obj, Object Controller)
        {
            ofrmConsultaCidades.ConhecaObj(obj, Controller);
            ofrmConsultaCidades.ShowDialog();
        }
        public void PecaEstados(Object obj, Object Controller)
        {
            ofrmConsultaEstados.ConhecaObj(obj, Controller);
            ofrmConsultaEstados.ShowDialog();
        }
        public void PecaFornecedores(Object obj, Object Controller)
        {
            oFrmConsultaFornecedores.ConhecaObj(obj, Controller);
            oFrmConsultaFornecedores.ShowDialog();
        }
    }
}
