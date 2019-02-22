using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMvp.Forms;
using exerciciosVSTO.Source.Views;


namespace exerciciosVSTO
{
    public partial class SearchView : MvpUserControl, ISearchView
    {
        public SearchView()
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
        public event EventHandler ReplaceNext;
        public event EventHandler FindNext;
        public event EventHandler ReplaceAll;
        public event EventHandler FindWhat;
                             
        public bool PanelFind { set => panel_Find.Enabled = value; }
        public bool MatchCase => checkbox_MatchCase.Checked;
        public string FindWhatText { get => text_FindWhat.Text; set => text_FindWhat.Text = value; }
        public string ReplaceText { get => text_ReplaceFor.Text; set => text_ReplaceFor.Text = value; }

        private void bnt_FindNext_Click(object sender, EventArgs e)
        {
            FindNext(sender, e);
        }
        
        private void btn_Replace_Click(object sender, EventArgs e)
        {
            ReplaceNext(sender, e);            
        }

        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            ReplaceAll(sender, e);            
        }

        private void text_FindWhat_TextChanged(object sender, EventArgs e)
        {
            FindWhat(sender, e);            
        }

        public void TextMessageBox(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
