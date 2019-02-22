using System;
using WinFormsMvp.Forms;
using exerciciosVSTO.Source.Views;

namespace exerciciosVSTO.Source.Views
{
    public partial class ImageView : MvpForm, IImageView
    {
        public ImageView()
        {
            InitializeComponent();
            this.Visible = false;
            InsertImage(null, EventArgs.Empty);
            Close();
        }

        public event EventHandler InsertImage;

    }
}
   