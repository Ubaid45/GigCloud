using GigCloud.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace GigCloud.Persistence.EntityConfigurations
{
    public class NotificationConfiguration : EntityTypeConfiguration<Notification>
    {
        public NotificationConfiguration()
        {
            HasRequired(n => n.Gig);
        }
    }
}