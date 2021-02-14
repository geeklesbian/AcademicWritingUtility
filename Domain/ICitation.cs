using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain
{
    public interface ICitation : IBaseClass
    {
        Guid CitationTypeId { get; }
        string Title { get; }
        string Name { get; }
        int YearPublished { get; }
        string Doi { get; }

        
        List<Models.CitationResearcher> CitationResearchers { get; set; }
        List<Models.CitationFieldValue> CitationFieldValues { get; set; }
        List<Models.NotebookCitation> NotebookCitations { get; set; }
        List<Models.NotebookExternalCitation> NotebookExternalCitations { get; set; }
        List<Models.ParaPhrase> ParaPhrases { get; set; }
        

        string GetFields<TEntity>() where TEntity : class, ICitation, new();
        TEntity GetCitation<TEntity>(string data) where TEntity : class, ICitation, new();
        TEntity New<TEntity>(string values) where TEntity : class, IInCitation<TEntity>, new();
    }
    public interface IInCitation<TEntity> : ICitation
    {
        TEntity New(string values);
    }
}