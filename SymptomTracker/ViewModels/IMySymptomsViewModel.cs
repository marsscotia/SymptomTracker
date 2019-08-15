using SymptomTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.ViewModels
{
    public interface IMySymptomsViewModel
    {
        ICollection<Symptom> Symptoms { get; set; }
    }
}
