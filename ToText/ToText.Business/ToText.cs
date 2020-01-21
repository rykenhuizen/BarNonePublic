using System.IO;
using Utility.Stream;

namespace ToText.Business
{
    public class ToText
    {
        public static string GetText(string fileName)
        {
           //TODO :check the format and use the right extractor
            var pdfExtracator = new Extractor.PDF.Extractor();

            var ms = StreamTransforms.GenerateMemoryStreamFromFileStream(File.OpenRead(fileName));

            return pdfExtracator.Extract(ms);

        }
    }
}
