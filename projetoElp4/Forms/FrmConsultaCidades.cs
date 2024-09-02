using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmConsultaCidades : projetoElp4.FrmConsulta
    {
        FrmCadastroCidades oFrmCadastroCidades;
        Cidades aCidade;
        public FrmConsultaCidades()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aCidade = (Cidades)obj;
        }

        protected override void Incluir()
        {

            oFrmCadastroCidades.ConhecaObj(aCidade);
            oFrmCadastroCidades.LimpaTxt();
            oFrmCadastroCidades.ShowDialog();

        }
        protected override void Alterar()
        {
            oFrmCadastroCidades.ConhecaObj(aCidade);
            oFrmCadastroCidades.LimpaTxt();
            oFrmCadastroCidades.CarregaTxt();
            oFrmCadastroCidades.ShowDialog();

        }
        protected override void Excluir()
        {
            oFrmCadastroCidades.LimpaTxt();
            oFrmCadastroCidades.ConhecaObj(aCidade);
            oFrmCadastroCidades.CarregaTxt();
            oFrmCadastroCidades.BloqueiaTxt();
            oFrmCadastroCidades.ShowDialog();
            oFrmCadastroCidades.DesbloqueiaTxt();
        }

        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroCidades = (FrmCadastroCidades)Frm;
        }
    }
}
