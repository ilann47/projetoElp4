using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmCadastro : projetoElp4.FrmPai
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }
        public virtual void ConhecaObj(Object obj)
        {

        }
        public virtual void CarregaTxt()
        {

        }
        public virtual void LimpaTxt()
        {


        }
        public virtual void BloqueiaTxt()
        {

        }
        public virtual void DesbloqueiaTxt()
        {

        }
        public virtual void Salvar()
        {
        }


        private void btnSalvar1_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
