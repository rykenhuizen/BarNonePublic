namespace Utility.Stream
{
    public interface IStreamToText<in T> where T: System.IO.Stream
    {
        string ParseStream(T document);
    }
}
