using AutoMapper;
using GigCloud.Core;
using GigCloud.Core.Dtos;
using GigCloud.Core.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GigCloud.Controllers.Api
{
    [Authorize]
    public class NotificationsController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NotificationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutomapperWebConfiguration.Configure().CreateMapper();
        }

        public IEnumerable<NotificationDto> GetNewNotifications()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _unitOfWork.Notifications.GetNewNotificationsFor(userId);

            return notifications.Select(_mapper.Map<Notification, NotificationDto>);
        }

        [HttpPost]
        public IHttpActionResult MarkAsRead()
        {
            var userId = User.Identity.GetUserId();
            var notifications = _unitOfWork.UserNotifications.GetUserNotificationsFor(userId);

            notifications.ForEach(n => n.Read());

            _unitOfWork.Complete();

            return Ok();
        }
    }
}
