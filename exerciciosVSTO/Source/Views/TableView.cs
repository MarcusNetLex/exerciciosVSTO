using System;
using WinFormsMvp.Forms;
using exerciciosVSTO.Source.Views;

namespace exerciciosVSTO
{
    public partial class TableView : MvpForm, ITableView
    {
        public TableView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            OnViewLoding();

            base.OnLoad(e);
        }

        protected virtual void OnViewLoding()
        {
            ViewLoading?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ViewLoading;
        public event EventHandler CreatTable;
                
        private void numLinhas_ValueChanged(object sender, EventArgs e)
        {
            numLinhas.Maximum = 10;
            numLinhas.Minimum = 1;
        }

        private void numColunas_ValueChanged(object sender, EventArgs e)
        {
            numColunas.Maximum = 10;
            numColunas.Minimum = 1;
        }

        public int NumberLines 
        {
            get 
            {
                return Convert.ToInt32(this.numLinhas.Text);
            }
            set 
            {
                this.numLinhas.Text = Convert.ToString(value);
            }
        }

        public int NumberColumns 
        {
            get {
                return Convert.ToInt32(this.numColunas.Text);
            }
            set {
                this.numColunas.Text = Convert.ToString(value);
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CreatTable(sender, e);
            Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
