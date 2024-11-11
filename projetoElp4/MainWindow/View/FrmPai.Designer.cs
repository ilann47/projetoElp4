namespace projetoElp4
{
    partial class FrmPai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblCodigo = new System.Windows.Forms.Label();
			this.textBoxCodigo = new System.Windows.Forms.TextBox();
			this.Sair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(12, 17);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(51, 16);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Codigo";
			// 
			// textBoxCodigo
			// 
			this.textBoxCodigo.Location = new System.Drawing.Point(15, 36);
			this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxCodigo.Name = "textBoxCodigo";
			this.textBoxCodigo.Size = new System.Drawing.Size(100, 22);
			this.textBoxCodigo.TabIndex = 1;
			// 
			// Sair
			// 
			this.Sair.Location = new System.Drawing.Point(1129, 647);
			this.Sair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Sair.Name = "Sair";
			this.Sair.Size = new System.Drawing.Size(75, 23);
			this.Sair.TabIndex = 2;
			this.Sair.Text = "Sair";
			this.Sair.UseVisualStyleBackColor = true;
			this.Sair.Click += new System.EventHandler(this.Sair_Click);
			// 
			// FrmPai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1216, 681);
			this.Controls.Add(this.Sair);
			this.Controls.Add(this.textBoxCodigo);
			this.Controls.Add(this.lblCodigo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmPai";
			this.Text = "ProjetoElp4 Ilan";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox textBoxCodigo;
        public System.Windows.Forms.Button Sair;
    }
}