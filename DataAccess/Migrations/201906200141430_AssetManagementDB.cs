namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssetManagementDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Condition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Conditon = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TB_T_Loaning", "TypeItem_Id", c => c.Int(nullable: false));
            AddColumn("dbo.TB_T_Return", "TypeItem_Id", c => c.Int(nullable: false));
            AddColumn("dbo.TB_T_Procurement", "TypeItem_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.TB_M_Item", "Name_Item", c => c.String());
            CreateIndex("dbo.TB_T_Loaning", "TypeItem_Id");
            CreateIndex("dbo.TB_T_Return", "TypeItem_Id");
            CreateIndex("dbo.TB_T_Procurement", "TypeItem_Id");
            AddForeignKey("dbo.TB_T_Loaning", "TypeItem_Id", "dbo.TB_M_TypeItem", "Id", cascadeDelete: false);
            AddForeignKey("dbo.TB_T_Return", "TypeItem_Id", "dbo.TB_M_TypeItem", "Id", cascadeDelete: false);
            AddForeignKey("dbo.TB_T_Procurement", "TypeItem_Id", "dbo.TB_M_TypeItem", "Id", cascadeDelete: false);
            DropColumn("dbo.TB_M_Item", "Condition");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_M_Item", "Condition", c => c.String());
            DropForeignKey("dbo.TB_T_Procurement", "TypeItem_Id", "dbo.TB_M_TypeItem");
            DropForeignKey("dbo.TB_T_Return", "TypeItem_Id", "dbo.TB_M_TypeItem");
            DropForeignKey("dbo.TB_T_Loaning", "TypeItem_Id", "dbo.TB_M_TypeItem");
            DropIndex("dbo.TB_T_Procurement", new[] { "TypeItem_Id" });
            DropIndex("dbo.TB_T_Return", new[] { "TypeItem_Id" });
            DropIndex("dbo.TB_T_Loaning", new[] { "TypeItem_Id" });
            AlterColumn("dbo.TB_M_Item", "Name_Item", c => c.Int(nullable: false));
            DropColumn("dbo.TB_T_Procurement", "TypeItem_Id");
            DropColumn("dbo.TB_T_Return", "TypeItem_Id");
            DropColumn("dbo.TB_T_Loaning", "TypeItem_Id");
            DropTable("dbo.TB_M_Condition");
        }
    }
}
