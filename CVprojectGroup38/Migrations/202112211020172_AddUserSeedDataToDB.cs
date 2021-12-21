namespace CVprojectGroup38.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserSeedDataToDB : DbMigration
    {
        public override void Up()
        {
            Sql("insert into UserClasses (UserName, UserPassword) values ('Edde1997', 'super1234');");
        }
        
        public override void Down()
        {
        }
    }
}
