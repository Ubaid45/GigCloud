using GigCloud.Core.Models;
using System.Collections.Generic;

namespace GigCloud.Core.IRepositories
{
    public interface INotificationRepository
    {
        IEnumerable<Notification> GetNewNotificationsFor(string userId);
    }
}