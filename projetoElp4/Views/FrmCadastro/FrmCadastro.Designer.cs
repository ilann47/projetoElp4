namespace projetoElp4
{
    partial class FrmCadastro
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
			this.btnSalvar1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxCodigo
			// 
			this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxCodigo.Text = "0";
			// 
			// Sair
			// 
			this.Sair.Location = new System.Drawing.Point(708, 410);
			this.Sair.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Sair.Size = new System.Drawing.Size(80, 28);
			this.Sair.Click += new System.EventHandler(this.Sair_Click_1);
			// 
			// btnSalvar1
			// 
			this.btnSalvar1.Location = new System.Drawing.Point(588, 410);
			this.btnSalvar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSalvar1.Name = "btnSalvar1";
			this.btnSalvar1.Size = new System.Drawing.Size(100, 28);
			this.btnSalvar1.TabIndex = 12;
			this.btnSalvar1.Text = "Salvar";
			this.btnSalvar1.UseVisualStyleBackColor = true;
			this.btnSalvar1.Click += new System.EventHandler(this.btnSalvar1_Click);
			// 
			// FrmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(803, 448);
			this.Controls.Add(this.btnSalvar1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmCadastro";
			this.Controls.SetChildIndex(this.btnSalvar1, 0);
			this.Controls.SetChildIndex(this.lblCodigo, 0);
			this.Controls.SetChildIndex(this.textBoxCodigo, 0);
			this.Controls.SetChildIndex(this.Sair, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSalvar1;
    }
}
