using AcademicWritingUtility.Domain.IRepositories;
using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Data.Repositories
{
    public class CitationRepository : DisposableRepository, ICitationPutRepository
    {
        public Citation GetCitation(Guid id)
        {
            throw new NotImplementedException();
        }

        public CitationFieldValue GetCitationFieldValue(Guid id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<CitationFieldValue> GetCitationFieldValuesByCitationId(Guid citationId)
        {
            throw new NotImplementedException();
        }

        public ParaPhrase GetParaPhrase(Guid id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<ParaPhrase> GetParaPhraseByCitationId(Guid citationId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<ParaPhrase> GetParaPhraseByVersionId(Guid versionId)
        {
            throw new NotImplementedException();
        }

        public Citation PutCitation(Citation citation, List<CitationFieldValue> citationFieldValues)
        {
            throw new NotImplementedException();
        }

        public ParaPhrase PutParaPhrase(ParaPhrase paraPhrase)
        {
            throw new NotImplementedException();
        }

        private bool _isDisposed = false;
        public override void Dispose()
        {
            this.Dispose(true);
        }
        protected override void Dispose(bool dispose)
        {
            if(!_isDisposed && dispose)
            {

            }
            _isDisposed = dispose;
        }

    }
}
