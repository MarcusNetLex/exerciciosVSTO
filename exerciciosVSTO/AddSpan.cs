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
    public partial class AddSpan : Form
    {
        public AddSpan()
        {
            InitializeComponent();
        }

        private void btn_AddSpan_Click(object sender, EventArgs e)
        {
            RibbonPresenter.AddSpan(text_AddSpan.Text);
            Close();
        }
    }
}
