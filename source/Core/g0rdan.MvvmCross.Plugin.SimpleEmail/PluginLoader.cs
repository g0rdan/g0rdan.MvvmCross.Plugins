﻿using System;
using MvvmCross.Platform.Plugins;
using MvvmCross.Platform;

namespace g0rdan.MvvmCross.Plugin.SimpleEmail
{
    public class PluginLoader : IMvxPluginLoader
    {
        public static readonly PluginLoader Instance = new PluginLoader();

        public void EnsureLoaded()
        {
            var manager = Mvx.Resolve<IMvxPluginManager>();
            manager.EnsurePlatformAdaptionLoaded<PluginLoader>();
        }
    }
}

