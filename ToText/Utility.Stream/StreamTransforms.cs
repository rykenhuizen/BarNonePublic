using System.IO;

namespace Utility.Stream
{
    public static class StreamTransforms
    {
        public static MemoryStream GenerateMemoryStreamFromFileStream(System.IO.Stream fs)
        {
            var stream = new MemoryStream();
            fs.CopyTo(stream);

            return stream;
        }
    }
}
