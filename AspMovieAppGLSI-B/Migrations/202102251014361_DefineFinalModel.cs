namespace AspMovieAppGLSI_B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefineFinalModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Membershiptypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignupFee = c.Int(nullable: false),
                        DurationInMonth = c.Int(nullable: false),
                        DiscountRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieCustomers",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Customer_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Customer_Id);
            
            AddColumn("dbo.Customers", "membershiptype_Id", c => c.Int());
            AddColumn("dbo.Movies", "genre_Id", c => c.Int());
            CreateIndex("dbo.Customers", "membershiptype_Id");
            CreateIndex("dbo.Movies", "genre_Id");
            AddForeignKey("dbo.Customers", "membershiptype_Id", "dbo.Membershiptypes", "Id");
            AddForeignKey("dbo.Movies", "genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "genre_Id", "dbo.Genres");
            DropForeignKey("dbo.MovieCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.MovieCustomers", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Customers", "membershiptype_Id", "dbo.Membershiptypes");
            DropIndex("dbo.MovieCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.MovieCustomers", new[] { "Movie_Id" });
            DropIndex("dbo.Movies", new[] { "genre_Id" });
            DropIndex("dbo.Customers", new[] { "membershiptype_Id" });
            DropColumn("dbo.Movies", "genre_Id");
            DropColumn("dbo.Customers", "membershiptype_Id");
            DropTable("dbo.MovieCustomers");
            DropTable("dbo.Genres");
            DropTable("dbo.Membershiptypes");
        }
    }
}
