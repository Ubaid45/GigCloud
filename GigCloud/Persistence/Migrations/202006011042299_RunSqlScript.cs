using System.IO;

namespace GigCloud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RunSqlScript : DbMigration
    {
        public override void Up()
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../SqlScripts/01.06.2020.sql");
            Sql(File.ReadAllText(sqlFile));
        }

        public override void Down()
        {
        }
    }
}
