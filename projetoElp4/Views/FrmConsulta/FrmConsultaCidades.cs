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
    public partial class FrmConsultaCidades : projetoElp4.FrmConsulta
    {
        FrmCadastroCidades oFrmCadastroCidades;
        CidadesController aCidadeController;
        List<Cidades> ListaCidades;
        public FrmConsultaCidades()
        {
            InitializeComponent();
            ListaCidades = new List<Cidades>();

        }
        public override void ConhecaObj(Object obj, Object Controller)
        {
            Cidades aCidade = (Cidades)obj;
            aCidadeController = (CidadesController)Controller;  
        }

        protected override void Incluir()
        {
            Cidades novaCidade = new Cidades();
            oFrmCadastroCidades.ConhecaObj(novaCidade, aCidadeController);
            oFrmCadastroCidades.txtBoxEstado.Enabled = false;
            oFrmCadastroCidades.LimpaTxt();
            oFrmCadastroCidades.ShowDialog();

            ListaCidades.Add(novaCidade);

            this.CarregaLV();

        }
        protected override void Alterar()
        {
            if (oFrmCadastroCidades == null || listView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Formulário de cadastro não está configurado ou nenhum item foi selecionado.");
                return;
            }
            int index = listView.SelectedIndices[0];
            Cidades CidadeSelecionado = ListaCidades[index];
            oFrmCadastroCidades.ConhecaObj(CidadeSelecionado, aCidadeController);
            oFrmCadastroCidades.LimpaTxt();
            oFrmCadastroCidades.CarregaTxt();
            oFrmCadastroCidades.ShowDialog();
            this.CarregaLV();

        }
        protected override void Excluir()
        {
            if (oFrmCadastroCidades == null || listView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Formulário de cadastro não está configurado ou nenhum item foi selecionado.");
                return;
            }
            int index = listView.SelectedIndices[0];
            ListaCidades.RemoveAt(index);
            oFrmCadastroCidades.LimpaTxt();
            oFrmCadastroCidades.CarregaTxt();
            oFrmCadastroCidades.BloqueiaTxt();
            oFrmCadastroCidades.DesbloqueiaTxt();
            this.CarregaLV();
        }
        protected override void CarregaLV()
        {
            listView.Items.Clear();
            base.CarregaLV();
            foreach(var aCidade in ListaCidades)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(aCidade.Codigo));
                item.SubItems.Add(aCidade.Ddd);
                item.SubItems.Add(aCidade.Cidade);
                item.SubItems.Add(aCidade.OEstado.Estado);
                this.listView.Items.Add(item);
            }

        }
        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroCidades = (FrmCadastroCidades)Frm;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
