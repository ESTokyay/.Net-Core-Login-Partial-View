#pragma checksum "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8062c6057117d48dfcca74ca672d75488e95c589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8062c6057117d48dfcca74ca672d75488e95c589", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cari.Entities.Concrete.Person>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("log-out"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Login/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial_SaveCari", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial_Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
  
    var sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\" style=\"background-color:aqua\">\r\n\r\n            <div class=\"row\"><h1>");
#nullable restore
#line 16 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
                            Write(TempData["UserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1></div>
            <table>
                <tr><td><button type=""button"" class=""btn btn-primary btn-lg "" onclick=""document.location.reload(true);"">Cari Listele</button></td></tr>
                <tr><td><button type=""button"" class=""btn btn-primary btn-lg"" data-toggle=""modal"" data-target=""#newperson"">Yeni Cari</button></td></tr>

                <tr>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8062c6057117d48dfcca74ca672d75488e95c5896274", async() => {
                WriteLiteral("\r\n\r\n                            <a href=\"/Login/LogOut\" class=\"btn btn-primary btn-lg \">Çıkış</a>\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </td>
                </tr>

            </table>
        </div>
        <div class=""col-md-8"" style=""background-color:aquamarine"">

            <div class=""row"" style=""text-align: center""><h1 style=""background-color: brown"">Cari Defteri</h1></div>

            <div class=""row"">
                <table class=""table table-striped table-dark"">
                    <thead>
                        <tr>
                            <th scope=""col"">ID</th>
                            <th scope=""col"">Ünvan</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 47 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
                         foreach (var cariListe in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 1753, "\"", 1792, 3);
            WriteAttributeValue("", 1763, "getDatas(", 1763, 9, true);
#nullable restore
#line 49 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1772, cariListe.PersonID, 1772, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1791, ")", 1791, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>\r\n");
#nullable restore
#line 51 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
                                      
                                        ++sayac;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 54 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
                               Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
                               Write(cariListe.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2143, "\"", 2182, 2);
            WriteAttributeValue("", 2150, "/Home/Delete/", 2150, 13, true);
#nullable restore
#line 57 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2163, cariListe.PersonID, 2163, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm \">Sil</a></td>                           \r\n                                <td><a href=\"#Update\"  data-toggle=\"modal\"  class=\"update btn btn-primary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2370, "\"", 2409, 3);
            WriteAttributeValue("", 2380, "editdata(", 2380, 9, true);
#nullable restore
#line 58 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 2389, cariListe.PersonID, 2389, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2408, ")", 2408, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Düzenle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\sanca\OneDrive\Masaüstü\Login-master\Cari.WebUI\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>

            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <table class=""table"">

                        <thead class=""thead-dark"">

                            <tr>
                                <th scope=""col"">Telefonlar</th>
                            </tr>

                        </thead>
                        <tbody>
                            <tr>
                                <th id=""tel""></th>
                            </tr>
                        </tbody>

                    </table>
                </div>
                <div class=""col-md-6"">
                    <table class=""table"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">Adresler</th>
                            </tr>
                        </thead>
                        <tbody>
                            ");
            WriteLiteral("<tr>\r\n                                <th id=\"address\"></th>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8062c6057117d48dfcca74ca672d75488e95c58913413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8062c6057117d48dfcca74ca672d75488e95c58914530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cari.Entities.Concrete.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591