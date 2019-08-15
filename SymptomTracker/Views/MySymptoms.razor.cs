using Microsoft.AspNetCore.Components;
using SymptomTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.Views
{
    /// <summary>
    /// Code-behind approach detailed at https://www.telerik.com/blogs/using-a-code-behind-approach-to-blazor-components
    /// </summary>
    public class MySymptomsBase: ComponentBase
    {
        [Inject] protected IMySymptomsViewModel ViewModel { get; set; }
    }
}
