using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Platform;
using MvvmCross.Droid.Views;
using g0rdan.MvvmCross.Plugin.SimpleEmail;
using g0rdan.MvvmCross.Plugin.DiskInfo;

namespace g0rdan.MvvmCross.Plugins.Droid
{
    [Activity (Label = "MvvmCross.Plugins", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : MvxActivity
    {
        int count = 1;

        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button> (Resource.Id.myButton);

            button.Click += (sender, e) => {

                var totalInnerSpace = Mvx.Resolve<IDiskInfoPlugin> ().GetTotalSpace ();
                var freeInnerSpace = Mvx.Resolve<IDiskInfoPlugin> ().GetFreeSpace ();

                var totalSDSpace = Mvx.Resolve<IDiskInfoPlugin> ().GetTotalSpace (DeviceType.SD);
                var freeSDSpace = Mvx.Resolve<IDiskInfoPlugin> ().GetFreeSpace (DeviceType.SD);


//                var simpleEmailPlugin = Mvx.Resolve<ISimpleEmailPlugin>();
//                simpleEmailPlugin.Init(this);
//                simpleEmailPlugin.SendEmail(
//                    "gordin.dan@gmail.com",
//                    "Subject",
//                    "Message text"
//                );
            };
        }
    }
}


