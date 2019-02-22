using System;
using WinFormsMvp;
using exerciciosVSTO.Source.Views;
using exerciciosVSTO.Source.Services;

namespace exerciciosVSTO
{
    public class PdfPresenter : Presenter<IPdfView>
    {
        private IWordService wordservice;

        public PdfPresenter(IPdfView view) : base(view)
        {
            View.SavePdf += SavePdf;
            wordservice = WordService.Instance;
        }

        private void SavePdf(object sender, EventArgs e)
        {
            wordservice.SavePdf();
        }
    }
}
