using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmConsulta : projetoElp4.FrmPai
    {

        public FrmConsulta()
        {
            InitializeComponent();
        }
        public virtual void ConhecaObj(Object obj)
        {

        }
        protected virtual void Incluir()
        {

        }

        protected virtual void Excluir()
        {

        }

        protected virtual void Alterar()
        {

        }
        protected virtual void CarregaLV()
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.Incluir();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Alterar();

        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Excluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public virtual void SetFrmCadastro(Object Frm)
        {

        }
    }
}