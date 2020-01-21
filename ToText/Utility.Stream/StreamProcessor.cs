using System.Collections.Generic;
using System.Linq;

namespace Utility.Stream
{
    public class StreamProcessor<T> where T : System.IO.Stream
    {
        private readonly IList<T> _documents;
        private readonly IStreamToText<T> _parser;

        public StreamProcessor(IList<T> documents, IStreamToText<T> parser)
        {
            _documents = documents;
            _parser = parser;
        }

        public IList<string> GetTextFromStream()
        {
            //Document to text
            var texts = _documents.Select(document => _parser.ParseStream(document)).ToList();
            return texts;
        }
    }
}
