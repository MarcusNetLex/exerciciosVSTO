using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace exerciciosVSTO
{
    class FindPanelPresenter
    {


        public static void FindNext(string textFind, bool matchCase, string msg)
        {
            object findText = textFind;
            Word.Selection sec = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
            Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.ClearFormatting();
            Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.MatchCase = matchCase;

            if (!((matchCase && Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text == textFind) ||
                (!matchCase && (Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text.ToUpper() == textFind ||
                Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text.ToLower() == textFind))))
            {
                if (sec.Start == 0) Globals.ThisAddIn.Application.ActiveDocument.Range(sec.Start, sec.Start).Select();
                else Globals.ThisAddIn.Application.ActiveDocument.Range(sec.Start-1, sec.Start-1).Select();
            }

            Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Forward = true;

            Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Execute(ref findText);

            if (!Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Found)
            {
                Globals.ThisAddIn.Application.ActiveDocument.Range(0, 0).Select();
                Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Execute(ref findText);
                if (!Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Found) {
                    if (msg != "ignore") { MessageBox.Show(msg); }
                }
            }

        }

        public static void FindNext(string textFind, bool matchCase)
        {
            object findText = textFind;
            Word.Selection sec = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection;
            Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.ClearFormatting();
            Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.MatchCase = matchCase;

            if (!((matchCase && Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text == textFind) ||
                (!matchCase && (Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text.ToUpper() == textFind ||
                Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text.ToLower() == textFind))))
            {
                if (sec.Start == 0) Globals.ThisAddIn.Application.ActiveDocument.Range(sec.Start, sec.Start).Select();
                else Globals.ThisAddIn.Application.ActiveDocument.Range(sec.Start - 1, sec.Start - 1).Select();
            }

            Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Forward = true;

            Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Execute(ref findText);

            if (!Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Found)
            {
                Globals.ThisAddIn.Application.ActiveDocument.Range(0, 0).Select();
                Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Find.Execute(ref findText);                
            }

        }

        public static void ReplaceNext(string textReplace, string textFind, bool matchCase, string msg)
        {
            object replaceText = textReplace;
            object findText = textFind;
            
            if ((matchCase && Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text == textFind) || 
                (!matchCase && (Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text.ToUpper() == textFind ||
                Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text.ToLower() == textFind)))
            {
                Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Text = textReplace;
                FindNext(textFind, matchCase, msg);
            }
            else FindNext(textFind, matchCase, msg);

        }

        public static void ReplaceAll(string textFind, string textReplace, bool matchCase)
        {
            string findText = textFind;
            string replaceText = textReplace;
            int cont = 0;
            FindNext(findText, matchCase, "Text not found");
            while (Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Range.Text != "" &&
                Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Range.Text != null) {
                cont++;
                ReplaceNext(replaceText, findText, matchCase, cont + " replacements were done");                
                FindNext(findText, matchCase);
            }
            
        }
    }
}

