namespace projetoElp4
{
    partial class FrmCadastroEstados
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.txtBoxCodPais = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar1
            // 
            this.btnSalvar1.TabIndex = 6;
            // 
            // Sair
            // 
            this.Sair.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(108, 13);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(225, 14);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 14;
            this.lblUF.Text = "UF";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(347, 13);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "Pais";
            // 
            // txtBoxEstado
            // 
            this.txtBoxEstado.Location = new System.Drawing.Point(111, 32);
            this.txtBoxEstado.Name = "txtBoxEstado";
            this.txtBoxEstado.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEstado.TabIndex = 2;
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(228, 32);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(38, 20);
            this.textBoxUF.TabIndex = 3;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(334, 32);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 5;
            // 
            // txtBoxCodPais
            // 
            this.txtBoxCodPais.Location = new System.Drawing.Point(286, 32);
            this.txtBoxCodPais.Name = "txtBoxCodPais";
            this.txtBoxCodPais.Size = new System.Drawing.Size(42, 20);
            this.txtBoxCodPais.TabIndex = 4;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(515, 30);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // FrmCadastroEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtBoxCodPais);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.txtBoxEstado);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Name = "FrmCadastroEstados";
            this.Controls.SetChildIndex(this.btnSalvar1, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.textBoxCodigo, 0);
            this.Controls.SetChildIndex(this.Sair, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtBoxEstado, 0);
            this.Controls.SetChildIndex(this.textBoxUF, 0);
            this.Controls.SetChildIndex(this.textBoxPais, 0);
            this.Controls.SetChildIndex(this.txtBoxCodPais, 0);
            this.Controls.SetChildIndex(this.btnConsulta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblPais;
        public System.Windows.Forms.Button btnConsulta;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.TextBox txtBoxEstado;
        public System.Windows.Forms.TextBox textBoxUF;
        public System.Windows.Forms.TextBox textBoxPais;
        public System.Windows.Forms.TextBox txtBoxCodPais;
    }
}
