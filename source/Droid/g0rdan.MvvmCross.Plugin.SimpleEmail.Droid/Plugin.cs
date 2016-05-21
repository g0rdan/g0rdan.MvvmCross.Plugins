using System;
using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace g0rdan.MvvmCross.Plugin.SimpleEmail.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<ISimpleEmailPlugin>(new SimpleEmailPlugin());
        }
    }
}

