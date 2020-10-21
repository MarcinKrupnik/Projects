 namespace MarcinKrupnikLab3Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shoe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrandShoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AddShoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Shoe = c.String(nullable: false, maxLength: 4000),
                        Price = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BrandShoes", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            AddColumn("dbo.AddClothes", "BrandShoes_Id", c => c.Int());
            CreateIndex("dbo.AddClothes", "BrandShoes_Id");
            AddForeignKey("dbo.AddClothes", "BrandShoes_Id", "dbo.BrandShoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AddShoes", "BrandId", "dbo.BrandShoes");
            DropForeignKey("dbo.AddClothes", "BrandShoes_Id", "dbo.BrandShoes");
            DropIndex("dbo.AddShoes", new[] { "BrandId" });
            DropIndex("dbo.AddClothes", new[] { "BrandShoes_Id" });
            DropColumn("dbo.AddClothes", "BrandShoes_Id");
            DropTable("dbo.AddShoes");
            DropTable("dbo.BrandShoes");
        }
    }
}
