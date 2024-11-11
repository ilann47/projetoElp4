namespace projetoElp4._Fornecedores.View.FrmConsulta
{
    partial class FrmConsultaFornecedores
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.HeaderFornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderComplemento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderCep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderInscricaoEstadual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(1313, 646);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(1205, 646);
			// 
			// btnIncluir
			// 
			this.btnIncluir.Location = new System.Drawing.Point(1097, 646);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(1313, 26);
			this.btnPesquisar.Size = new System.Drawing.Size(182, 32);
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderFornecedor,
            this.HeaderTelefone,
            this.HeaderComplemento,
            this.HeaderNumero,
            this.HeaderCidade,
            this.HeaderCep,
            this.HeaderBairro,
            this.HeaderCnpj,
            this.HeaderEmail,
            this.HeaderEndereco,
            this.HeaderInscricaoEstadual});
			this.listView.Size = new System.Drawing.Size(1481, 573);
			// 
			// Sair
			// 
			this.Sair.Location = new System.Drawing.Point(1421, 645);
			// 
			// HeaderFornecedor
			// 
			this.HeaderFornecedor.Text = "Fornecedor";
			this.HeaderFornecedor.Width = 142;
			// 
			// HeaderTelefone
			// 
			this.HeaderTelefone.Text = "Telefone";
			this.HeaderTelefone.Width = 112;
			// 
			// HeaderComplemento
			// 
			this.HeaderComplemento.Text = "Complemento";
			this.HeaderComplemento.Width = 119;
			// 
			// HeaderNumero
			// 
			this.HeaderNumero.Text = "Numero";
			this.HeaderNumero.Width = 89;
			// 
			// HeaderCidade
			// 
			this.HeaderCidade.Text = "Cidade";
			this.HeaderCidade.Width = 73;
			// 
			// HeaderCep
			// 
			this.HeaderCep.Text = "Cep";
			// 
			// HeaderBairro
			// 
			this.HeaderBairro.Text = "Bairro";
			// 
			// HeaderCnpj
			// 
			this.HeaderCnpj.Text = "Cnpj";
			// 
			// HeaderEmail
			// 
			this.HeaderEmail.Text = "Email";
			// 
			// HeaderEndereco
			// 
			this.HeaderEndereco.Text = "Endereco";
			this.HeaderEndereco.Width = 85;
			// 
			// HeaderInscricaoEstadual
			// 
			this.HeaderInscricaoEstadual.Text = "Inscrição Estadual";
			// 
			// FrmConsultaFornecedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(1509, 694);
			this.Name = "FrmConsultaFornecedores";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ColumnHeader HeaderFornecedor;
		private System.Windows.Forms.ColumnHeader HeaderTelefone;
		private System.Windows.Forms.ColumnHeader HeaderComplemento;
		private System.Windows.Forms.ColumnHeader HeaderNumero;
		private System.Windows.Forms.ColumnHeader HeaderCidade;
		private System.Windows.Forms.ColumnHeader HeaderCep;
		private System.Windows.Forms.ColumnHeader HeaderBairro;
		private System.Windows.Forms.ColumnHeader HeaderCnpj;
		private System.Windows.Forms.ColumnHeader HeaderEmail;
		private System.Windows.Forms.ColumnHeader HeaderEndereco;
		private System.Windows.Forms.ColumnHeader HeaderInscricaoEstadual;
	}
}
