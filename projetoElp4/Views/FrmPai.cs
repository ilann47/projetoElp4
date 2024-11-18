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
    public partial class FrmPai : Form
    {
        public FrmPai()
        {
            InitializeComponent();
        }

        public virtual void ConhecaObj(Object obj, Object Controller)
        {

        }

        protected void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
