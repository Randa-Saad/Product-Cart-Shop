namespace Product_Cart_Shop_Task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initcreat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        ProductPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductDetails");
        }
    }
}
