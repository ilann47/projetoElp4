﻿using projetoElp4;
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
        Paises oPais;
        Estados oEstado;
        Cidades aCidade;
        Fornecedores oFornecedor;
        public FrmPrincipal()
        {
            aInter = new Interfaces();
            oPais = new Paises();
            oEstado = new Estados();
            aCidade = new Cidades();
            oFornecedor = new Fornecedores();
            InitializeComponent();
        }


        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais, null);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, null);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(aCidade, null);

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaFornecedores(oFornecedor, null);
        }
    }
}
