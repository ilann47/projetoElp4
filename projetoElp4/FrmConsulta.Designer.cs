namespace projetoElp4
{
    partial class FrmConsulta
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
            this.Excluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Incluir = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(477, 337);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(53, 19);
            this.Excluir.TabIndex = 3;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(418, 337);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(53, 19);
            this.Alterar.TabIndex = 4;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(359, 337);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(53, 19);
            this.Incluir.TabIndex = 5;
            this.Incluir.Text = "Incluir";
            this.Incluir.UseVisualStyleBackColor = true;
            this.Incluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(213, 30);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(82, 19);
            this.Pesquisar.TabIndex = 6;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Excluir);
            this.Name = "FrmConsulta";
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.textBoxCodigo, 0);
            this.Controls.SetChildIndex(this.Sair, 0);
            this.Controls.SetChildIndex(this.Excluir, 0);
            this.Controls.SetChildIndex(this.Alterar, 0);
            this.Controls.SetChildIndex(this.Incluir, 0);
            this.Controls.SetChildIndex(this.Pesquisar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Incluir;
        private System.Windows.Forms.Button Pesquisar;
    }
}
