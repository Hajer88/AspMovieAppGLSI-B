namespace AspMovieAppGLSI_B.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "membershiptype_Id", "dbo.Membershiptypes");
            DropIndex("dbo.Customers", new[] { "membershiptype_Id" });
            RenameColumn(table: "dbo.Customers", name: "membershiptype_Id", newName: "membershiptypeId");
            AlterColumn("dbo.Customers", "membershiptypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "membershiptypeId");
            AddForeignKey("dbo.Customers", "membershiptypeId", "dbo.Membershiptypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "membershiptypeId", "dbo.Membershiptypes");
            DropIndex("dbo.Customers", new[] { "membershiptypeId" });
            AlterColumn("dbo.Customers", "membershiptypeId", c => c.Int());
            RenameColumn(table: "dbo.Customers", name: "membershiptypeId", newName: "membershiptype_Id");
            CreateIndex("dbo.Customers", "membershiptype_Id");
            AddForeignKey("dbo.Customers", "membershiptype_Id", "dbo.Membershiptypes", "Id");
        }
    }
}
