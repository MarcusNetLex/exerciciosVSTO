using System;
using WinFormsMvp;
using exerciciosVSTO.Source.Views;
using exerciciosVSTO.Source.Services;

namespace exerciciosVSTO
{
    public class QualPresenter : Presenter<IQualView>
    {
        private IWordService wordservice;

        public QualPresenter(IQualView view) : base(view)
        {
            View.AddQualification += View_AddQualification;
            wordservice = WordService.Instance;
        }
        
        private void View_AddQualification(object sender, EventArgs e)
        {
            wordservice.AddQualification(View.ContatText, View.RepresenterText);
        }        
       
    }
}
