using System;
using WinFormsMvp.Forms;
using exerciciosVSTO.Source.Views;

namespace exerciciosVSTO.Source.Views
{
    public partial class CaseView : MvpForm, ICaseView
    {
        public CaseView()
        {
            InitializeComponent();
            this.Visible = false;
            InvertCase(null, EventArgs.Empty);
            Close();
        }

        public event EventHandler InvertCase;

    }
}
