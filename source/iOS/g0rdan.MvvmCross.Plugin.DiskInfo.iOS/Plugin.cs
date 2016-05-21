using System;
using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace g0rdan.MvvmCross.Plugin.DiskInfo.iOS
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IDiskInfoPlugin> (new DiskInfoPlugin ());
        }
    } 
}

