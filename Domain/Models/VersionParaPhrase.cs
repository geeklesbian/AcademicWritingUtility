using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class VersionParaPhrase : BaseClass
    {
        public Guid VersionId { get; private set; }
        public Guid ParaPhraseId { get; private set; }

        public PaperVersion PaperVersion { get; private set; }
        public ParaPhrase ParaPhrase { get; private set; }

        internal static VersionParaPhrase New(Guid id, Guid versionId, Guid paraPhraseId)
        {
            return new VersionParaPhrase(id, versionId, paraPhraseId);
        }
        internal static VersionParaPhrase New(Guid versionId, Guid paraPhraseId)
        {
            return new VersionParaPhrase(versionId, paraPhraseId);
        }

        public VersionParaPhrase() : base() { }
        internal VersionParaPhrase(Guid id, Guid versionId, Guid paraPhraseId)
            : base(id)
        {
            SetValues(versionId, paraPhraseId);
        }
        internal VersionParaPhrase(Guid versionId, Guid paraPhraseId)
            : base()
        {
            SetValues(versionId, paraPhraseId);
        }
        private void SetValues(Guid versionId, Guid paraPhraseId)
        {
            VersionId = versionId;
            ParaPhraseId = paraPhraseId;
        }
    }
}
