namespace CompressionStocking
{
    public interface ICompressionCtrl : ITimer
    {
        void Compress();
        void Decompress();
    }
}