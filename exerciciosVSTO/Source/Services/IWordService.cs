using Microsoft.Office.Tools.Word;
using Word = Microsoft.Office.Interop.Word;

namespace exerciciosVSTO.Source.Services
{
    public interface IWordService
    {
        void CreatTable(int lines, int columns);        
        void AddQualification(string textContato, string textRepresentante);
        void AddField(string textField);
        void AddSpan(string textSpan);
        void InsertImage();
        void InvertCase();
        void SavePdf();        
        bool FindNext(string findWhat, bool mathCase);
        void ReplaceNext(string findWhat, string replaceNext, bool mathCase);
        int ReplaceAll(string findWhat, string replaceNext, bool mathCase);

    }
}
