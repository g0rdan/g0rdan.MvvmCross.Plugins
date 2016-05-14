//using System;
using Android.OS;
using Java.IO;

namespace g0rdan.MvvmCross.Plugins.Droid
{
    public class DataStorageInfoPlugin : IDataStorageInfoPlugin
    {
        long _freeSpace;
        long _totalSpace;

        public DataStorageInfoPlugin ()
        {
            File path = Environment.DataDirectory;
            StatFs stat = new StatFs (path.Path);
            _freeSpace = stat.BlockSizeLong;
            _totalSpace = stat.AvailableBlocksLong;
        }

        public decimal GetFreeSpace (MemorySizeType mSizeType = MemorySizeType.Bytes)
        {
            return ConvertTo (_freeSpace, mSizeType);
        }

        public decimal GetTotalSpace (MemorySizeType mSizeType = MemorySizeType.Bytes)
        {
            return ConvertTo (_totalSpace, mSizeType);
        }

        private decimal ConvertTo (long bytes, MemorySizeType mSizeType = MemorySizeType.Bytes)
        {
            switch (mSizeType) {
            case MemorySizeType.KBytes:
                return bytes / 1024;
            case MemorySizeType.MBytes:
                return bytes / 1024 / 1024;
            case MemorySizeType.GBytes:
                return bytes / 1024 / 1024 / 1024;
            default:
                return bytes;
            }
        }
    }
}

