namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductCouponCode", c => c.Int());
           
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CouponCode", c => c.Int(nullable: false));
           
        }
    }
}
