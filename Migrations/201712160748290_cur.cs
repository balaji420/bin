namespace CurApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cur : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProFaCurdefs", "CurRowid", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProFaCurdefs", "CurRowid", c => c.Guid(nullable: false));
        }
    }
}
