using GigCloud.Persistence;
using GigCloud.Persistence.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GigCloud.Tests.Persistence.Repositories
{
    [TestClass]
    public class GigRepositoryTests
    {
        private GigRepository _repository;
        [TestMethod]
        public void TestInitialize()
        {
            var mockContext = new Mock<IApplicationDbContext>();
            //mockContext.SetupGet(c => c.Gigs).Returns(_mockGigs.Object);
            _repository = new GigRepository(mockContext.Object);
        }
    }
}
