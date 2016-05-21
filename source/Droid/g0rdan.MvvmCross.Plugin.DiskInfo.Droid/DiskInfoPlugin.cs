using System;
using Android.OS;
using Java.IO;
using g0rdan.MvvmCross.Plugin.DiskInfo;

namespace g0rdan.MvvmCross.Plugin.DiskInfo.Droid
{
    public class DiskInfoPlugin : IDiskInfoPlugin
    {
        long _freeSpace;
        long _totalSpace;

        public DiskInfoPlugin ()
        {
            File path = Android.OS.Environment.DataDirectory;
            StatFs stat = new StatFs (path.Path);
            _freeSpace = stat.BlockSizeLong;
            _totalSpace = stat.AvailableBlocksLong;
        }

        public decimal GetFreeSpace (MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2)
        {
            return ConvertTo (_freeSpace, mSizeType, digits);
        }

        public decimal GetTotalSpace (MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2)
        {
            return ConvertTo (_totalSpace, mSizeType, digits);
        }

        private decimal ConvertTo (long bytes, MemorySizeType mSizeType, int digits)
        {
            decimal result;
            decimal divider = 1024;

            switch (mSizeType) {
            case MemorySizeType.KBytes:
                result = bytes / divider;
                break;
            case MemorySizeType.MBytes:
                result = bytes / divider / divider;
                break;
            case MemorySizeType.GBytes:
                result = bytes / divider / divider / divider;
                break;
            default:
                return bytes;
            }

            return Math.Round (result, digits);
        }
    }
}

