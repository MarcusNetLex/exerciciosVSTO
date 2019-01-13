using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciciosVSTO
{
    public partial class CreateTable : Form
    {
        public CreateTable()
        {
            InitializeComponent();
        }             

        private void numLinhas_ValueChanged(object sender, EventArgs e)
        {
            numLinhas.Maximum = 10;
            numLinhas.Minimum = 1;
        }

        private void numColunas_ValueChanged(object sender, EventArgs e)
        {
            numColunas.Maximum = 10;
            numColunas.Minimum = 1;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            int linhas = Convert.ToInt32(numLinhas.Value);
            int colunas = Convert.ToInt32(numColunas.Value);
            RibbonPresenter.CriarTabela(linhas, colunas);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
