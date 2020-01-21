using System.IO;
using Utility.Stream;

namespace Extractor.PDF
{
    public class Extractor
    {
        public string Extract(MemoryStream ms)
        {
            var parser = new MemoryStreamPdfToText();

            var text = parser.ParseStream(ms);

            return text;
        }
    }
}
