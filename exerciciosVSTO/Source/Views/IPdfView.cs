using System;
using WinFormsMvp;

namespace exerciciosVSTO.Source.Views
{
    public interface IPdfView : IView
    {
        event EventHandler SavePdf;
    }
}
