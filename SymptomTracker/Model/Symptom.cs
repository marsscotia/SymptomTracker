using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.Model
{
    public class Symptom
    {
        public Guid Id { get; set; }
        
        public string Description {get; set;}

        public DateTimeOffset Start { get; set; }

        public DateTimeOffset End { get; set; }

        public ICollection<SymptomTag> SymptomTags { get; set; }


    }
}
