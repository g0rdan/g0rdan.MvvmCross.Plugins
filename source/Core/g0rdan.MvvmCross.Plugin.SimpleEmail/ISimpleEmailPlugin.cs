using System;

namespace g0rdan.MvvmCross.Plugin.SimpleEmail
{
    public interface ISimpleEmailPlugin
    {
        void Init(object context);
        void SendEmail(string toEmail, string subject, string message);
    }
}

