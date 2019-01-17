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
    public partial class AddField : Form
    {
        public AddField()
        {
            InitializeComponent();
        }

        private void btn_AddField_Click(object sender, EventArgs e)
        {
            RibbonPresenter.AddField(text_AddField.Text);
            Close();
        }
    }
}
