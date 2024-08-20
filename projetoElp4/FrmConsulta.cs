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


        protected virtual void incluir()
        {

        }

        protected virtual void excluir()
        {

        }

        protected virtual void alterar()
        {

        }

        private void Incluir_Click(object sender, EventArgs e)
        {
            this.incluir();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            this.alterar();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            this.excluir();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {

        }

        public virtual void SetFrmCadastro(Object frm)
        {

        }
    }
}
