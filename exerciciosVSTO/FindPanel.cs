using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciciosVSTO
{
    public partial class FindPanel : UserControl
    {
        public FindPanel()
        {
            InitializeComponent();            
        }

        private void bnt_FindNext_Click(object sender, EventArgs e)
        {
            FindPanelPresenter.FindNext(text_FindWhat.Text, checkbox_MatchCase.Checked, "Text not found");
        }

        private void panel_Find_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Range.Text != "" && 
                Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Range.Text != null) {
                FindPanelPresenter.ReplaceNext(text_ReplaceFor.Text, text_FindWhat.Text, 
                    checkbox_MatchCase.Checked, "No more occurrences of the text");
            } else FindPanelPresenter.FindNext(text_FindWhat.Text, checkbox_MatchCase.Checked, "Text not found");
        }

        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            FindPanelPresenter.ReplaceAll(text_FindWhat.Text, text_ReplaceFor.Text, checkbox_MatchCase.Checked);
        }

        private void text_FindWhat_TextChanged(object sender, EventArgs e)
        {
            if (text_FindWhat.Text.Length > 0) { panel_Find.Enabled = true; }
            else panel_Find.Enabled = false;
        }
    }
}
