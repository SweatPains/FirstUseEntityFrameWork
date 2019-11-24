namespace FirstUseEntityFrameWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PolyClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PolyClasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Parties", "PolyClassReference", c => c.Int(nullable: true));
            CreateIndex("dbo.Parties", "PolyClassReference");
            AddForeignKey("dbo.Parties", "PolyClassReference", "dbo.PolyClasses", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parties", "PolyClassReference", "dbo.PolyClasses");
            DropIndex("dbo.Parties", new[] { "PolyClassReference" });
            DropColumn("dbo.Parties", "PolyClassReference");
            DropTable("dbo.PolyClasses");
        }
    }
}
