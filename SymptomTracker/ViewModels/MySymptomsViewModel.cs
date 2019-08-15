using SymptomTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.ViewModels
{
    public class MySymptomsViewModel: IMySymptomsViewModel
    {
        public ICollection<Symptom> Symptoms { get; set; }
    }
}
