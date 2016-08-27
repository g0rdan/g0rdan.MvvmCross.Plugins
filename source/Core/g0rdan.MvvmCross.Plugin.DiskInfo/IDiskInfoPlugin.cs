using System;
namespace g0rdan.MvvmCross.Plugin.DiskInfo
{
    public interface IDiskInfoPlugin
    {
        decimal GetTotalSpace (StorageType storageType = StorageType.Inner, MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2);
        decimal GetFreeSpace (StorageType storageType = StorageType.Inner, MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2);
    }
}

