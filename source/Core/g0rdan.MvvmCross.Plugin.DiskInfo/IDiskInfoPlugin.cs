using System;
namespace g0rdan.MvvmCross.Plugin.DiskInfo
{
    public interface IDiskInfoPlugin
    {
        decimal GetTotalSpace (DeviceType deviceType = DeviceType.Inner, MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2);
        decimal GetFreeSpace (DeviceType deviceType = DeviceType.Inner, MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2);
    }
}

