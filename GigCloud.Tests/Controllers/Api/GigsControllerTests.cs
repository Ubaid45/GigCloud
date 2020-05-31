using GigCloud.Controllers.Api;
using GigCloud.Core;
using GigCloud.Tests.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GigCloud.Tests.Controllers.Api
{
    [TestClass]
    public class GigsControllerTests
    {
        private GigsController _controller;

        public GigsControllerTests()
        {

            var mockUoW = new Mock<IUnitOfWork>();

            _controller = new GigsController(mockUoW.Object);
            _controller.MockCurrentUser("1", "user1@domain.com");
        }
    }
}
