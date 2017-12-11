using System.Collections.Generic;
using System.Net.Mail;

namespace Lecture36
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ---
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel)
        {
            _notificationChannels.Add(channel);
        }
    }
}