namespace CVprojectGroup38.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projecttodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Projectname = c.String(),
                        ProjectManager_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserClasses", t => t.ProjectManager_Id)
                .Index(t => t.ProjectManager_Id);
            
            AddColumn("dbo.UserClasses", "ProjectClass_Id", c => c.Int());
            CreateIndex("dbo.UserClasses", "ProjectClass_Id");
            AddForeignKey("dbo.UserClasses", "ProjectClass_Id", "dbo.ProjectClasses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectClasses", "ProjectManager_Id", "dbo.UserClasses");
            DropForeignKey("dbo.UserClasses", "ProjectClass_Id", "dbo.ProjectClasses");
            DropIndex("dbo.UserClasses", new[] { "ProjectClass_Id" });
            DropIndex("dbo.ProjectClasses", new[] { "ProjectManager_Id" });
            DropColumn("dbo.UserClasses", "ProjectClass_Id");
            DropTable("dbo.ProjectClasses");
        }
    }
}
