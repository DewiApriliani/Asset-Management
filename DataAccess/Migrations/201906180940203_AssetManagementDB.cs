namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssetManagementDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_T_Handover",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name_User = c.String(),
                        Name_Admin = c.String(),
                        Date_Handover = c.DateTimeOffset(nullable: false, precision: 7),
                        User_Id = c.Int(nullable: false),
                        Admin_Id = c.Int(nullable: false),
                        Divhead_Id = c.Int(nullable: false),
                        Loaning_Id = c.Int(nullable: false),
                        Return_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_T_Loaning", t => t.Loaning_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_T_Return", t => t.Return_Id, cascadeDelete: true)
                .Index(t => t.Loaning_Id)
                .Index(t => t.Return_Id);
            
            CreateTable(
                "dbo.TB_T_Loaning",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        Date_Loaning = c.DateTimeOffset(nullable: false, precision: 7),
                        Date_Return = c.DateTimeOffset(nullable: false, precision: 7),
                        Name_User = c.String(),
                        Name_Item = c.String(),
                        Quantity = c.Int(nullable: false),
                        Status = c.String(),
                        Item_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Item", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.TB_M_Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Item = c.Int(nullable: false),
                        Merk = c.String(),
                        Description = c.String(),
                        Photo_Item = c.String(),
                        Condition = c.String(),
                        Year_Procurement = c.DateTimeOffset(nullable: false, precision: 7),
                        Stock = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Typeitem_Id = c.Int(nullable: false),
                        Location_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Location", t => t.Location_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_TypeItem", t => t.Typeitem_Id, cascadeDelete: true)
                .Index(t => t.Typeitem_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.TB_M_Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Location = c.String(),
                        Floor = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_TypeItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_TypeItem = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_Return",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_User = c.String(),
                        Name_Item = c.String(),
                        Quantity = c.Int(nullable: false),
                        Status = c.String(),
                        Last_Condition = c.String(),
                        Date_Return = c.DateTimeOffset(nullable: false, precision: 7),
                        User_Id = c.Int(nullable: false),
                        Item_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Item", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Item_Id);
            
            CreateTable(
                "dbo.TB_M_Parameter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Validation = c.String(),
                        Punishment = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_Procurement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Admin_Id = c.Int(nullable: false),
                        Name_Procurement = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Name_Item = c.String(),
                        Date_Procurement = c.DateTimeOffset(nullable: false, precision: 7),
                        Name_Admin = c.String(),
                        Quantity = c.Int(nullable: false),
                        Status = c.String(),
                        Item_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Item", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Item_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_Procurement", "Item_Id", "dbo.TB_M_Item");
            DropForeignKey("dbo.TB_T_Handover", "Return_Id", "dbo.TB_T_Return");
            DropForeignKey("dbo.TB_T_Return", "Item_Id", "dbo.TB_M_Item");
            DropForeignKey("dbo.TB_T_Handover", "Loaning_Id", "dbo.TB_T_Loaning");
            DropForeignKey("dbo.TB_T_Loaning", "Item_Id", "dbo.TB_M_Item");
            DropForeignKey("dbo.TB_M_Item", "Typeitem_Id", "dbo.TB_M_TypeItem");
            DropForeignKey("dbo.TB_M_Item", "Location_Id", "dbo.TB_M_Location");
            DropIndex("dbo.TB_T_Procurement", new[] { "Item_Id" });
            DropIndex("dbo.TB_T_Return", new[] { "Item_Id" });
            DropIndex("dbo.TB_M_Item", new[] { "Location_Id" });
            DropIndex("dbo.TB_M_Item", new[] { "Typeitem_Id" });
            DropIndex("dbo.TB_T_Loaning", new[] { "Item_Id" });
            DropIndex("dbo.TB_T_Handover", new[] { "Return_Id" });
            DropIndex("dbo.TB_T_Handover", new[] { "Loaning_Id" });
            DropTable("dbo.TB_T_Procurement");
            DropTable("dbo.TB_M_Parameter");
            DropTable("dbo.TB_T_Return");
            DropTable("dbo.TB_M_TypeItem");
            DropTable("dbo.TB_M_Location");
            DropTable("dbo.TB_M_Item");
            DropTable("dbo.TB_T_Loaning");
            DropTable("dbo.TB_T_Handover");
        }
    }
}
