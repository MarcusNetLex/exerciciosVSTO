using System;
using WinFormsMvp;

namespace exerciciosVSTO.Source.Views
{
    public interface IFieldView : IView
    {
        event EventHandler AddField;

        string FieldText { get; }
    }
}
