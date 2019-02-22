using System;
using WinFormsMvp.Forms;
using exerciciosVSTO.Source.Views;

namespace exerciciosVSTO
{
    public partial class FieldView : MvpForm, IFieldView
    {
        public FieldView()
        {
            InitializeComponent();
        }

        public string FieldText { get => text_AddField.Text; }
        
        public event EventHandler AddField;

        private void btn_AddField_Click(object sender, EventArgs e)
        {
            AddField(sender, e);
            Close();
        }
    }
}
