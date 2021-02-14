namespace AcademicWritingUtility.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.LookupType",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            Val = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Lookup",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false),
            //            LookupTypeId = c.Guid(nullable: false),
            //            Val = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.LookupType", t => t.LookupTypeId, cascadeDelete: false, name: "FK_LookupTypeLookup_LookupTypeId")
            //    .Index(t => t.LookupTypeId);
            
            CreateTable(
                "dbo.Citation",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CitationTypeId = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 300, unicode: false),
                        Name = c.String(nullable: false, maxLength: 300, unicode: false),
                        YearPublished = c.Int(nullable: false),
                        Doi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lookup", t => t.CitationTypeId, cascadeDelete: false, name: "FK_LookupCitation_CitationTypeId")
                .Index(t => t.CitationTypeId)
                .Index(t => t.YearPublished);
            
            CreateTable(
                "dbo.ArticleNotebook",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CitationId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Citation", t => t.CitationId, cascadeDelete: false, name: "FK_CitationArticleNotebook_CitationId")
                .Index(t => t.CitationId);
            
            CreateTable(
                "dbo.CitationFieldValue",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CitationId = c.Guid(nullable: false),
                        FieldId = c.Guid(nullable: false),
                        Val = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lookup", t => t.FieldId, cascadeDelete: false, name: "FK_LookupCitationFieldValue_FieldId")
                .ForeignKey("dbo.Citation", t => t.CitationId, cascadeDelete: false, name: "FK_CitationCitationFieldValue_CitationId")
                .Index(t => t.CitationId)
                .Index(t => t.FieldId);
            
            CreateTable(
                "dbo.CitationResearcher",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CitationId = c.Guid(nullable: false),
                        ResearcherId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Researcher", t => t.ResearcherId, cascadeDelete: false, name: "FK_ResearcherCitationResearcher_ResearcherId")
                .ForeignKey("dbo.Citation", t => t.CitationId, cascadeDelete: false, name: "FK_CitationCitationResearcher_CitationId")
                .Index(t => t.ResearcherId)
                .Index(t => t.CitationId);
            
            CreateTable(
                "dbo.Researcher",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LastName = c.String(nullable: false),
                        Initials = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotebookCitation",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CitationId = c.Guid(nullable: false),
                        ArticleNotebookId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleNotebook", t => t.ArticleNotebookId, cascadeDelete: false, name: "FK_ArticleNotebookNotebookCitation_ArticleNotebookId")
                .ForeignKey("dbo.Citation", t => t.CitationId, cascadeDelete: false, name: "FK_CitationNotebookCitation_CitationId")
                .Index(t => t.CitationId)
                .Index(t => t.ArticleNotebookId);
            
            CreateTable(
                "dbo.NotebookExternalCitation",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ExternalCitationId = c.Guid(nullable: false),
                        ArticleNotebookId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleNotebook", t => t.ArticleNotebookId, cascadeDelete: false, name: "FK_ArticleNotebookExternal_ArticleNotebookId")
                .ForeignKey("dbo.Citation", t => t.ExternalCitationId, cascadeDelete: false, name: "FK_CitationNotebookExternal_ExternalCitationId")
                .Index(t => t.ExternalCitationId)
                .Index(t => t.ArticleNotebookId);
            
            CreateTable(
                "dbo.ParaPhrase",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CitationId = c.Guid(nullable: false),
                        PageNumber = c.String(nullable: false),
                        VersionId = c.Guid(nullable: false),
                        Order = c.Int(nullable: false),
                        Phrase = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaperVersion", t => t.VersionId, cascadeDelete: false, name: "FK_PaperVersionParaPhrase_VersionId")
                .ForeignKey("dbo.Citation", t => t.CitationId, cascadeDelete: false, name: "FK_CitationParaPhrase_CitationId")
                .Index(t => t.CitationId)
                .Index(t => t.VersionId);
            
            CreateTable(
                "dbo.PaperVersion",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DraftId = c.Guid(nullable: false),
                        Number = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Draft", t => t.DraftId, cascadeDelete: false, name: "FK_DraftPaperVersion_DraftId")
                .Index(t => t.DraftId);
            
            CreateTable(
                "dbo.Draft",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NotebookSection",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Order = c.Int(nullable: false),
                        Text = c.String(nullable: false),
                        ArticleNotebookId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArticleNotebook", t => t.ArticleNotebookId, cascadeDelete: false, name: "FK_ArticleNotebookNotebookSection_ArticleNotebookId")
                .Index(t => t.ArticleNotebookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotebookSection", "ArticleNotebookId", "dbo.ArticleNotebook");
            DropForeignKey("dbo.ParaPhrase", "CitationId", "dbo.Citation");
            DropForeignKey("dbo.ParaPhrase", "VersionId", "dbo.PaperVersion");
            DropForeignKey("dbo.PaperVersion", "DraftId", "dbo.Draft");
            DropForeignKey("dbo.NotebookExternalCitation", "ExternalCitationId", "dbo.Citation");
            DropForeignKey("dbo.NotebookExternalCitation", "ArticleNotebookId", "dbo.ArticleNotebook");
            DropForeignKey("dbo.NotebookCitation", "CitationId", "dbo.Citation");
            DropForeignKey("dbo.NotebookCitation", "ArticleNotebookId", "dbo.ArticleNotebook");
            DropForeignKey("dbo.CitationResearcher", "ResearcherId", "dbo.Citation");
            DropForeignKey("dbo.CitationResearcher", "ResearcherId", "dbo.Researcher");
            DropForeignKey("dbo.CitationFieldValue", "CitationId", "dbo.Citation");
            DropForeignKey("dbo.Lookup", "LookupTypeId", "dbo.LookupType");
            DropForeignKey("dbo.Citation", "CitationTypeId", "dbo.Lookup");
            DropForeignKey("dbo.CitationFieldValue", "FieldId", "dbo.Lookup");
            DropForeignKey("dbo.ArticleNotebook", "CitationId", "dbo.Citation");
            DropIndex("dbo.NotebookSection", new[] { "ArticleNotebookId" });
            DropIndex("dbo.PaperVersion", new[] { "DraftId" });
            DropIndex("dbo.ParaPhrase", new[] { "VersionId" });
            DropIndex("dbo.ParaPhrase", new[] { "CitationId" });
            DropIndex("dbo.NotebookExternalCitation", new[] { "ArticleNotebookId" });
            DropIndex("dbo.NotebookExternalCitation", new[] { "ExternalCitationId" });
            DropIndex("dbo.NotebookCitation", new[] { "ArticleNotebookId" });
            DropIndex("dbo.NotebookCitation", new[] { "CitationId" });
            DropIndex("dbo.CitationResearcher", new[] { "ResearcherId" });
            DropIndex("dbo.Lookup", new[] { "LookupTypeId" });
            DropIndex("dbo.CitationFieldValue", new[] { "FieldId" });
            DropIndex("dbo.CitationFieldValue", new[] { "CitationId" });
            DropIndex("dbo.Citation", new[] { "CitationTypeId" });
            DropIndex("dbo.ArticleNotebook", new[] { "CitationId" });
            DropTable("dbo.NotebookSection");
            DropTable("dbo.Draft");
            DropTable("dbo.PaperVersion");
            DropTable("dbo.ParaPhrase");
            DropTable("dbo.NotebookExternalCitation");
            DropTable("dbo.NotebookCitation");
            DropTable("dbo.Researcher");
            DropTable("dbo.CitationResearcher");
            DropTable("dbo.LookupType");
            DropTable("dbo.Lookup");
            DropTable("dbo.CitationFieldValue");
            DropTable("dbo.Citation");
            DropTable("dbo.ArticleNotebook");
        }
    }
}
