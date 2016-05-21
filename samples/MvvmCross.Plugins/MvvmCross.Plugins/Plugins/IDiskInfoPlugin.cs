using System;
namespace g0rdan.MvvmCross.Plugins
{
    public interface IDiskInfoPlugin
    {
        decimal GetTotalSpace (MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2);
        decimal GetFreeSpace (MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2);
    }
}

