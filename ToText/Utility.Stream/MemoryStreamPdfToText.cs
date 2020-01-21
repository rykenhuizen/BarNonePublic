using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Utility.Stream
{
    public class MemoryStreamPdfToText : IStreamToText<MemoryStream>
    {
        public string ParseStream(MemoryStream stream)
        {
            var text = "";
            using (var reader = new PdfReader(stream.ToArray()))
            {
                for (var page = 1; page <= reader.NumberOfPages; page++)
                {
                    text += PdfTextExtractor.GetTextFromPage(reader, page);
                }
            }
            return text;
        }
    }
}
