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
        public FrmConsultaCidades()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadastroCidades.ShowDialog();
        }

        protected override void Excluir()
        {
            oFrmCadastroCidades.ShowDialog();

        }

        protected override void Alterar()
        {
            oFrmCadastroCidades.ShowDialog();

        }


        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroCidades = (FrmCadastroCidades) Frm;
        }
    }
}
