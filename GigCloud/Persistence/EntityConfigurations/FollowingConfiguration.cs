using System.Data.Entity.ModelConfiguration;
using GigCloud.Core.Models;

namespace GigCloud.Persistence.EntityConfigurations
{
    public class FollowingConfiguration : EntityTypeConfiguration<Following>
    {
        public FollowingConfiguration()
        {
            HasKey(f => new { f.FollowerId, f.FolloweeId });
        }
    }
}