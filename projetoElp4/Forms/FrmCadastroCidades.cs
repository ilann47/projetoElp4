using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmCadastroCidades : projetoElp4.FrmCadastro
    {
        Cidades aCidade;
        FrmConsultaEstados oFrmConsultaEstados;
        FrmCadastro oFrmCadastro;
        public FrmCadastroCidades()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            aCidade = (Cidades)obj;
            oFrmCadastro = new FrmCadastro();
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

        public void setFrmConsultaEstado(Object obj)
        {
            oFrmConsultaEstados = (FrmConsultaEstados)obj;
        }


        private void btnConsultaEstados_Click(object sender, EventArgs e)
        {
            string txt = this.oFrmCadastro.btnSalvar1.Text;
            this.oFrmCadastro.btnSalvar1.Text = "Selecionar";
            oFrmConsultaEstados.ConhecaObj(aCidade.OEstado);
            oFrmConsultaEstados.ShowDialog();
            this.txtBoxEstado.Text = aCidade.OEstado.Estado;
            this.txtBoxCidade.Text = aCidade.Cidade.ToString();
   
            this.oFrmCadastro.btnSalvar1.Text = txt;
        }

        private void btnSalvar1_Click(object sender, EventArgs e)
        {

        }
    }
}
