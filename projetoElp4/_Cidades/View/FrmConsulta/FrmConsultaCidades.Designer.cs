namespace projetoElp4
{
    partial class FrmConsultaCidades
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
			this.HeaderDDD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(1021, 648);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(913, 648);
			// 
			// btnIncluir
			// 
			this.btnIncluir.Location = new System.Drawing.Point(805, 648);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(1021, 31);
			this.btnPesquisar.Size = new System.Drawing.Size(178, 32);
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderDDD,
            this.HeaderCidade,
            this.HeaderEstado});
			this.listView.Size = new System.Drawing.Size(1184, 574);
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			// 
			// textBoxCodigo
			// 
			this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			// 
			// HeaderDDD
			// 
			this.HeaderDDD.Text = "DDD";
			// 
			// HeaderCidade
			// 
			this.HeaderCidade.Text = "Cidade";
			this.HeaderCidade.Width = 216;
			// 
			// HeaderEstado
			// 
			this.HeaderEstado.Text = "Estado";
			this.HeaderEstado.Width = 225;
			// 
			// FrmConsultaCidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(1212, 691);
			this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.Name = "FrmConsultaCidades";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ColumnHeader Codigo;
        public System.Windows.Forms.ColumnHeader HeaderDDD;
        public System.Windows.Forms.ColumnHeader HeaderCidade;
        public System.Windows.Forms.ColumnHeader HeaderEstado;
    }
}
