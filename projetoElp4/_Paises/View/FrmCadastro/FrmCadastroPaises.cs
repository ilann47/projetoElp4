using projetoElp4;
using projetoElp4._Paises.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmCadastroPaises : projetoElp4.FrmCadastro
    {
        Paises oPais;
        PaisesController oPaisController;
        public FrmCadastroPaises()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj, Object Controller)
        {
            oPais = (Paises) obj;
            oPaisController = (PaisesController)Controller;
        }
        public override void CarregaTxt()
        {
            this.txtPais.Text = oPais?.Pais;
            this.txtMoeda.Text = oPais?.Moeda;
            this.txtDDI.Text = oPais?.Ddi;
            this.txtSigla.Text = oPais?.Sigla;
        }
        public override void LimpaTxt()
        {
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtDDI.Clear();
            this.txtMoeda.Clear();
        }
        public override void BloqueiaTxt()
        {
            this.txtPais.Enabled = false;
            this.txtSigla.Enabled = false;
            this.txtMoeda.Enabled = false;
            this.txtDDI.Enabled = false;
        }   
        public override void DesbloqueiaTxt()
        {
            this.txtPais.Enabled = true;
            this.txtSigla.Enabled = true;
            this.txtMoeda.Enabled = true;
            this.txtDDI.Enabled = true;
        }
        public override void Salvar()
        {
            base.Salvar();
            oPais.Codigo = 0;
            oPais.Pais = this.txtPais.Text;
            oPais.Sigla = this.txtSigla.Text;
            oPais.Ddi = this.txtDDI.Text;
            oPais.Moeda = this.txtMoeda.Text;
        }


    }
    


}
