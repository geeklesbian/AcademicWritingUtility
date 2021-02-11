using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.IRepositories
{
    public interface ICitationGetRepository : IDisposable
    {
        Citation GetCitation(Guid id);
        CitationFieldValue GetCitationFieldValue(Guid id);
        IReadOnlyList<CitationFieldValue> GetCitationFieldValuesByCitationId(Guid citationId);
        ParaPhrase GetParaPhrase(Guid id);
        IReadOnlyList<ParaPhrase> GetParaPhraseByCitationId(Guid citationId);
        IReadOnlyList<ParaPhrase> GetParaPhraseByVersionId(Guid versionId);
    }
}
