using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;



namespace exerciciosVSTO
{
    class RibbonPresenter
    {
        static Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

        public static void SalvarComoPDF(){
           
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
        }

        public static void InserirImagem() {
            Word.Dialog dlg = Globals.ThisAddIn.Application.Dialogs[Word.WdWordDialog.wdDialogInsertPicture];
            dlg.Show();
        }

        public static void CriarTabela(int linhas, int colunas) {

            Word.Selection sec = Globals.ThisAddIn.Application.Selection;
            Word.Range selectTable = Globals.ThisAddIn.Application.ActiveDocument.Range(sec.Start, sec.End);
            Word.Table table = Globals.ThisAddIn.Application.ActiveDocument.Tables.Add(selectTable, linhas, colunas);
            table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                      
        }

        public static void InvertCase()
        {
            Word.Selection sec = Globals.ThisAddIn.Application.Selection;
            Word.Range invertCase = Globals.ThisAddIn.Application.ActiveDocument.Range(sec.Start, sec.End);
            int aux = sec.Start;
            while(aux <= sec.End)
            {
                if(invertCase(aux, aux))
                {

                }

            }

            
            

        }
                
    }
}
