namespace MarcinKrupnikLab3Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClothesMagazine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AddClothes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Clothe = c.String(nullable: false, maxLength: 4000),
                        Price = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AddClothes", "BrandId", "dbo.Brands");
            DropIndex("dbo.AddClothes", new[] { "BrandId" });
            DropTable("dbo.AddClothes");
            DropTable("dbo.Brands");
        }
    }
}
