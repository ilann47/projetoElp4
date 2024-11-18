namespace projetoElp4
{
    partial class FrmConsultaPaises
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
			this.HeaderPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderSigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderDDI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HeaderMoeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(1021, 647);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(913, 647);
			// 
			// btnIncluir
			// 
			this.btnIncluir.Location = new System.Drawing.Point(805, 647);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Location = new System.Drawing.Point(1021, 31);
			this.btnPesquisar.Size = new System.Drawing.Size(180, 32);
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderPais,
            this.HeaderSigla,
            this.HeaderDDI,
            this.HeaderMoeda});
			this.listView.Location = new System.Drawing.Point(15, 70);
			this.listView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.listView.Size = new System.Drawing.Size(1189, 570);
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			// 
			// textBoxCodigo
			// 
			this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			// 
			// HeaderPais
			// 
			this.HeaderPais.Text = "Pais";
			this.HeaderPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.HeaderPais.Width = 236;
			// 
			// HeaderSigla
			// 
			this.HeaderSigla.Text = "Sigla";
			// 
			// HeaderDDI
			// 
			this.HeaderDDI.Text = "DDI";
			// 
			// HeaderMoeda
			// 
			this.HeaderMoeda.Text = "Moeda";
			// 
			// FrmConsultaPaises
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(1214, 692);
			this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.Name = "FrmConsultaPaises";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ColumnHeader HeaderPais;
        private System.Windows.Forms.ColumnHeader HeaderSigla;
        public System.Windows.Forms.ColumnHeader HeaderDDI;
        public System.Windows.Forms.ColumnHeader HeaderMoeda;
    }
}
