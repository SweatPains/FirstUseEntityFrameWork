namespace FirstUseEntityFrameWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartyLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parties", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parties", "Location");
        }
    }
}
