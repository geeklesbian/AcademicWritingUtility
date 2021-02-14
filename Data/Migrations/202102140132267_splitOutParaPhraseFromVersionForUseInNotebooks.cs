namespace AcademicWritingUtility.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class splitOutParaPhraseFromVersionForUseInNotebooks : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.NotebookCitation", "ArticleNotebookId", "dbo.ArticleNotebook");
            //DropForeignKey("dbo.NotebookExternalCitation", "ArticleNotebookId", "dbo.ArticleNotebook");
            //DropForeignKey("dbo.NotebookSection", "ArticleNotebookId", "dbo.ArticleNotebook");
            //DropForeignKey("dbo.NotebookCitation", "CitationId", "dbo.Citation");
            //DropForeignKey("dbo.NotebookExternalCitation", "ExternalCitationId", "dbo.Citation");
            //DropForeignKey("dbo.CitationFieldValue", "FieldId", "dbo.Lookup");
            //DropForeignKey("dbo.Lookup", "LookupTypeId", "dbo.LookupType");
            //DropForeignKey("dbo.CitationResearcher", "ResearcherId", "dbo.Researcher");
            //DropForeignKey("dbo.PaperVersion", "DraftId", "dbo.Draft");
            //DropColumn("dbo.CitationResearcher", "CitationId");
            //RenameColumn(table: "dbo.CitationResearcher", name: "ResearcherId", newName: "CitationId");
            //RenameIndex(table: "dbo.CitationResearcher", name: "IX_ResearcherId", newName: "IX_CitationId");
            //DropIndex("dbo.ParaPhrase", new[] { "VersionId" });
            //DropForeignKey("dbo.ParaPhrase", "VersionId", "dbo.PaperVersion");
            //DropColumn("dbo.ParaPhrase", "VersionId");

            CreateTable(
                "dbo.NotebookParaPhrase",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ParaPhraseId = c.Guid(nullable: false),
                        ArticleNotebookId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleNotebook", t => t.ArticleNotebookId, cascadeDelete: false, name: "FK_ArticleNotebookNotebookParaPhrase_ArticleNotebookId")
                .ForeignKey("dbo.ParaPhrase", t => t.ParaPhraseId, cascadeDelete: false, name: "FK_ParaPhraseNotebookParaPhrase_ParaPhraseId")
                .Index(t => t.ParaPhraseId)
                .Index(t => t.ArticleNotebookId);
            
            CreateTable(
                "dbo.VersionParaPhrase",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VersionId = c.Guid(nullable: false),
                        ParaPhraseId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaperVersion", t => t.VersionId, cascadeDelete: false, name: "FK_PaperVersionVersionParaPhrase_VersionId") //FK_PaperVersionParaPhrase_VersionId
                .ForeignKey("dbo.ParaPhrase", t => t.ParaPhraseId, cascadeDelete: false, name: "FK_ParaPhraseVersionParaPhrase_ParaPhraseId") 
                .Index(t => t.VersionId)
                .Index(t => t.ParaPhraseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VersionParaPhrase", "ParaPhraseId", "dbo.ParaPhrase");
            DropForeignKey("dbo.VersionParaPhrase", "VersionId", "dbo.PaperVersion");
            DropForeignKey("dbo.NotebookParaPhrase", "ParaPhraseId", "dbo.ParaPhrase");
            DropForeignKey("dbo.NotebookParaPhrase", "ArticleNotebookId", "dbo.ArticleNotebook");
            DropIndex("dbo.VersionParaPhrase", new[] { "ParaPhraseId" });
            DropIndex("dbo.VersionParaPhrase", new[] { "VersionId" });
            DropIndex("dbo.NotebookParaPhrase", new[] { "ArticleNotebookId" });
            DropIndex("dbo.NotebookParaPhrase", new[] { "ParaPhraseId" });
            DropTable("dbo.VersionParaPhrase");
            DropTable("dbo.NotebookParaPhrase");
        }
    }
}
