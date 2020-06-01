using GigCloud.Core.Models;
using GigCloud.Persistence;
using GigCloud.Persistence.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;

namespace GigCloud.Tests.Persistence.Repositories
{
    [TestClass]
    public class NotificationRepositoryTests
    {
        private NotificationRepository _repository;
        private Mock<DbSet<UserNotification>> _mockNotifications;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockNotifications = new Mock<DbSet<UserNotification>>();

            var mockContext = new Mock<IApplicationDbContext>();
            mockContext.SetupGet(c => c.UserNotifications).Returns(_mockNotifications.Object);


            _repository = new NotificationRepository(mockContext.Object);
        }
    }
}
