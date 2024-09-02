using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmCadastroEstados : projetoElp4.FrmCadastro
    {
        Estados oEstado;
        FrmConsultaPaises oFrmConsultaPaises;
        FrmCadastro oFrmCadastro;
        public FrmCadastroEstados()
        {
            oFrmCadastro = new FrmCadastro();
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oEstado = (Estados)obj;
        }
        public override void CarregaTxt()
        {
            this.txtBoxEstado.Text = oEstado.Estado;
            this.textBoxUF.Text = oEstado.Uf;
        }
        public override void LimpaTxt()
        {
            this.txtBoxEstado.Clear();
            this.textBoxUF.Clear();
        }
        public override void BloqueiaTxt()
        {
            this.txtBoxEstado.Enabled = false;
            this.textBoxUF.Enabled = false;
        }
        public override void DesbloqueiaTxt()
        {
            this.txtBoxEstado.Enabled = true;
            this.textBoxUF.Enabled = true;
        }
        public override void Salvar()
        {
            oEstado.Uf = this.textBoxUF.Text;
            oEstado.Estado = this.txtBoxEstado.Text;
        }

        public void setFrmConsultaPaises(Object obj)
        {
            oFrmConsultaPaises = (FrmConsultaPaises) obj;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            string txt = this.oFrmCadastro.btnSalvar1.Text;
            this.oFrmCadastro.btnSalvar1.Text = "Selecionar";
            oFrmConsultaPaises.ConhecaObj(oEstado.OPais);
             oFrmConsultaPaises.ShowDialog();
             this.txtBoxCodPais.Text = oEstado.OPais.Codigo.ToString();
             this.textBoxPais.Text = oEstado.OPais.Pais;
            this.oFrmCadastro.btnSalvar1.Text = txt;
        }
    }
}
