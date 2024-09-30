namespace projetoElp4
{
    partial class FrmCadastroCidades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDDD = new System.Windows.Forms.TextBox();
            this.txtBoxCidade = new System.Windows.Forms.TextBox();
            this.txtBoxEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultaEstados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalvar1
            // 
            this.btnSalvar1.TabIndex = 5;
            this.btnSalvar1.Click += new System.EventHandler(this.btnSalvar1_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(535, 333);
            this.Sair.Size = new System.Drawing.Size(56, 23);
            this.Sair.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "DDD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cidade";
            // 
            // txtBoxDDD
            // 
            this.txtBoxDDD.Location = new System.Drawing.Point(105, 29);
            this.txtBoxDDD.Name = "txtBoxDDD";
            this.txtBoxDDD.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDDD.TabIndex = 2;
            // 
            // txtBoxCidade
            // 
            this.txtBoxCidade.Location = new System.Drawing.Point(224, 29);
            this.txtBoxCidade.Name = "txtBoxCidade";
            this.txtBoxCidade.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCidade.TabIndex = 3;
            this.txtBoxCidade.TextChanged += new System.EventHandler(this.txtBoxCidade_TextChanged);
            // 
            // txtBoxEstado
            // 
            this.txtBoxEstado.Location = new System.Drawing.Point(340, 29);
            this.txtBoxEstado.Name = "txtBoxEstado";
            this.txtBoxEstado.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estado";
            // 
            // btnConsultaEstados
            // 
            this.btnConsultaEstados.Location = new System.Drawing.Point(479, 25);
            this.btnConsultaEstados.Name = "btnConsultaEstados";
            this.btnConsultaEstados.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaEstados.TabIndex = 0;
            this.btnConsultaEstados.Text = "Consulta";
            this.btnConsultaEstados.UseVisualStyleBackColor = true;
            this.btnConsultaEstados.Click += new System.EventHandler(this.btnConsultaEstados_Click);
            // 
            // FrmCadastroCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.btnConsultaEstados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxEstado);
            this.Controls.Add(this.txtBoxCidade);
            this.Controls.Add(this.txtBoxDDD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastroCidades";
            this.Controls.SetChildIndex(this.btnSalvar1, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.textBoxCodigo, 0);
            this.Controls.SetChildIndex(this.Sair, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtBoxDDD, 0);
            this.Controls.SetChildIndex(this.txtBoxCidade, 0);
            this.Controls.SetChildIndex(this.txtBoxEstado, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnConsultaEstados, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnConsultaEstados;
        public System.Windows.Forms.TextBox txtBoxEstado;
        public System.Windows.Forms.TextBox txtBoxDDD;
        public System.Windows.Forms.TextBox txtBoxCidade;
    }
}
