using System;
using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace g0rdan.MvvmCross.Plugins.Droid
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

