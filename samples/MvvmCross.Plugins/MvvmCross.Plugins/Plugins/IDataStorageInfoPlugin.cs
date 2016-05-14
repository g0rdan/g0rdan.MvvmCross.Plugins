using System;
namespace g0rdan.MvvmCross.Plugins
{
    public interface IDataStorageInfoPlugin
    {
        decimal GetTotalSpace (MemorySizeType mSizeType);
        decimal GetFreeSpace (MemorySizeType mSizeType);
    }
}

