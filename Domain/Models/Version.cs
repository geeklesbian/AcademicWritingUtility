using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicWritingUtility.Domain.Models
{
    public class Version : BaseClass
    {
        public Guid DraftId { get; private set; }
        public int Number { get; private set; }
        public string Name { get; private set; }
        public List<ParaPhrase> ParaPhrases { get; set; } = new List<ParaPhrase>();

        public Version() : base() { }
        public Version(Guid draftId, int number, string name) : base()
        {
            SetValues(draftId, number, name);
        }
        public Version(Guid id, Guid draftId, int number, string name) : base(id)
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
