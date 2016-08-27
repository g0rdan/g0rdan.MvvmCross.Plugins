using System;
using Foundation;

namespace g0rdan.MvvmCross.Plugin.DiskInfo.iOS
{
    public class DiskInfoPlugin : IDiskInfoPlugin
    {
        ulong _freeSpace;
        ulong _totalSpace;

        public DiskInfoPlugin ()
        {
            _freeSpace = NSFileManager.DefaultManager.GetFileSystemAttributes (
                Environment.GetFolderPath (Environment.SpecialFolder.Personal)).FreeSize;
            _totalSpace = NSFileManager.DefaultManager.GetFileSystemAttributes (
                Environment.GetFolderPath (Environment.SpecialFolder.Personal)).Size;
        }

        public decimal GetFreeSpace (StorageType storageType = StorageType.Inner, MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2)
        {
            if (storageType != StorageType.Inner)
                return 0;

            return ConvertTo (_freeSpace, mSizeType, digits);
        }

        public decimal GetTotalSpace (StorageType storageType = StorageType.Inner, MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2)
        {
            if (storageType != StorageType.Inner)
                return 0;
            
            return ConvertTo (_totalSpace, mSizeType, digits);
        }

        private decimal ConvertTo (ulong bytes, MemorySizeType mSizeType, int digits)
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

