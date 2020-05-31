using GigCloud.Core.Models;

namespace GigCloud.Core.IRepositories
{
    public interface IFollowingRepository
    {
        Following GetFollowing(string followerId, string followeeId);
        void Add(Following following);
        void Remove(Following following);
    }
}