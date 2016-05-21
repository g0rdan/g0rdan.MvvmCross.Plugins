using System;
using Android.Content;

namespace g0rdan.MvvmCross.Plugin.SimpleEmail.Droid
{
    public class SimpleEmailPlugin : ISimpleEmailPlugin
    {
        Context _context;

        #region ISimpleEmailPlugin implementation

        public void Init(object context)
        {
            var ctx = context as Context;
            if (ctx == null)
                throw new ArgumentException("You have to put Android.Content.Context into context");
            _context = ctx;
        }

        public void SendEmail(string toEmail, string subject, string message)
        {
            if (_context == null)
                throw new MissingMethodException("You have to call Init() method before");

            var email = new Intent (Android.Content.Intent.ActionSend);
            email.PutExtra(Android.Content.Intent.ExtraEmail, new string[]{toEmail});
            //            email.PutExtra(Android.Content.Intent.ExtraCc, new string[]{"person3@xamarin.com"});
            email.PutExtra(Android.Content.Intent.ExtraSubject, subject);
            email.PutExtra(Android.Content.Intent.ExtraText, message);
            email.SetType("message/rfc822");
            _context.StartActivity(email);
        }

        #endregion
    }
}

