using System;
using WinFormsMvp;
using exerciciosVSTO.Source.Views;
using exerciciosVSTO.Source.Services;

namespace exerciciosVSTO
{
    public class SearchPresenter : Presenter<ISearchView>
    {
        private IWordService wordservice;

        public SearchPresenter(ISearchView view) : base(view)
        {
            View.FindNext += FindNext;
            View.ReplaceNext += ReplaceNext;
            View.ReplaceAll += ReplaceAll;
            View.FindWhat += FindWhat;

            wordservice = WordService.Instance;

        }
        
        public void FindNext(object sender, EventArgs e)
        {
            bool msg = wordservice.FindNext(View.FindWhatText, View.MatchCase);
            if (!msg) { View.TextMessageBox("Text not found"); }
        }
        
        public void ReplaceNext(object sender, EventArgs e)
        {
            wordservice.ReplaceNext(View.FindWhatText, View.ReplaceText, View.MatchCase);
        }
        
        public void ReplaceAll(object sender, EventArgs e)
        {
            int qnt = wordservice.ReplaceAll(View.FindWhatText, View.ReplaceText, View.MatchCase);
            View.TextMessageBox( qnt + " substitutions were done");           
        }      

        public void FindWhat(object sender, EventArgs e)
        {
            if (View.FindWhatText.Length > 0) { View.PanelFind = true; }
            else View.PanelFind = false;
        }

    }

}

