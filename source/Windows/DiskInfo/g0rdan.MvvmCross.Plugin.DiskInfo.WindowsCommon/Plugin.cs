using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g0rdan.MvvmCross.Plugin.DiskInfo.WindowsCommon
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IDiskInfoPlugin>(new DiskInfoPlugin());
        }
    }
}
