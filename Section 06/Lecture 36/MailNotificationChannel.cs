using System;

namespace Lecture36
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Send mail");
        }
    }
}