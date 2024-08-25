using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmConsultaEstados : projetoElp4.FrmConsulta
    {
        FrmCadastroEstados oFrmCadastroEstados;
        public FrmConsultaEstados()
        {
            InitializeComponent();
        }
        protected override void Incluir()
        {
            oFrmCadastroEstados.ShowDialog();

        }

        protected override void Excluir()
        {
            oFrmCadastroEstados.ShowDialog();

        }

        protected override void Alterar()
        {
            oFrmCadastroEstados.ShowDialog();

        }

        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroEstados = (FrmCadastroEstados)Frm;
        }
    }
}
