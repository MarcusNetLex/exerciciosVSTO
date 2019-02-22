using System;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows.Forms;

namespace exerciciosVSTO.Source.Services
{
    class WordService : IWordService
    {
        private static readonly Lazy<IWordService> instance =
            new Lazy<IWordService>(() => new WordService());

        public static IWordService Instance {
            get {
                return instance.Value;
            }
        }

        public void CreatTable(int lines, int columns)
        {
            Word.Range selectTable = Globals.ThisAddIn.Application.Selection.Range;
            Word.Table table = Globals.ThisAddIn.Application.ActiveDocument.Tables.Add(selectTable, lines, columns);
            table.Borders.Enable = 1;
        }

        private bool FindNext(string textFind, bool mathCase, Word.WdFindWrap isRotation)
        {
            var sec = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Range;
            sec.Find.ClearFormatting();
            sec.Find.MatchCase = mathCase;


            sec.Find.Forward = true;
            sec.Find.Wrap = isRotation;
            if (sec.Find.Execute(textFind))
            {
                sec.Select();
                return true;
            }
            else return false;
        }

        public bool FindNext(string textFind, bool mathCase)
        {
            return FindNext(textFind, mathCase, Word.WdFindWrap.wdFindContinue);
        }

        private void ReplaceNext(string findWhat, string textReplace, bool matchCase, Word.WdFindWrap isRotation)
        {
            var sec = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Range;
            if (sec.Text != null && ((matchCase && sec.Text == findWhat) ||
                    (!matchCase && (sec.Text.ToUpper() == findWhat.ToUpper()))))
            {
                sec.Text = textReplace;
                sec.Start = sec.End;
                sec.Select();
                FindNext(findWhat, matchCase, isRotation);
            }
            else FindNext(findWhat, matchCase, isRotation);

        }

        public void ReplaceNext(string findWhat, string textReplace, bool matchCase)
        {
            ReplaceNext(findWhat, textReplace, matchCase, Word.WdFindWrap.wdFindContinue);
        }

        public int ReplaceAll(string findWhat, string replaceFor, bool matchCase)
        {
            int cont = 0;
            Globals.ThisAddIn.Application.ActiveDocument.Range(0, 0).Select();

            while (FindNext(findWhat, matchCase, Word.WdFindWrap.wdFindStop))
            {
                var range = Globals.ThisAddIn.Application.ActiveDocument.Application.Selection.Range;
                cont++;
                range.Text = replaceFor;
                range.Start = range.End;
                range.Select();
            }

            return cont;

        }

        public void AddQualification(string textContato, string textRepresentante)
        {

            var sec = Globals.ThisAddIn.Application.Selection.Range;

            sec.InsertAfter(string.Format("{{{0}.RazaoSocial formatar \"caixaalta\"}}, {{{0}.Tipo}}, inscrit["
                + textContato + ".Genero = \"masculino\"o]" +
                "[{0}.Genero = \"feminino\"a] no CNPJ sob o n. {{{0}.CNPJ}}, sediad" +
                "[{0}.Genero = \"masculino\"o][{0}.Genero = \"feminino\"a] na {{" + textContato +
                ".Logradouro}}, {{{0}.LogradouroNumeroComp}}[{0}.LogradouroNumeroComp = \"n.\" ]" +
                "{{{0}.LogradouroNumero}}, [{0}.LogradouroComplemento != \"\"{{" + textContato +
                ".LogradouroComplemento}}, ]bairro {{{0}.Bairro}}, {{{0}.Municipio}}/{{" + textContato +
                ".Estado}}, {{{0}.Pais}}, [{0}.Pais = \"Brasil\"CEP] [" + textContato +
                ".Pais != \"Brasil\"Código Postal]: {{{0}.CEP}}, representad[" + textContato +
                ".Genero = \"masculino\"o][{0}.Genero = \"feminino\"a] por " +
                "[repetir numRep pontuacao “, | e |.”{{{1}.Nome Formatar \"caixaalta\"}}, {{" +
                textRepresentante + ".Nacionalidade}}, {{{1}.EstadoCivil}}, {{" + textRepresentante +
                ".Profissao}}, portador[{1}.Sexo = \"feminino\"a] d[" +
                textRepresentante + ".IdentidadeTipo = \"Passaporte\"o][" + textRepresentante +
                ".IdentidadeTipo != \"Passaporte\"a] {{{1}.IdentidadeTipo}} n. {{" +
                textRepresentante + ".IdentidadeNumero}} – {{{1}.IdentidadeOrgaoEmissor Formatar \"caixaalta\"}}" +
                ", inscrit[{1}.Sexo = \"masculino\"o][{1}.Sexo = \"feminino\"a] " +
                "no CPF sob o n. {{{1}.CPF}}, residente e domiciliad" +
                "[{1}.Sexo = \"masculino\"o][{1}.Sexo = \"feminino\"a] na " +
                "{{{1}.Logradouro}}, {{{1}.LogradouroNumeroComp}}" +
                "[{1}.LogradouroNumeroComp = \"n.\" ]{{{1}.LogradouroNumero}}, [" +
                textRepresentante + ".LogradouroComplemento != \"\"{{{1}.LogradouroComplemento}}, ]" +
                "bairro {{{1}.Bairro}}, {{{1}.Municipio}}/{{" + textRepresentante +
                ".Estado}}, {{{1}.Pais}}, [{1}.Pais = \"Brasil\"CEP][" +
                textRepresentante + ".Pais != \"Brasil\"Código Postal]: {{{1}.CEP}}{{sinal}}]", textContato, textRepresentante));

            var auxStart = sec.Start;
            var auxEnd = sec.End;

            sec.End = sec.Start + textContato.Length + 35; sec.Font.Bold = 1;
            sec.Start = sec.End + 19 + textContato.Length; sec.End = sec.Start + 21 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 3; sec.End = sec.Start + 20 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 36 + textContato.Length; sec.End = sec.Start + 21 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 3; sec.End = sec.Start + 20 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 45 + 2 * textContato.Length; sec.End = sec.Start + 28 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 24 + textContato.Length; sec.End = sec.Start + 28 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 79 + 5 * textContato.Length; sec.End = sec.Start + 16 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 6; sec.End = sec.Start + 17 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 36 + textContato.Length; sec.End = sec.Start + 21 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 3; sec.End = sec.Start + 20 + textContato.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 8; sec.End = sec.Start + 35;
            sec.Font.Subscript = 1;
            sec.Start = sec.End; sec.End = sec.Start + 28 + textRepresentante.Length;
            sec.Font.Bold = 1;
            sec.Start = sec.End + 59 + 3 * textRepresentante.Length; sec.End = sec.Start + 18 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 5; sec.End = sec.Start + 30 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 3; sec.End = sec.Start + 31 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 102 + 3 * textRepresentante.Length; sec.End = sec.Start + 19 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 3; sec.End = sec.Start + 18 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 50 + textRepresentante.Length; sec.End = sec.Start + 19 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 3; sec.End = sec.Start + 18 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 45 + 2 * textRepresentante.Length; sec.End = sec.Start + 28 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 24 + textRepresentante.Length; sec.End = sec.Start + 28 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 79 + 5 * textRepresentante.Length; sec.End = sec.Start + 16 + textRepresentante.Length;
            sec.Font.Subscript = 1;
            sec.Start = sec.End + 5; sec.End = sec.Start + 17 + textRepresentante.Length;
            sec.Font.Subscript = 1;

        }

        public void AddField(string textField)
        {
            string fieldText = textField;
            Globals.ThisAddIn.Application.Selection.Text = "{" + fieldText + "}";
        }

        public void AddSpan(string textSpan)
        {
            Word.Selection sec = Globals.ThisAddIn.Application.Selection;
            sec.Text = "[" + textSpan + Globals.ThisAddIn.Application.Selection.Text + "]";
            Globals.ThisAddIn.Application.ActiveDocument.Range(sec.Start + 1, textSpan.Length + sec.Start + 1).Font.Subscript = 1;
        }

        public void SavePdf()
        {


            string sfileName_Document = Globals.ThisAddIn.Application.ActiveDocument.Name;
            string sPath = Globals.ThisAddIn.Application.ActiveDocument.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            try
            {
                FileInfo file = new FileInfo(sFullpath_pdf);
                int i = 1;

                while (file.Exists)
                {
                    sFullpath_pdf = sPath + "\\" + sfileName_Document + "(" + i + ").pdf";
                    i++;
                    file = new FileInfo(sFullpath_pdf);
                }
                Globals.ThisAddIn.Application.ActiveDocument.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
            }
            catch
            {
                MessageBox.Show("This document should be save first!");    

            }


        }


        public void InsertImage()
        {
            Word.Dialog dlg = Globals.ThisAddIn.Application.Dialogs[Word.WdWordDialog.wdDialogInsertPicture];
            dlg.Show();
        }
        public void InvertCase()
        {
            var sec = Globals.ThisAddIn.Application.Selection;
            var range = Globals.ThisAddIn.Application.ActiveDocument;

            for (int i = sec.Range.Start; i < sec.Range.End; i++)
            {
                if (range.Range(i, i + 1).Case == Word.WdCharacterCase.wdLowerCase)
                {
                    range.Range(i, i + 1).Case = Word.WdCharacterCase.wdUpperCase;
                }
                else range.Range(i, i + 1).Case = Word.WdCharacterCase.wdLowerCase;
            }
        }
    }
}
