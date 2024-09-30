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
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderDDD,
            this.HeaderCidade,
            this.HeaderEstado});
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 379);
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
