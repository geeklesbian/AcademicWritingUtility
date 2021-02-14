namespace AcademicWritingUtility.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveVersionFromParaPhrasePostOtherPharaPhraseUpdates : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.ParaPhrase", new[] { "VersionId" });
            //DropForeignKey("dbo.ParaPhrase", "VersionId", "dbo.PaperVersion");

            //DropColumn("dbo.ParaPhrase", "VersionId");

        }

        public override void Down()
        {
            AddColumn("dbo.ParaPhrase", "VersionId", c=>c.Guid(nullable: false));
            AddForeignKey("dbo.ParaPhrase", "VersionId", "dbo.PaperVersion", "Id", cascadeDelete: false, name: "FK_PaperVersionParaPhrase_VersionId");
            CreateIndex("dbo.ParaPhrase", "VersionId");
        }
    }
}
