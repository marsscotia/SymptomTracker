using SymptomTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.Model
{
    public class Tag: OwnedByBase
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public ICollection<SymptomTag> SymptomTags { get; set; }
    }
}
