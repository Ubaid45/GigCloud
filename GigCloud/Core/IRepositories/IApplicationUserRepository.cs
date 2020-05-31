using GigCloud.Core.Models;
using System.Collections.Generic;

namespace GigCloud.Core.IRepositories
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetArtistsFollowedBy(string userId);
    }
}