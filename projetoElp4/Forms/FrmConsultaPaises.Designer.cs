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
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderPais,
            this.HeaderSigla,
            this.HeaderDDI,
            this.HeaderMoeda});
            this.listView.Location = new System.Drawing.Point(11, 57);
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 379);
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
