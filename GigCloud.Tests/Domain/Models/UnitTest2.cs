using FluentAssertions;
using GigCloud.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace GigCloud.Tests.Domain.Models
{
    [TestClass]
    public class GigTests
    {
        // A different approach to write these tests is using BDD. 
        // 
        // GivenAnArtistHasAGig
        //      WhenHeCancelsTheGig
        //          IsCanceledShouldBeSetToTrue
        //          EachAttendeeShouldHaveANotification
        //
        // 
        [TestMethod]
        public void Cancel_WhenCalled_ShouldSetIsCanceledToTrue()
        {
            var gig = new Gig();

            gig.Cancel();

            gig.IsCanceled.Should().BeTrue();
        }

       
    }
}
