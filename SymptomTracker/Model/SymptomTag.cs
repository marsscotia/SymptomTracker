using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.Model
{
    public class SymptomTag
    {
        public Guid SymptomId { get; set; }

        public Symptom Symptom { get; set; }

        public Guid TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
