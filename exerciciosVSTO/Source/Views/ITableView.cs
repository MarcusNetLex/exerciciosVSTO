using System;
using WinFormsMvp;

namespace exerciciosVSTO.Source.Views
{
    public interface ITableView : IView
    {
        event EventHandler CreatTable;
        
        int NumberLines { get; set; }
              
        int NumberColumns { get; set; }
    }
}
