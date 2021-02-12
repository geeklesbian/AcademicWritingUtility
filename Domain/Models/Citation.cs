using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Citation : BaseClass
    {
        public Guid CitationTypeId { get; private set; }
        public string Title { get; private set; }
        public string Name { get; private set; }
        public int YearPublished { get; private set; }
        public string Doi { get; private set; }


        public List<CitationResearcher> CitationResearchers { get; set; } = new List<CitationResearcher>();
        public List<CitationFieldValue> CitationFieldValues { get; set; } = new List<CitationFieldValue>();
        public List<NotebookCitation> NotebookCitations { get; set; } = new List<NotebookCitation>();
        public List<NotebookExternalCitation> NotebookExternalCitations { get; set; } = new List<NotebookExternalCitation>();
        public List<ParaPhrase> ParaPhrases { get; set; } = new List<ParaPhrase>();


        public virtual string GetFields<TEntity>()
           where TEntity : class, ICitation, new()
        {
            return JsonConvert.SerializeObject(new TEntity());
        }
        public TEntity GetCitation<TEntity>(string data)
            where TEntity : class, ICitation, new()
        {
            return JsonConvert.DeserializeObject<TEntity>(data);
        }
        public TEntity New<TEntity>(string values)
             where TEntity : class, IInCitation<TEntity>, new()
        {
            TEntity e = new TEntity();
            return e.New(values);
        }

        public Citation() : base() { }
        internal Citation(Guid citationTypeId, string title, string name, int yearPublished, string doi = "") : base()
        {
            SetValues(citationTypeId, title, name, yearPublished, doi);
        }
        internal Citation(Guid id, Guid citationTypeId, string title, string name, int yearPublished, string doi="") : base(id)
        {
            SetValues(citationTypeId, title, name, yearPublished, doi);
        }
        private void SetValues(Guid citationTypeId, string title, string name, int yearPublished, string doi)
        {
            CitationTypeId = citationTypeId;
            Title = title;
            Name = name;
            YearPublished = yearPublished;
            Doi = doi;
        }
    }
}
