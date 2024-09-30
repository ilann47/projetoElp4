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
        List<Estados> ListaEstados;
        public FrmConsultaEstados()
        {
            InitializeComponent();
            ListaEstados = new List<Estados>();
        }
        public override void ConhecaObj(Object obj)
        {
            Estados oEstado = (Estados)obj;
        }

        protected override void Incluir()
        {
            Estados novoEstado = new Estados();
            oFrmCadastroEstados.ConhecaObj(novoEstado);
            oFrmCadastroEstados.txtBoxCodPais.Enabled = false;
            oFrmCadastroEstados.textBoxPais.Enabled = false;
            oFrmCadastroEstados.LimpaTxt();
            oFrmCadastroEstados.ShowDialog();

            ListaEstados.Add(novoEstado);


            this.CarregaLV();
        }
        protected override void Alterar()
        {
            if (oFrmCadastroEstados == null || listView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Formulário de cadastro não está configurado ou nenhum item foi selecionado.");
                return;
            }
            int index = listView.SelectedIndices[0];
            Estados EstadoSelecionado = ListaEstados[index];
            oFrmCadastroEstados.ConhecaObj(EstadoSelecionado);
            oFrmCadastroEstados.LimpaTxt();
            oFrmCadastroEstados.CarregaTxt();
            oFrmCadastroEstados.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            if (oFrmCadastroEstados == null || listView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Formulário de cadastro não está configurado ou nenhum item foi selecionado.");
                return;
            }
            int index = listView.SelectedIndices[0];
            ListaEstados.RemoveAt(index);
            oFrmCadastroEstados.LimpaTxt();
            oFrmCadastroEstados.CarregaTxt();
            oFrmCadastroEstados.BloqueiaTxt();
            //oFrmCadastroEstados.ShowDialog();
            oFrmCadastroEstados.DesbloqueiaTxt();
            this.CarregaLV();
        }
        protected override void CarregaLV()
        {
            base.CarregaLV();
            listView.Items.Clear();
            foreach (var oEstado in ListaEstados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
                item.SubItems.Add(oEstado.Uf);
                item.SubItems.Add(oEstado.Estado);
                item.SubItems.Add(oEstado.OPais.Pais);
                this.listView.Items.Add(item);
            }

        }

        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroEstados = (FrmCadastroEstados)Frm;
        }
    }
}
