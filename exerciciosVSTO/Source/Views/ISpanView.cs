using System;
using WinFormsMvp;

namespace exerciciosVSTO.Source.Views
{
    public interface ISpanView : IView
    {
        event EventHandler AddSpan;

        string SpanText { get; }
    }
}
