using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g0rdan.MvvmCross.Plugin.DiskInfo.WindowsCommon
{
    public class DiskInfoPlugin : IDiskInfoPlugin
    {
        public decimal GetFreeSpace(DeviceType deviceType = DeviceType.Inner, MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalSpace(DeviceType deviceType = DeviceType.Inner, MemorySizeType mSizeType = MemorySizeType.Bytes, int digits = 2)
        {
            throw new NotImplementedException();
        }
    }
}
