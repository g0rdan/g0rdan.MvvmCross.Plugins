using System;
using MvvmCross.Core.ViewModels;

namespace g0rdan.MvvmCross.Plugins
{
    public class App : MvxApplication
    {
        public App()
        {
        }

        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<ViewModels.MainViewModel>();
        }
    }
}

