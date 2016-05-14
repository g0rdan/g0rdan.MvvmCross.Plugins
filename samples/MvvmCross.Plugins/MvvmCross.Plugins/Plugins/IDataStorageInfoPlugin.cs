using System;
namespace g0rdan.MvvmCross.Plugins
{
    public interface IDataStorageInfoPlugin
    {
        decimal GetTotalSpace (MemorySizeType mSizeType = MemorySizeType.Bytes);
        decimal GetFreeSpace (MemorySizeType mSizeType = MemorySizeType.Bytes);
    }
}

