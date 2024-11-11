using projetoElp4._Estados.Controllers;
using projetoElp4._Fornecedores.Controllers;
using projetoElp4._Fornecedores.View.FrmCadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetoElp4._Fornecedores.View.FrmConsulta
{
    public partial class FrmConsultaFornecedores : projetoElp4.FrmConsulta
    {
        Fornecedores oFornecedor;
        FrmCadastroFornecedores oFrmCadastroFornecedores;
        FornecedoresController oFornecedorController;
		List<Fornecedores> ListaFornecedores;
        public FrmConsultaFornecedores()
        {
            InitializeComponent();
            ListaFornecedores = new List<Fornecedores>();

        }
            public override void ConhecaObj(Object obj, Object Controller)
            {
                oFornecedor = (Fornecedores)obj;
                oFornecedorController = (FornecedoresController)Controller;
            }

            protected override void Incluir()
            {
			    int proximoCodigo = ListaFornecedores.Count > 0 ? ListaFornecedores.Max(f => f.Codigo) + 1 : 1;

			    Fornecedores novoFornecedor = new Fornecedores();
                novoFornecedor.Codigo = proximoCodigo;
                oFrmCadastroFornecedores.ConhecaObj(novoFornecedor, oFornecedorController);
                oFrmCadastroFornecedores.textBoxCodigo.Enabled = false;
                oFrmCadastroFornecedores.textBoxCodigo.Text = proximoCodigo.ToString();
                oFrmCadastroFornecedores.txtBoxCidade.Enabled = false;
                oFrmCadastroFornecedores.LimpaTxt();
                oFrmCadastroFornecedores.ShowDialog();

                ListaFornecedores.Add(novoFornecedor);
                this.CarregaLV();
            }
            protected override void Alterar()
            {
                if (oFrmCadastroFornecedores == null || listView.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("Formulário de cadastro não está configurado ou nenhum item foi selecionado.");
                    return;
                }
                int index = listView.SelectedIndices[0];
                Fornecedores FornecedorSelecionado = ListaFornecedores[index];
                oFrmCadastroFornecedores.ConhecaObj(FornecedorSelecionado, oFornecedorController);
                oFrmCadastroFornecedores.LimpaTxt();
                oFrmCadastroFornecedores.CarregaTxt();
                oFrmCadastroFornecedores.ShowDialog();
                this.CarregaLV();
            }
            protected override void Excluir()
            {
                if (oFrmCadastroFornecedores == null || listView.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("Formulário de cadastro não está configurado ou nenhum item foi selecionado.");
                    return;
                }
                int index = listView.SelectedIndices[0];
                ListaFornecedores.RemoveAt(index);
                oFrmCadastroFornecedores.LimpaTxt();
                oFrmCadastroFornecedores.CarregaTxt();
                oFrmCadastroFornecedores.BloqueiaTxt();
                oFrmCadastroFornecedores.DesbloqueiaTxt();
                this.CarregaLV();
            }
            protected override void CarregaLV()
            {
                base.CarregaLV();
                listView.Items.Clear();
                foreach (var oFornecedor in ListaFornecedores)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(oFornecedor.Codigo));
                    item.SubItems.Add(oFornecedor.NomeFornecedor);
    				item.SubItems.Add(oFornecedor.Telefone);
                    item.SubItems.Add(oFornecedor.Complemento);
                    item.SubItems.Add(oFornecedor.Numero);
                    item.SubItems.Add(oFornecedor.aCidade.Cidade);
                    item.SubItems.Add(oFornecedor.Cep);
                    item.SubItems.Add(oFornecedor.Bairro);
                    item.SubItems.Add(oFornecedor.Cnpj);
                    item.SubItems.Add(oFornecedor.Email);
                    item.SubItems.Add(oFornecedor.Endereco);
                    item.SubItems.Add(oFornecedor.InscricaoEstadual);

                    this.listView.Items.Add(item);
                }

            }

            public override void SetFrmCadastro(Object Frm)
            {
                oFrmCadastroFornecedores = (FrmCadastroFornecedores)Frm;
            }
        }
    }

