using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;
using g0rdan.MvvmCross.Plugin.DiskInfo;
using g0rdan.MvvmCross.Plugin.SimpleEmail;

namespace g0rdan.MvvmCross.Plugins.iOS
{
    public partial class MainView : MvxViewController
    {
        public MainView()
            : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SendEmailButton.TouchUpInside += (sender, e) => {

                var freeInner = Mvx.Resolve<IDiskInfoPlugin> ().GetFreeSpace (DeviceType.Inner);
                var freeSD = Mvx.Resolve<IDiskInfoPlugin> ().GetFreeSpace (DeviceType.SD);

//                var simpleEmailPlugin = Mvx.Resolve<ISimpleEmailPlugin>();
//                simpleEmailPlugin.Init(this);
//                simpleEmailPlugin.SendEmail(
//                    "gordin.dan@gmail.com",
//                    "Subject",
//                    "Message text"
//                );
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


