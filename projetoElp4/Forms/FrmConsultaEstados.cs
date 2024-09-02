using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmConsultaEstados : projetoElp4.FrmConsulta
    {
        FrmCadastroEstados oFrmCadastroEstados;
        Estados oEstado;
        public FrmConsultaEstados()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(Object obj)
        {
            oEstado = (Estados)obj;
        }

        protected override void Incluir()
        {
            oFrmCadastroEstados.ConhecaObj(oEstado);
            oFrmCadastroEstados.LimpaTxt();
            oFrmCadastroEstados.ShowDialog();

        }
        protected override void Alterar()
        {
            oFrmCadastroEstados.ConhecaObj(oEstado);
            oFrmCadastroEstados.LimpaTxt();
            oFrmCadastroEstados.CarregaTxt();
            oFrmCadastroEstados.ShowDialog();

        }
        protected override void Excluir()
        {
            oFrmCadastroEstados.LimpaTxt();
            oFrmCadastroEstados.ConhecaObj(oEstado);
            oFrmCadastroEstados.CarregaTxt();
            oFrmCadastroEstados.BloqueiaTxt();
            oFrmCadastroEstados.ShowDialog();
            oFrmCadastroEstados.DesbloqueiaTxt();
        }

        public override void SetFrmCadastro(Object Frm)
        {
            oFrmCadastroEstados = (FrmCadastroEstados)Frm;
        }
    }
}
