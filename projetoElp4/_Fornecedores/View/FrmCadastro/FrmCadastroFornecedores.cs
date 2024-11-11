using projetoElp4._Estados.Controllers;
using projetoElp4._Fornecedores.Controllers;
using projetoElp4._Fornecedores.View.FrmConsulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4._Fornecedores.View.FrmCadastro
{
    public partial class FrmCadastroFornecedores : projetoElp4.FrmCadastro
    {
		Fornecedores oFornecedor;
		FornecedoresController oFornecedorController;
		FrmConsultaCidades oFrmConsultaCidades;
		public FrmCadastroFornecedores()
        {
            InitializeComponent();
        }


		public override void ConhecaObj(Object obj, Object Controller)
		{
			oFornecedor = (Fornecedores)obj;
			oFornecedorController = (FornecedoresController)Controller;
		}
		public override void CarregaTxt()
		{
			this.textBoxCodigo.Text = oFornecedor.Codigo.ToString();
			this.txtBoxBairro.Text = oFornecedor.aCidade.Cidade;
			this.txtBoxCep.Text = oFornecedor.Cep;
			this.txtBoxCnpj.Text = oFornecedor.Cnpj;
			this.txtBoxComplemento.Text = oFornecedor.Complemento;
			this.txtBoxEmail.Text = oFornecedor.Email;
			this.txtBoxNumero.Text = oFornecedor.Numero;	
			this.txtBoxTelefone.Text = oFornecedor.Telefone;
			this.txtBoxNomeFornecedor.Text = oFornecedor.NomeFornecedor;
			this.txtBoxInscricaoEstadual.Text = oFornecedor.InscricaoEstadual;
			this.textBoxEndereco.Text = oFornecedor.Endereco;

		}
		public override void LimpaTxt()
		{
			this.txtBoxBairro.Clear();
			this.txtBoxCep.Clear();
			this.txtBoxCnpj.Clear();
			this.txtBoxComplemento.Clear();
			this.txtBoxEmail.Clear();
			this.txtBoxNumero.Clear();
			this.txtBoxTelefone.Clear();
			this.txtBoxNomeFornecedor.Clear();
			this.txtBoxInscricaoEstadual.Clear();
			this.textBoxEndereco.Clear();
			this.textBoxCodigo.Clear();

		}
		public override void BloqueiaTxt()
		{
			this.txtBoxBairro.Enabled = false;
			this.txtBoxCep.Enabled = false;
			this.txtBoxCnpj.Enabled = false;
			this.txtBoxComplemento.Enabled = false;
			this.txtBoxEmail.Enabled = false;
			this.txtBoxNumero.Enabled = false;
			this.txtBoxTelefone.Enabled = false;
			this.txtBoxNomeFornecedor.Enabled = false;
			this.txtBoxInscricaoEstadual.Enabled = false;
			this.textBoxEndereco.Enabled = false;
			this.textBoxCodigo.Enabled = false;

		}
		public override void DesbloqueiaTxt()
		{
			this.txtBoxBairro.Enabled = true;
			this.txtBoxCep.Enabled = true;
			this.txtBoxCnpj.Enabled = true;
			this.txtBoxComplemento.Enabled = true;
			this.txtBoxEmail.Enabled = true;
			this.txtBoxNumero.Enabled = true;
			this.txtBoxTelefone.Enabled = true;
			this.txtBoxNomeFornecedor.Enabled = true;
			this.txtBoxInscricaoEstadual.Enabled = true;
			this.textBoxEndereco.Enabled = true;
			this.textBoxCodigo.Enabled = true;

		}
		public override void Salvar()
		{
			// Verifica se os campos obrigatórios estão preenchidos
			if (string.IsNullOrWhiteSpace(this.txtBoxNomeFornecedor.Text) ||
				string.IsNullOrWhiteSpace(this.txtBoxInscricaoEstadual.Text) ||
				string.IsNullOrWhiteSpace(this.txtBoxEmail.Text) ||
				string.IsNullOrWhiteSpace(this.txtBoxCnpj.Text) ||
				//string.IsNullOrWhiteSpace(this.txtBoxCidade.Text) ||
				string.IsNullOrWhiteSpace(this.txtBoxCep.Text) ||
				string.IsNullOrWhiteSpace(this.txtBoxNumero.Text) ||
				string.IsNullOrWhiteSpace(this.txtBoxBairro.Text) ||
				string.IsNullOrWhiteSpace(this.textBoxEndereco.Text) ||
				string.IsNullOrWhiteSpace(this.txtBoxTelefone.Text))
			{
				MessageBox.Show("Campos obrigatórios não preenchidos.");
				return;
			}

			// Atribui os valores dos campos de texto ao objeto oFornecedor
			this.textBoxCodigo.Text = oFornecedor.Codigo.ToString();
			oFornecedor.Codigo = Convert.ToInt32(this.textBoxCodigo.Text);
			oFornecedor.Bairro = this.txtBoxBairro.Text;
			oFornecedor.aCidade.Cidade = this.txtBoxCidade.Text;
			oFornecedor.Cep = this.txtBoxCep.Text;
			oFornecedor.Cnpj = this.txtBoxCnpj.Text;
			oFornecedor.Complemento = this.txtBoxComplemento.Text;
			oFornecedor.Email = this.txtBoxEmail.Text;
			oFornecedor.Numero = this.txtBoxNumero.Text;
			oFornecedor.Telefone = this.txtBoxTelefone.Text;
			oFornecedor.NomeFornecedor = this.txtBoxNomeFornecedor.Text;
			oFornecedor.InscricaoEstadual = this.txtBoxInscricaoEstadual.Text;
			oFornecedor.Endereco = this.textBoxEndereco.Text;
			Close();
		}

		public void setFrmConsultaCidades(object obj)
		{
			oFrmConsultaCidades = (FrmConsultaCidades)obj;
		}

		private void btnConsultarCidade_Click(object sender, EventArgs e)
		{
			oFrmConsultaCidades.ConhecaObj(oFornecedor.aCidade, oFornecedorController);
			oFrmConsultaCidades.ShowDialog();
			this.txtBoxCidade.Text = oFornecedor.aCidade.Cidade;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBoxEndereco_TextChanged(object sender, EventArgs e)
		{

		}

		private void Sair_Click_1(object sender, EventArgs e)
		{
			LimpaTxt();
			Close();
		}
	}
}
