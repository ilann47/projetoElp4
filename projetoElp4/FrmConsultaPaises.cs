using projetoElp4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmConsultaPaises : projetoElp4.FrmConsulta
    {
        FrmCadastroPaises oFrmCadastroPaises;
        Paises oPais;
        public FrmConsultaPaises()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oPais = (Paises)obj;
        }

        protected override void Incluir()
        {
            oFrmCadastroPaises.ConhecaObj(oPais);
            //oFrmCadastroPaises.LimpaTxt();
            oFrmCadastroPaises.ShowDialog();

        }
        protected override void Alterar()
        {
            oFrmCadastroPaises.ConhecaObj(oPais);
            //oFrmCadastroPaises.LimpaTxt();
            oFrmCadastroPaises.CarregaTxt();
            oFrmCadastroPaises.ShowDialog();

        }
        protected override void Excluir()
        {
            //oFrmCadastroPaises.LimpaTxt();
            oFrmCadastroPaises.ConhecaObj(oPais);
            oFrmCadastroPaises.CarregaTxt();
            oFrmCadastroPaises.BloqueiaTxt();
            oFrmCadastroPaises.ShowDialog();
            oFrmCadastroPaises.DesbloqueiaTxt();
        }

        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroPaises = (FrmCadastroPaises)Frm;
        }

    }
}
