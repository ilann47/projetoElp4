﻿namespace projetoElp4
{
    partial class FrmConsultaEstados
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
            this.HeaderUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderUF,
            this.HeaderEstado,
            this.HeaderPais});
            // 
            // HeaderUF
            // 
            this.HeaderUF.Text = "UF";
            // 
            // HeaderEstado
            // 
            this.HeaderEstado.Text = "Estado";
            this.HeaderEstado.Width = 152;
            // 
            // HeaderPais
            // 
            this.HeaderPais.Text = "Pais";
            this.HeaderPais.Width = 178;
            // 
            // FrmConsultaEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 379);
            this.Name = "FrmConsultaEstados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ColumnHeader HeaderUF;
        private System.Windows.Forms.ColumnHeader HeaderEstado;
        private System.Windows.Forms.ColumnHeader HeaderPais;
    }
}
