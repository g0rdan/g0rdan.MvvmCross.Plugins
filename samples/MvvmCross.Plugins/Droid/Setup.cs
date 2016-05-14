using System;
using MvvmCross.Droid.Platform;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

namespace g0rdan.MvvmCross.Plugins.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}

