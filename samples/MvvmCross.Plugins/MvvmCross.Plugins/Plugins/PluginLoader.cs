using System;
using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace g0rdan.MvvmCross.Plugins
{
    public class PluginLoader : IMvxPluginLoader
    {
        public static readonly PluginLoader Instance = new PluginLoader();

        private bool _loaded;

        public void EnsureLoaded()
        {
            var manager = Mvx.Resolve<IMvxPluginManager>();
            manager.EnsurePlatformAdaptionLoaded<PluginLoader>();
        }
    }
}

