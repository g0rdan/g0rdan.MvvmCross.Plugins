using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Platform;
using MvvmCross.Droid.Views;
using g0rdan.MvvmCross.Plugin.SimpleEmail;
using g0rdan.MvvmCross.Plugin.DiskInfo;
using System;

namespace g0rdan.MvvmCross.Plugins.Droid
{
    [Activity (Label = "MvvmCross.Plugins", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : MvxActivity
    {
        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);

            SetContentView (Resource.Layout.Main);

            FindViewById<Button> (Resource.Id.send_email_button).Click += SendEmail_Click;
            FindViewById<Button> (Resource.Id.disk_info_button).Click += DiskInfo_Click;
        }

        void SendEmail_Click (object sender, EventArgs e)
        {
            var simpleEmailPlugin = Mvx.Resolve<ISimpleEmailPlugin> ();
            simpleEmailPlugin.Init (this);
            simpleEmailPlugin.SendEmail (
                "gordin.dan@gmail.com",
                "Subject",
                "Message text"
            );
        }

        void DiskInfo_Click (object sender, EventArgs e)
        {
            var totalInnerSpace = Mvx.Resolve<IDiskInfoPlugin> ().GetTotalSpace (mSizeType: MemorySizeType.MBytes);
            var freeInnerSpace = Mvx.Resolve<IDiskInfoPlugin> ().GetFreeSpace (mSizeType: MemorySizeType.MBytes);

            var alert = new AlertDialog.Builder (this)
               .SetTitle("Disk info")
               .SetMessage($"Free space: {freeInnerSpace} MB\nTotal space: {totalInnerSpace} MB");

            alert.Show ();
        }
   }
}


