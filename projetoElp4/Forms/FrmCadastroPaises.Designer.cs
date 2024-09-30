namespace projetoElp4
{
    partial class FrmCadastroPaises
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
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblDDI = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.txtDDI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar1
            // 
            this.btnSalvar1.Location = new System.Drawing.Point(436, 337);
            this.btnSalvar1.TabIndex = 5;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.TabIndex = 0;
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(516, 337);
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 6;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(97, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "Pais";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(252, 9);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 4;
            this.lblSigla.Text = "Sigla";
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(358, 9);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(26, 13);
            this.lblDDI.TabIndex = 5;
            this.lblDDI.Text = "DDI";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(465, 9);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(40, 13);
            this.lblMoeda.TabIndex = 6;
            this.lblMoeda.Text = "Moeda";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(100, 29);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(149, 20);
            this.txtPais.TabIndex = 1;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(255, 29);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 2;
            // 
            // txtMoeda
            // 
            this.txtMoeda.Location = new System.Drawing.Point(468, 29);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(100, 20);
            this.txtMoeda.TabIndex = 4;
            // 
            // txtDDI
            // 
            this.txtDDI.Location = new System.Drawing.Point(361, 29);
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(100, 20);
            this.txtDDI.TabIndex = 3;
            // 
            // FrmCadastroPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.txtDDI);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblDDI);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblPais);
            this.Name = "FrmCadastroPaises";
            this.Text = " ProjetoElp4 Ilan";
            this.Controls.SetChildIndex(this.btnSalvar1, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.lblDDI, 0);
            this.Controls.SetChildIndex(this.lblMoeda, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.txtMoeda, 0);
            this.Controls.SetChildIndex(this.txtDDI, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.textBoxCodigo, 0);
            this.Controls.SetChildIndex(this.Sair, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblDDI;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.TextBox txtDDI;
    }
}
