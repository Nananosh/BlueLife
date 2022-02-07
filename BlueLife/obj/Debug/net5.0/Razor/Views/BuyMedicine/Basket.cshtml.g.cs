#pragma checksum "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c33f6c66af8e66bb624a36c9d5b68ef0e34bbbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BuyMedicine_Basket), @"mvc.1.0.view", @"/Views/BuyMedicine/Basket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c33f6c66af8e66bb624a36c9d5b68ef0e34bbbd", @"/Views/BuyMedicine/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e855bbce0c3993d68d6b3cb5e7f77e92c021fa7", @"/Views/_ViewImports.cshtml")]
    public class Views_BuyMedicine_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketMedicine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Medicine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BuyMedicine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMedicineInBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasketToOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"content\">\r\n");
#nullable restore
#line 4 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
           int totalAmount = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
         foreach (var medicine in @Model)
        {
            {
                totalAmount += medicine.Quantity * medicine.PharmacyWarehouse.Price;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mt-5 border-bottom pb-3\">\r\n                <div class=\"col-lg-2\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 405, "\"", 460, 1);
#nullable restore
#line 12 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
WriteAttributeValue("", 411, medicine.PharmacyWarehouse.ReleaseMedicine.Image, 411, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"medicine\" style=\"height: 150px;width: 150px;\"/>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n");
#nullable restore
#line 15 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                     if (@medicine.PharmacyWarehouse.IsRecipe)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"text-danger\">Для этого лекарства требуется рецепт</span>\r\n");
#nullable restore
#line 18 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"h5\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c33f6c66af8e66bb624a36c9d5b68ef0e34bbbd7178", async() => {
#nullable restore
#line 20 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                                                                                                                       Write(medicine.PharmacyWarehouse.ReleaseMedicine.Medicine.MedicineName.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                                                                                WriteLiteral(medicine.PharmacyWarehouse.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div>Количесво : ");
#nullable restore
#line 22 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                                Write(medicine.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div>Стоимость : ");
#nullable restore
#line 23 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                                Write(medicine.PharmacyWarehouse.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"col-lg-5 d-flex justify-content-end align-items-start\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c33f6c66af8e66bb624a36c9d5b68ef0e34bbbd10686", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                                                                                                                 WriteLiteral(medicine.PharmacyWarehouse.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                                                                                                                                                                   WriteLiteral(User.Claims.ElementAt(0).Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-5\">\r\n            <div class=\"col-lg-12 d-flex justify-content-end align-items-baseline\">\r\n                <p>Итоговая сумма с учётом скидки: </p>\r\n                <p class=\"text-success h3 ml-2\">");
#nullable restore
#line 33 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                                           Write(ViewBag.FullPriceByDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"h4 ml-1\">BYN</div>\r\n            </div>\r\n            <div class=\"col-lg-12 d-flex justify-content-end align-items-start\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c33f6c66af8e66bb624a36c9d5b68ef0e34bbbd15015", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 2134, "\"", 2173, 1);
#nullable restore
#line 38 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
WriteAttributeValue("", 2142, User.Claims.ElementAt(0).Value, 2142, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
#nullable restore
#line 39 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                     if (Model.Count > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\">Оформить заказ</button>\r\n");
#nullable restore
#line 42 "C:\Users\nanan\RiderProjects\BlueLife\BlueLife\Views\BuyMedicine\Basket.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketMedicine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
