using projetoElp4;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmConsultaPaises : projetoElp4.FrmConsulta
    {
        FrmCadastroPaises oFrmCadastroPaises;
        List<Paises> ListaPaises;

        public FrmConsultaPaises()
        {
            InitializeComponent();
            ListaPaises = new List<Paises>(); 
        }

        public override void ConhecaObj(Object obj)
        {
            if (obj is Paises)
            {
                Paises oPais = (Paises)obj;
            }
            else
            {
                MessageBox.Show("Objeto inválido. Esperado um objeto do tipo Paises.");
            }
        }

        protected override void Incluir()
        {
            if (oFrmCadastroPaises == null)
            {
                MessageBox.Show("Formulário de cadastro não está configurado.");
                return;
            }

            Paises novoPais = new Paises(); 
            oFrmCadastroPaises.ConhecaObj(novoPais);
            oFrmCadastroPaises.LimpaTxt();
            oFrmCadastroPaises.ShowDialog();

            if (!string.IsNullOrEmpty(novoPais.Pais))
            {
                ListaPaises.Add(novoPais);
            }

            CarregaLV();
        }

        protected override void Alterar()
        {
            if (oFrmCadastroPaises == null || listView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Formulário de cadastro não está configurado ou nenhum item foi selecionado.");
                return;
            }

            int index = listView.SelectedIndices[0]; 
            Paises paisSelecionado = ListaPaises[index];

            oFrmCadastroPaises.ConhecaObj(paisSelecionado);
            oFrmCadastroPaises.LimpaTxt();
            oFrmCadastroPaises.CarregaTxt();
            oFrmCadastroPaises.ShowDialog();

            CarregaLV();
        }

        protected override void Excluir()
        {
            if (oFrmCadastroPaises == null || listView.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Formulário de cadastro não está configurado ou nenhum item foi selecionado.");
                return;
            }

            int index = listView.SelectedIndices[0]; 
            ListaPaises.RemoveAt(index); 

            CarregaLV();
        }

        protected override void CarregaLV()
        {
            base.CarregaLV();
            listView.Items.Clear(); 

            foreach (var oPais in ListaPaises)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
                item.SubItems.Add(oPais.Pais);
                item.SubItems.Add(oPais.Sigla);
                item.SubItems.Add(oPais.Ddi);
                item.SubItems.Add(oPais.Moeda);
                listView.Items.Add(item);
            }
        }

        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroPaises = (FrmCadastroPaises)Frm ?? throw new ArgumentNullException(nameof(Frm), "O formulário de cadastro não pode ser nulo.");
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
