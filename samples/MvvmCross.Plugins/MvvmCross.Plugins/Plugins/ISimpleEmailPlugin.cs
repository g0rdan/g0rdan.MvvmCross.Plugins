using System;

namespace g0rdan.MvvmCross.Plugins
{
    public interface ISimpleEmailPlugin
    {
        void Init(object context);
        void SendEmail(string toEmail, string subject, string message);
    }
}

