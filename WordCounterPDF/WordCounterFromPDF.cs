using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WordCounterPDF
{
    class WordCounterFromPDF
    {
        static void Main(string[] args)
        {
            //leximi i pathut te fajllit per pdf.
            string inputFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "aff.pdf");
            string T = ExtractAllTextFromPdf(inputFile);
            int I = GetCountWordFromString(T);

            // nje mesatate e leximit ne bote per wpm
            double wpm = 200.0;

            Console.ReadLine();
            Console.WriteLine("There are {0} words in page",GetCountWordFromString(T));
            Console.ReadLine();

            Console.WriteLine("Document length: {0} minutes ", GetCountWordFromString(T) / wpm);
            Console.ReadLine();
        }

        //nxirrja e tekstit prej pdf-it
        private static string ExtractAllTextFromPdf(string inputFile)
        {
            if (string.IsNullOrEmpty(inputFile))
                throw new ArgumentNullException("inputFile");
            if (!System.IO.File.Exists(inputFile))
                throw new System.IO.FileNotFoundException("Cannot found input file", inputFile);

            using (FileStream Sr = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(Sr);
                StringBuilder buf = new StringBuilder();

                for (int i= 1; i <= reader.NumberOfPages; i++)
                {
                    buf.AppendLine(PdfTextExtractor.GetTextFromPage(reader, i));
                }
                return buf.ToString();
            }
        }
        // numrimi i fjaleve ne tekst
        public static int GetCountWordFromString(string text)
        {
          
            if (string.IsNullOrEmpty(text))
            
                return 0;
            
                return System.Text.RegularExpressions.Regex.Matches(text, "\\S+").Count;
            




        }
   

        
    }
}
