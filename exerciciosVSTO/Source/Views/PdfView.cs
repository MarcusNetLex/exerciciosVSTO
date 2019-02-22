using System;
using WinFormsMvp.Forms;
using exerciciosVSTO.Source.Views;

namespace exerciciosVSTO.Source.Views
{
    public partial class PdfView : MvpForm, IPdfView
    {
        public PdfView()
        {
            InitializeComponent();
            this.Visible = false;
            SavePdf(null, EventArgs.Empty);
            Close();
        }

        public event EventHandler SavePdf;

    }
}
