using System;
using MvvmCross.iOS.Platform;
using UIKit;
using MvvmCross.Core.ViewModels;

namespace g0rdan.MvvmCross.Plugins.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, UIWindow windows)
            : base(appDelegate, windows)
        {
        }

        protected override IMvxApplication CreateApp ()
        {
            return new App();
        }
    }
}

