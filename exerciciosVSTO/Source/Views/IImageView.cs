using System;
using WinFormsMvp;

namespace exerciciosVSTO.Source.Views
{
    public interface IImageView : IView
    {
        event EventHandler InsertImage;
    }
}

