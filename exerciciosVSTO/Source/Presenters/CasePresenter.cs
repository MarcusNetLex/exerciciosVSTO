using System;
using WinFormsMvp;
using exerciciosVSTO.Source.Views;
using exerciciosVSTO.Source.Services;

namespace exerciciosVSTO
{
    public class CasePresenter : Presenter<ICaseView>
    {
        private IWordService wordservice;

        public CasePresenter(ICaseView view) : base(view)
        {
            View.InvertCase += InvertCase;
            wordservice = WordService.Instance;
        }

        private void InvertCase(object sender, EventArgs e)
        {
            wordservice.InvertCase();
        }
    }
}