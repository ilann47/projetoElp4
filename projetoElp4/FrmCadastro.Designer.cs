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
            this.Pesquisa = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Incluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(206, 36);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(96, 22);
            this.Pesquisa.TabIndex = 3;
            this.Pesquisa.Text = "Pesquisar";
            this.Pesquisa.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(632, 415);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 4;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(470, 415);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(75, 23);
            this.Incluir.TabIndex = 5;
            this.Incluir.Text = "Incluir";
            this.Incluir.UseVisualStyleBackColor = true;
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(551, 415);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 23);
            this.Alterar.TabIndex = 6;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Pesquisa);
            this.Name = "FrmCadastro";
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.textBoxCodigo, 0);
            this.Controls.SetChildIndex(this.Sair, 0);
            this.Controls.SetChildIndex(this.Pesquisa, 0);
            this.Controls.SetChildIndex(this.Excluir, 0);
            this.Controls.SetChildIndex(this.Incluir, 0);
            this.Controls.SetChildIndex(this.Alterar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pesquisa;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Incluir;
        private System.Windows.Forms.Button Alterar;
    }
}
