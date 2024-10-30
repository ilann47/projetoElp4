using projetoElp4;
using projetoElp4._Paises.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmConsultaPaises : projetoElp4.FrmConsulta
    {
        FrmCadastroPaises oFrmCadastroPaises;
        Paises oPais;
        PaisesController oPaisController;
        List<Paises> aListaPaises;


        public FrmConsultaPaises()
        {
            InitializeComponent();
            aListaPaises = new List<Paises>();
        }

        public override void ConhecaObj(Object obj, Object Controller)
        {
            if (obj is Paises)
            {
                oPais = (Paises)obj;
                oPaisController = (PaisesController)Controller;
            }
            else
            {
                MessageBox.Show("Objeto inválido. Esperado um objeto do tipo Paises.");
            }
        }
        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroPaises = (FrmCadastroPaises)Frm ?? throw new ArgumentNullException(nameof(Frm), "O formulário de cadastro não pode ser nulo.");
        }
        protected override void Incluir()
        {
            if (oFrmCadastroPaises == null)
            {
                MessageBox.Show("Formulário de cadastro não está configurado.");
                return;
            }

            Paises novoPais = new Paises(); 
            oFrmCadastroPaises.ConhecaObj(novoPais, oPaisController);
            oFrmCadastroPaises.LimpaTxt();
            oFrmCadastroPaises.ShowDialog();

            SalvaObjetoLista();

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
            Paises paisSelecionado = aListaPaises[index];

            oFrmCadastroPaises.ConhecaObj(paisSelecionado, oPaisController);
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
            aListaPaises.RemoveAt(index); 

            CarregaLV();
        }

        protected override void CarregaLV()
        {
            base.CarregaLV();
            listView.Items.Clear(); 

            foreach (var oPais in aListaPaises)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
                item.SubItems.Add(oPais.Pais);
                item.SubItems.Add(oPais.Sigla);
                item.SubItems.Add(oPais.Ddi);
                item.SubItems.Add(oPais.Moeda);
                listView.Items.Add(item);
            }
        }
        public override void SalvaObjetoLista()
        {
            base.SalvaObjetoLista();

            Paises pais = oPais.Clonar();

            if (pais.Codigo == 0) return;
            if (aListaPaises.Exists(p => p.Codigo == pais.Codigo)) return;

            aListaPaises.Add(pais);
        }


        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
