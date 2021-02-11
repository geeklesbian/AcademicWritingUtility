using AcademicWritingUtility.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.IRepositories
{
    public interface IDraftPutRepository : IDraftGetRepository
    {
        Draft PutDraft(Draft draft);
        PaperVersion PutPaperVersion(PaperVersion paperVersion);
    }
}
