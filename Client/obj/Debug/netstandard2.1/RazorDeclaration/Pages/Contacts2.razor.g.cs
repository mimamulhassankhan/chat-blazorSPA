#pragma checksum "f:\Website Works\Blazor\BlazingChat\Client\Pages\Contacts2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d277460e77e99c4fae69a9ebd9af982746ada5ed"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingChat.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using BlazingChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "f:\Website Works\Blazor\BlazingChat\Client\_Imports.razor"
using BlazingChat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "f:\Website Works\Blazor\BlazingChat\Client\Pages\Contacts2.razor"
using BlazingChat.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contacts")]
    public partial class Contacts2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "f:\Website Works\Blazor\BlazingChat\Client\Pages\Contacts2.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591