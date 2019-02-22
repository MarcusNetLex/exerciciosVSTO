using System;
using WinFormsMvp.Forms;
using exerciciosVSTO.Source.Views;

namespace exerciciosVSTO
{
    public partial class QualView : MvpForm, IQualView
    {
        public QualView()
        {
            InitializeComponent();
        }

        public string ContatText => text_Contato.Text;
        public string RepresenterText => text_Representante.Text;

        public event EventHandler AddQualification;

        private void btn_AddQualificacao_Click(object sender, EventArgs e)
        {
            AddQualification(sender, e);              
            Close();
        }
    }
}
