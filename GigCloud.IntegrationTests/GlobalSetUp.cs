using NUnit.Framework;
using System.Data.Entity.Migrations;

namespace GigCloud.IntegrationTests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        [SetUp]
        public void SetUp()
        {
            MigrateDbToLatestVersion();
        }

        private static void MigrateDbToLatestVersion()
        {
            var configuration = new Migrations.Configuration();
            var migrator = new DbMigrator(configuration);
            migrator.Update();
        }

    }
}