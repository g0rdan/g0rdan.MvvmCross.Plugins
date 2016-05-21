using System;

using UIKit;
using MvvmCross.Platform;
using g0rdan.MvvmCross.Plugins;
using g0rdan.MvvmCross.Plugin.SimpleEmail;

namespace MvvmCross.Plugins.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;

        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            // Code to start the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
#endif

            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += delegate {
                Mvx.Resolve<ISimpleEmailPlugin>();
            };
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
