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
    public partial class Qualificacao : Form
    {
        public Qualificacao()
        {
            InitializeComponent();
        }

        private void btn_AddQualificacao_Click(object sender, EventArgs e)
        {
            RibbonPresenter.AddQualificacao(text_Contato.Text, text_Representante.Text);
            Close();
        }
    }
}
