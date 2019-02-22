using System;
using WinFormsMvp;

namespace exerciciosVSTO.Source.Views
{
    public interface ICaseView : IView
    {
        event EventHandler InvertCase;
    }
}