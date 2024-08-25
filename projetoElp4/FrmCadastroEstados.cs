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
        Estados oEstados;
        FrmConsultaPaises oFrmConsultaPaises;
        public FrmCadastroEstados()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oEstados = (Estados)obj;
        }
        public override void CarregaTxt()
        {

        }
        public override void LimpaTxt()
        {


        }
        public override void BloqueiaTxt()
        {

        }
        public override void DesbloqueiaTxt()
        {

        }
        public override void Salvar()
        {
        }

        public void setFrmConsultaPaises(Object obj)
        {
            oFrmConsultaPaises = (FrmConsultaPaises) obj;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
             oFrmConsultaPaises.ConhecaObj(oEstados.OPais);
             oFrmConsultaPaises.ShowDialog();
             this.txtBoxCodPais.Text = oEstados.OPais.Codigo.ToString();
            this.textBoxPais.Text = oEstados.OPais.Pais;
        }
    }
}
