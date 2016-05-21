using System;
namespace g0rdan.MvvmCross.Plugin.DiskInfo
{
    public interface IDiskInfoPlugin
    {
        decimal GetTotalSpace (MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2);
        decimal GetFreeSpace (MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2);
    }
}

