using System;
using WinFormsMvp.Forms;
using exerciciosVSTO.Source.Views;

namespace exerciciosVSTO
{
    public partial class SpanView : MvpForm, ISpanView
    {
        public SpanView()
        {
            InitializeComponent();
        }

        public string SpanText => text_AddSpan.Text;

        public event EventHandler AddSpan;

        private void btn_AddSpan_Click(object sender, EventArgs e)
        {
            AddSpan(sender, e);
            Close();
        }
    }
}
