namespace CVprojectGroup38.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workontest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserClasses", "WorkOnProject", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserClasses", "WorkOnProject");
        }
    }
}
