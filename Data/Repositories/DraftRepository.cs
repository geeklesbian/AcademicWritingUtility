using AcademicWritingUtility.Domain.IRepositories;
using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Repositories
{
    public class DraftRepository : IDraftPutRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Draft> Drafts()
        {
            throw new NotImplementedException();
        }

        public Draft GetDraft(Guid id)
        {
            throw new NotImplementedException();
        }

        public PaperVersion GetPaperVersion(Guid id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<PaperVersion> GetPaperVersions()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<PaperVersion> GetPaperVersionsByDraftId(Guid draftId)
        {
            throw new NotImplementedException();
        }

        public Draft PutDraft(Draft draft)
        {
            throw new NotImplementedException();
        }

        public PaperVersion PutPaperVersion(PaperVersion paperVersion)
        {
            throw new NotImplementedException();
        }
    }
}
