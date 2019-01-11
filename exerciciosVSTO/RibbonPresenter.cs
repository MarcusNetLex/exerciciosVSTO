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

        public static void salvarComoPDF(){
           
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
        }

        public static void inserirImagem() {
            Word.Dialog dlg = Globals.ThisAddIn.Application.Dialogs[Word.WdWordDialog.wdDialogInsertPicture];
            dlg.Show();
        }
                
    }
}
