using System;
using MessageUI;
using UIKit;

namespace g0rdan.MvvmCross.Plugin.SimpleEmail.iOS
{
    public class SimpleEmailPlugin : ISimpleEmailPlugin
    {
        MFMailComposeViewController _mailController;
        UIViewController _vc;

        public SimpleEmailPlugin()
        {
        }

        #region ISimpleEmailPlugin implementation

        public void Init(object context)
        {
            var vc = context as UIViewController;
            if (vc == null)
                throw new ArgumentException("You have to put UIViewController into context");
            _vc = vc;
        }

        void ISimpleEmailPlugin.SendEmail(string toEmail, string subject, string message)
        {
            if (_vc == null)
                throw new MissingMethodException("You have to call Init() method before");

            if (MFMailComposeViewController.CanSendMail) {

                var to = new string[]{ toEmail };

                if (MFMailComposeViewController.CanSendMail) {
                    _mailController = new MFMailComposeViewController ();
                    _mailController.SetToRecipients (to);
                    _mailController.SetSubject (subject);
                    _mailController.SetMessageBody (message, false);
                    _mailController.Finished += (object s, MFComposeResultEventArgs args) => {

                        _vc.BeginInvokeOnMainThread (() => {
                            args.Controller.DismissViewController (true, null);
                        });
                    };
                }

                _vc.PresentViewController (_mailController, true, null);
            } else {
                new UIAlertView("Can't send email", string.Empty, null, "OK").Show();
            }
        }

        #endregion
    }
}

