using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademicWritingUtility.Data.Configurations;
using AcademicWritingUtility.Domain.Models;

namespace AcademicWritingUtility.Data
{
    public class AWUContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Add<ForeignKeyNamingConvention>();

            modelBuilder.Configurations.Add(new ArticleNotebookConfiguration());
            modelBuilder.Configurations.Add(new CitationConfiguration());
            modelBuilder.Configurations.Add(new DraftConfiguration());
            modelBuilder.Configurations.Add(new LookupConfiguration());
            modelBuilder.Configurations.Add(new LookupTypeConfiguration());
            modelBuilder.Configurations.Add(new PaperVersionConfiguration());
            modelBuilder.Configurations.Add(new ResearcherConfiguration());

            modelBuilder.Entity<CitationFieldValue>().HasKey(e => e.Id);
            modelBuilder.Entity<CitationResearcher>().HasKey(e => e.Id);
            modelBuilder.Entity<NotebookCitation>().HasKey(e => e.Id);
            modelBuilder.Entity<NotebookExternalCitation>().HasKey(e => e.Id);
            modelBuilder.Entity<NotebookSection>().HasKey(e => e.Id);
            modelBuilder.Entity<ParaPhrase>().HasKey(e => e.Id);
        }

        #region Entities
        internal DbSet<ArticleNotebook> ArticleNotebooks { get; set; }
        internal DbSet<Citation> Citations { get; set; }
        internal DbSet<CitationFieldValue> CitationFieldValues {get; set; }
        internal DbSet<CitationResearcher> CitationResearchers { get; set; }
        internal DbSet<Draft> Drafts { get; set; }
        internal DbSet<Domain.Models.Lookup> Lookups { get; set; }
        internal DbSet<LookupType> LookupTypes { get; set; }
        internal DbSet<NotebookCitation> NotebookCitations { get; set; }
        internal DbSet<NotebookExternalCitation> NotebookExternalCitations { get; set; }
        internal DbSet<NotebookSection> NotebookSections { get; set; }
        internal DbSet<PaperVersion> PageVersions { get; set; }
        internal DbSet<ParaPhrase> ParaPhrases { get; set; }
        internal DbSet<Researcher> Researchers { get; set; }

        #endregion

        public AWUContext(string nameOrConnectionString) : base(nameOrConnectionString) 
        {
            Database.SetInitializer<AWUContext>(null);
        }
        public AWUContext() : this(@"data source=localhost\SQL2019;initial catalog=AcademicWritingUtility;persist security info=True;user id=AcademicWritingUtilityUser;password=@c@d3m!c;MultipleActiveResultSets=True;App=EntityFramework")
        { }

    }
}
