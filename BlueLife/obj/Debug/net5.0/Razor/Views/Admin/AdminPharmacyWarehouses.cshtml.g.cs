#pragma checksum "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\Admin\AdminPharmacyWarehouses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa3e9ce7aef18bc7c62f7bb4d3ee57ad25d35f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminPharmacyWarehouses), @"mvc.1.0.view", @"/Views/Admin/AdminPharmacyWarehouses.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\_ViewImports.cshtml"
using BlueLife;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\_ViewImports.cshtml"
using BlueLife.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa3e9ce7aef18bc7c62f7bb4d3ee57ad25d35f6", @"/Views/Admin/AdminPharmacyWarehouses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e855bbce0c3993d68d6b3cb5e7f77e92c021fa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminPharmacyWarehouses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\Admin\AdminPharmacyWarehouses.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://kendo.cdn.telerik.com/2022.1.119/js/jszip.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa3e9ce7aef18bc7c62f7bb4d3ee57ad25d35f63425", async() => {
                WriteLiteral(@"
<br/><br/><br/>
<div id=""example"">
    <div id=""grid""></div>
    <script>
               $(document).ready(function() {
                   $(""#grid"").kendoGrid({
                       dataSource: {
                           transport: {
                               read: """);
#nullable restore
#line 14 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\Admin\AdminPharmacyWarehouses.cshtml"
                                 Write(Url.Action("GetAllPharmacyWarehouses", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                               update: {\r\n                                   url: \"");
#nullable restore
#line 16 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\Admin\AdminPharmacyWarehouses.cshtml"
                                    Write(Url.Action("EditPharmacyWarehouses", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                                   dataType: \"json\",\r\n                                   type: \"POST\"\r\n                               },\r\n                               create:{\r\n                                   url: \"");
#nullable restore
#line 21 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\Admin\AdminPharmacyWarehouses.cshtml"
                                    Write(Url.Action("AddPharmacyWarehouses", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                                   dataType: \"json\",\r\n                                   type: \"POST\"  \r\n                               },\r\n                               destroy: {\r\n                                   url: \"");
#nullable restore
#line 26 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\Admin\AdminPharmacyWarehouses.cshtml"
                                    Write(Url.Action("DeletePharmacyWarehouses", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                                   dataType: ""json"",
                                   type: ""DELETE""
                               }
                           },
                           schema: {
                               model: {
                                   id: ""Id"",
                                   fields: {
                                       Id: { editable: false, from: ""id"", type: ""number"" },
                                       ReleaseMedicine: { from: ""releaseMedicine"", validation: {required: true} }, 
                                       ReleaseMedicineId: {from: ""releaseMedicineId"", validation: {required: true} },
                                       Price: { from: ""price"", type: ""number"", validation: {required: true }},
                                       Quantity: { from: ""quantity"", type: ""number"", validation: {required: true }},
                                       IsRecipe: { from: ""isRecipe"", type: ""boolean""}
                                 ");
                WriteLiteral(@"  }
                               }
                           },
                           pageSize: 20,
                           serverPaging: false,
                           serverFiltering: false,
                           serverSorting: false
                       },
                       height: 550,
                       editable: ""popup"",
                       filterable: true,
                       sortable: true,
                       pageable: true,
                       toolbar: [
                           {name: ""create""},
                           {name: ""excel""}
                       ],
                       excel: {
                           fileName: ""PharmacyWareyhouses.xlsx"",
                           filterable: true,
                           allPages: true
                       },
                       columns: [
                           {
                               field:""Id"",
                               filterable: false,
      ");
                WriteLiteral(@"                         exportable: { pdf: false, excel: false }
                           },
                           {
                               field: ""ReleaseMedicine.fullReleaseMedicine"",
                               title: ""Выпущенный препарат"",
                               editor: releaseMedicineEditor
                           }, 
                           {
                               field: ""Price"",
                               title: ""Цена"",
                           }, 
                           {
                               field: ""Quantity"",
                               title: ""Количество""
                           },
                           {
                               field: ""IsRecipe"",
                               title: ""Рецепт""  
                           },
                           {
                               command: ""edit"", 
                           },
                           {
                               command");
                WriteLiteral(@": ""destroy""
                           }
                       ]
                   });
               });
               
               function releaseMedicineEditor(container, options) {
                   $('<input required name=""ReleaseMedicineId"">')
                       .appendTo(container)
                       .kendoDropDownList({
                           dataTextField: ""fullReleaseMedicine"",
                           dataValueField: ""id"",
                           height: 500,
                           dataSource: {
                               transport: {
                                   read: {
                                       url: """);
#nullable restore
#line 106 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\Admin\AdminPharmacyWarehouses.cshtml"
                                        Write(Url.Action("GetAllReleaseMedicine", "Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                                       dataType: ""json"",
                                       cache: false
                                   }
                               }
                           }
                       });
               }
           </script>
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
