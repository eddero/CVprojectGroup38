namespace CVprojectGroup38.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        UserPassword = c.Int(nullable: false),
                        UserStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserImg = c.String(),
                        UserEducation = c.String(),
                        UserSkill = c.String(),
                        UserAdress = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAccounts", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoes", "Id", "dbo.UserAccounts");
            DropIndex("dbo.UserInfoes", new[] { "Id" });
            DropTable("dbo.UserInfoes");
            DropTable("dbo.UserAccounts");
        }
    }
}
