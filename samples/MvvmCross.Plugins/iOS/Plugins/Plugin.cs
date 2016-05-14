using System;
using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace g0rdan.MvvmCross.Plugins.iOS
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<ISimpleEmailPlugin>(new SimpleEmailPlugin());
            Mvx.RegisterSingleton<IDataStorageInfoPlugin> (new DataStorageInfoPlugin ());
        }
    } 
}

