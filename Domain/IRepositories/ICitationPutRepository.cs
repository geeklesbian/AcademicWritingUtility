using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.IRepositories
{
    public interface ICitationPutRepository : ICitationGetRepository
    {
        Citation PutCitation(Citation citation, List<CitationFieldValue> citationFieldValues);
        ParaPhrase PutParaPhrase(ParaPhrase paraPhrase);

    }
}
