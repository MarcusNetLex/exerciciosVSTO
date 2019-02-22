using System;
using WinFormsMvp;
using exerciciosVSTO.Source.Views;
using exerciciosVSTO.Source.Services;

namespace exerciciosVSTO
{
    public class FieldPresenter : Presenter<IFieldView>
    {
        private IWordService wordservice;

        public FieldPresenter(IFieldView view) : base(view)
        {
            View.AddField += View_AddField;
            wordservice = WordService.Instance;
        }

        private void View_AddField(object sender, EventArgs e)
        {
            wordservice.AddField(View.FieldText);
        }
    }
}
