using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.Data
{
    /// <summary>
    /// This interface defines a key which is added to entities upon creation,
    /// to associate them with a user and protect access to them
    /// 
    /// Based on code from https://www.thereformedprogrammer.net/part-2-handling-data-authorization-asp-net-core-and-entity-framework-core/
    /// </summary>
    public interface IOwnedBy
    {
        string OwnedBy { get; }

        void SetOwnedBy(string ownedBy);

    }
}
