using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoElp4
{
    public partial class FrmPrincipal : Form
    {
        Interfaces aInter;
        public FrmPrincipal()
        {
            aInter = new Interfaces();
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados();

        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades();

        }
    }
}
