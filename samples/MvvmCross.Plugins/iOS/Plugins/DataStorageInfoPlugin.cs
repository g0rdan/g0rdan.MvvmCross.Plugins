﻿using System;
using Foundation;

namespace g0rdan.MvvmCross.Plugins.iOS
{
    public class DataStorageInfoPlugin : IDataStorageInfoPlugin
    {
        ulong _freeSpace;
        ulong _totalSpace;

        public DataStorageInfoPlugin ()
        {
            _freeSpace = NSFileManager.DefaultManager.GetFileSystemAttributes (
                Environment.GetFolderPath (Environment.SpecialFolder.Personal)).FreeSize;
            _totalSpace = NSFileManager.DefaultManager.GetFileSystemAttributes (
                Environment.GetFolderPath (Environment.SpecialFolder.Personal)).Size;
        }

        public decimal GetFreeSpace (MemorySizeType mSizeType = MemorySizeType.Bytes)
        {
            return ConvertTo (_freeSpace, mSizeType);
        }

        public decimal GetTotalSpace (MemorySizeType mSizeType = MemorySizeType.Bytes)
        {
            return ConvertTo (_totalSpace, mSizeType);
        }

        private decimal ConvertTo (ulong bytes, MemorySizeType mSizeType = MemorySizeType.Bytes)
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

