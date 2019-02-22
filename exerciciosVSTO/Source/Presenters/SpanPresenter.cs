using System;
using WinFormsMvp;
using exerciciosVSTO.Source.Views;
using exerciciosVSTO.Source.Services;

namespace exerciciosVSTO
{
    public class SpanPresenter : Presenter<ISpanView>
    {
        private IWordService wordservice;

        public SpanPresenter(ISpanView view) : base(view)
        {
            View.AddSpan += View_AddSpan;
            wordservice = WordService.Instance;
        }

        private void View_AddSpan(object sender, EventArgs e)
        {
            wordservice.AddSpan(View.SpanText);
        }
    }
}
