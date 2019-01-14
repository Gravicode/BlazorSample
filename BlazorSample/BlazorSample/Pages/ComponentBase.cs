using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSample.Pages
{
    public class ComponentBase : BlazorComponent
    {
        // Note that Blazor's dependency injection works even if using the
        // InjectAttribute in a component's base class.
        [Inject]
        protected IServiceWeather DataWeather { get; set; }

    }
}
