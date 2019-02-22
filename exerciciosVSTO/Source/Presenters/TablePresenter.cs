using System;
using WinFormsMvp;
using exerciciosVSTO.Source.Views;
using exerciciosVSTO.Source.Services;

namespace exerciciosVSTO
{
    public class TablePresenter : Presenter<ITableView>
    {
        private IWordService wordservice;
        
        public TablePresenter(ITableView view) : base(view)
        {
            View.CreatTable += View_CriarTabela;
            wordservice = WordService.Instance;
        }

        private void View_CriarTabela(object sender, EventArgs e)
        {
            wordservice.CreatTable(View.NumberLines, View.NumberColumns);                
        }

    }
}
