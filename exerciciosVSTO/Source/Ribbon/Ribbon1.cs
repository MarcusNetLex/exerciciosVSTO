using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Word;
using Word = Microsoft.Office.Interop.Word;
using exerciciosVSTO.Source.Views;
//----< Word Addin >---- 
using System.IO;
using Microsoft.Office.Tools.Ribbon;
//----</ Word Addin >---- 

namespace exerciciosVSTO
{
    public partial class Ribbon1
    {
        private SearchView findUserControl = new SearchView();
        private Microsoft.Office.Tools.CustomTaskPane findCustomTaskPane;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            findCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(findUserControl, "Find and Replace");
            findCustomTaskPane.Width = 440;
            Globals.ThisAddIn.Application.DocumentChange += Application_DocumentChange;
        }

        private void Application_DocumentChange()
        {
            if (Globals.ThisAddIn.Application.Documents.Count > 0)
            {
                var vstoDoc = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveDocument);
                vstoDoc.SelectionChange += VstoDoc_SelectionChange;

                var selectedText = Globals.ThisAddIn.Application.Selection.Range.Text;
                btn_InvertCase.Enabled = selectedText != "" && selectedText != null;
                btn_AddSpam.Enabled = selectedText != "" && selectedText != null;
            }
        }

        private void VstoDoc_SelectionChange(object sender, SelectionEventArgs e)
        {
            var selectedText = Globals.ThisAddIn.Application.Selection.Range.Text;
            btn_InvertCase.Enabled = selectedText != "" && selectedText != null;
            btn_AddSpam.Enabled = selectedText != "" && selectedText != null;

        }

        private void btnSave_as_PDF_Click(object sender, RibbonControlEventArgs e)
        {
            PdfView pdfview = new PdfView();
        }

        private void btn_Add_Image_Click(object sender, RibbonControlEventArgs e)
        {
            ImageView imageview = new ImageView();            
        }

        private void btn_CriarTabela_Click(object sender, RibbonControlEventArgs e)
        {
            TableView tabela = new TableView();
            tabela.Show();
        }

        private void btn_InvertCase_Click(object sender, RibbonControlEventArgs e)
        {
            CaseView caseview = new CaseView();
        }

        private void btn_FindReplace_Click(object sender, RibbonControlEventArgs e)
        {
            if (findCustomTaskPane.Visible) { findCustomTaskPane.Visible = false; }
            else findCustomTaskPane.Visible = true;
        }

        private void btn_AddField_Click(object sender, RibbonControlEventArgs e)
        {
            FieldView field = new FieldView();
            field.Show();
        }

        private void btn_AddSpam_Click(object sender, RibbonControlEventArgs e)
        {
            SpanView span = new SpanView();
            span.Show();
        }

        private void btn_AddQualification_Click(object sender, RibbonControlEventArgs e)
        {
            QualView qualification = new QualView();
            qualification.Show();
        }
    }
}

