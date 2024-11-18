using projetoElp4._Cidades.Controllers;
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
        CidadesController aCidadeController;
        FrmConsultaEstados oFrmConsultaEstados;
        public FrmCadastroCidades()
        {
            InitializeComponent();

        }
        public override void ConhecaObj(Object obj, Object Controller)
        {
            aCidade = (Cidades)obj;
            aCidadeController = (CidadesController)Controller;
        }
        public override void CarregaTxt()
        {
            this.txtBoxCidade.Text = aCidade.Cidade;
            this.txtBoxDDD.Text = aCidade.Ddd;
        }
        public override void LimpaTxt()
        {
            this.txtBoxDDD.Clear();
            this.txtBoxCidade.Clear();

        }
        public override void BloqueiaTxt()
        {
            this.txtBoxCidade.Enabled = false;
            this.txtBoxDDD.Enabled = false;
        }
        public override void DesbloqueiaTxt()
        {
            this.txtBoxDDD.Enabled = true;
            this.txtBoxCidade.Enabled = true;
        }
        public override void Salvar()
        {
            aCidade.Ddd = this.txtBoxDDD.Text;
            aCidade.Cidade = this.txtBoxCidade.Text;
        }

        public void setFrmConsultaEstado(Object obj)
        {
            oFrmConsultaEstados = (FrmConsultaEstados)obj;
        }


        private void btnConsultaEstados_Click(object sender, EventArgs e)
        {
            //string txt = this.oFrmCadastro.btnSalvar1.Text;
            //this.oFrmCadastro.btnSalvar1.Text = "Selecionar";
            oFrmConsultaEstados.ConhecaObj(aCidade.OEstado, null);
            oFrmConsultaEstados.ShowDialog();
            this.txtBoxEstado.Text = aCidade.OEstado.Estado;
            this.txtBoxCidade.Text = aCidade.Cidade.ToString();
   
            //this.oFrmCadastro.btnSalvar1.Text = txt;
        }

        private void btnSalvar1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
