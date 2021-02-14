using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class PaperVersion : BaseClass
    {
        public Guid DraftId { get; private set; }
        public int Number { get; private set; }
        public string Name { get; private set; }

        public List<VersionParaPhrase> VersionParaPhrases { get; set; } = new List<VersionParaPhrase>();

        public Draft Draft { get; private set; }

        public static PaperVersion New(Guid draftId, int number, string name)
        {
            return new PaperVersion(draftId, number, name);
        }
        public static PaperVersion New(Guid id, Guid draftId, int number, string name)
        {
            return new PaperVersion(id, draftId, number, name);
        }
        public VersionParaPhrase NewVersionParaPhrase(Guid paraPhraseId)
        {
            return VersionParaPhrase.New(this.Id, paraPhraseId);
        }
        public static VersionParaPhrase NewVersionParaPhrase(Guid id, Guid versionId, Guid paraPhraseId)
        {
            return VersionParaPhrase.New(id, versionId, paraPhraseId);
        }

        public PaperVersion() : base() { }
        internal PaperVersion(Guid draftId, int number, string name = "") : base()
        {
            SetValues(draftId, number, name);
        }
        internal PaperVersion(Guid id, Guid draftId, int number, string name = "") : base(id)
        {
            SetValues(draftId, number, name);
        }
        private void SetValues(Guid draftId, int number, string name)
        {
            DraftId = draftId;
            Number = number;
            if (!string.IsNullOrEmpty(name)) { Name = name; }
        }
    }
}
