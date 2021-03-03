namespace AspMovieAppGLSI_B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershiptype : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Membershiptypes(SignupFee, DurationInMonth, DiscountRate) VALUES (10,10,10)");
            Sql("INSERT INTO Membershiptypes(SignupFee, DurationInMonth, DiscountRate) VALUES (10,10,10)");
        }
        
        public override void Down()
        {
        }
    }
}
