using System;
using WinFormsMvp;

namespace exerciciosVSTO.Source.Views
{
    public interface IQualView : IView
    {
        event EventHandler AddQualification;

        string ContatText { get; }
        string RepresenterText { get; }
    }
}
