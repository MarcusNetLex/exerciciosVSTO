using System;
using WinFormsMvp;
using exerciciosVSTO.Source.Views;
using exerciciosVSTO.Source.Services;

namespace exerciciosVSTO
{
    public class ImagePresenter : Presenter<IImageView>
    {
        private IWordService wordservice;

        public ImagePresenter(IImageView view) : base(view)
        {
            View.InsertImage += InsertImage;
            wordservice = WordService.Instance;
        }

        private void InsertImage(object sender, EventArgs e)
        {
            wordservice.InsertImage();
        }
    }
}