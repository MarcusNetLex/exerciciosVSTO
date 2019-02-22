using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMvp;

namespace exerciciosVSTO.Source.Views
{
    public interface ISearchView : IView
    {
        event EventHandler ReplaceNext;
        event EventHandler FindNext;
        event EventHandler ReplaceAll;
        event EventHandler FindWhat;

        string FindWhatText { get; set; }
        string ReplaceText { get; set; }
        bool MatchCase { get; }
        bool PanelFind { set; }
        void TextMessageBox(string msg);
    }
}
