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
            this.listViewConsulta = new System.Windows.Forms.ListView();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Incluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewConsulta
            // 
            this.listViewConsulta.HideSelection = false;
            this.listViewConsulta.Location = new System.Drawing.Point(12, 62);
            this.listViewConsulta.Name = "listViewConsulta";
            this.listViewConsulta.Size = new System.Drawing.Size(776, 336);
            this.listViewConsulta.TabIndex = 3;
            this.listViewConsulta.UseCompatibleStateImageBehavior = false;
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(282, 36);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(129, 23);
            this.Pesquisar.TabIndex = 4;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(632, 415);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 5;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
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
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(470, 415);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(75, 23);
            this.Incluir.TabIndex = 7;
            this.Incluir.Text = "Incluir";
            this.Incluir.UseVisualStyleBackColor = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.listViewConsulta);
            this.Name = "FrmConsulta";
            this.Controls.SetChildIndex(this.listViewConsulta, 0);
            this.Controls.SetChildIndex(this.Pesquisar, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.textBoxCodigo, 0);
            this.Controls.SetChildIndex(this.Sair, 0);
            this.Controls.SetChildIndex(this.Salvar, 0);
            this.Controls.SetChildIndex(this.Alterar, 0);
            this.Controls.SetChildIndex(this.Incluir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewConsulta;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Incluir;
    }
}
