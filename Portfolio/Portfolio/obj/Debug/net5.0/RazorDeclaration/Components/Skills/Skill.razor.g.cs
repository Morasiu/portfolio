// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Portfolio.Components.Skills
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio.Components.Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Skills\Skill.razor"
using Portfolio.Services;

#line default
#line hidden
#nullable disable
    public partial class Skill : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Skills\Skill.razor"
       

    [Parameter]
    public SkillName Name { get; set; } = SkillName.Unknown;

    [Parameter]
    public SkillLevel Level { get; set; } = SkillLevel.One;

    [CascadingParameter(Name = nameof(SkillList.TooltipText))]
    protected string TooltipText { get; set; }
    
    private string IconPath => SkillIconSerivce.IconsPath[Name];

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591