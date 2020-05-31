using GigCloud.Core.Models;

namespace GigCloud.Core.IRepositories
{
    public interface IFollowingRepository
    {
        Following GetFollowing(string followerId, string followeeId);
    }
}