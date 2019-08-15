using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.Data
{
    public class OwnedByBase : IOwnedBy
    {
        public string OwnedBy { get; private set; }

        public void SetOwnedBy(string ownedBy)
        {
            OwnedBy = ownedBy;
        }
    }
}
