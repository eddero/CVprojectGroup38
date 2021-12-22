namespace CVprojectGroup38.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectClasses", "UserClass_Id", c => c.Int());
            CreateIndex("dbo.ProjectClasses", "UserClass_Id");
            AddForeignKey("dbo.ProjectClasses", "UserClass_Id", "dbo.UserClasses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectClasses", "UserClass_Id", "dbo.UserClasses");
            DropIndex("dbo.ProjectClasses", new[] { "UserClass_Id" });
            DropColumn("dbo.ProjectClasses", "UserClass_Id");
        }
    }
}
