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

            SendEmailButton.TouchUpInside += SendEmailButton_TouchUpInside;
            DiskInfoButton.TouchUpInside += DiskInfoButton_TouchUpInside;
        }

        void SendEmailButton_TouchUpInside (object sender, EventArgs e)
        {
            var simpleEmailPlugin = Mvx.Resolve<ISimpleEmailPlugin> ();
            simpleEmailPlugin.Init (this);
            simpleEmailPlugin.SendEmail (
                "gordin.dan@gmail.com",
                "Subject",
                "Message text"
            );
        }

        void DiskInfoButton_TouchUpInside (object sender, EventArgs e)
        {
            var freeInner = Mvx.Resolve<IDiskInfoPlugin> ().GetFreeSpace (DeviceType.Inner, MemorySizeType.GBytes);
            var totalInner = Mvx.Resolve<IDiskInfoPlugin> ().GetTotalSpace (DeviceType.Inner, MemorySizeType.GBytes);
            UIAlertView alert = new UIAlertView (
                "Disk info", 
                $"Free space: {freeInner} GB\nTotal space: {totalInner} GB", 
                null, 
                "Ok", 
                null
            );
            alert.Show ();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


