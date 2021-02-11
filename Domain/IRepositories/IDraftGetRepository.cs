using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.IRepositories
{
    public interface IDraftGetRepository : IDisposable
    {
        Draft GetDraft(Guid id);
        IReadOnlyList<Draft> Drafts();
        PaperVersion GetPaperVersion(Guid id);
        IReadOnlyList<PaperVersion> GetPaperVersionsByDraftId(Guid draftId);
        IReadOnlyList<PaperVersion> GetPaperVersions();
    }
}
