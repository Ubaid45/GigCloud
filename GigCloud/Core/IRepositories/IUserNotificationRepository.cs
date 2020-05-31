using GigCloud.Core.Models;
using System.Collections.Generic;

namespace GigCloud.Core.IRepositories
{
    public interface IUserNotificationRepository
    {
        IEnumerable<UserNotification> GetUserNotificationsFor(string userId);
    }
}