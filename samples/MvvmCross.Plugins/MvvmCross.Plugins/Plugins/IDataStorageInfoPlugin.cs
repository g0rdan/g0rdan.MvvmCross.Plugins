using System;
namespace g0rdan.MvvmCross.Plugins
{
    public interface IDataStorageInfoPlugin
    {
        ulong GetTotalSpace (MemorySizeType mSizeType);
        ulong GetFreeSpace (MemorySizeType mSizeType);
    }
}

