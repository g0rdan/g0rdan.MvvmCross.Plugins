using System;

namespace g0rdan.MvvmCross.Plugins
{
    public interface ISimpleEmailPlugin
    {
        void SendEmail(string toEmail, string subject, string message);
    }
}

