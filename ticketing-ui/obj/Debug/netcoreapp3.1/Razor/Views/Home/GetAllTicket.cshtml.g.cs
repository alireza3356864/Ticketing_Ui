#pragma checksum "D:\Project\ticketing-ui\ticketing-ui\Views\Home\GetAllTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90320407ae7ca406d90b7d7fabebb53cd65d8f01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAllTicket), @"mvc.1.0.view", @"/Views/Home/GetAllTicket.cshtml")]
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
#line 1 "D:\Project\ticketing-ui\ticketing-ui\Views\_ViewImports.cshtml"
using ticketing_ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\ticketing-ui\ticketing-ui\Views\_ViewImports.cshtml"
using ticketing_ui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90320407ae7ca406d90b7d7fabebb53cd65d8f01", @"/Views/Home/GetAllTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c36d3308998000b7d0ef1c55f28ef86567e573b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAllTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylegetallticket.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GetAllTicket-ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Project\ticketing-ui\ticketing-ui\Views\Home\GetAllTicket.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n        window.addEventListener(\"load\", function () {\r\n              var loadScreen = document.querySelector(\".preloader-container\").classList.add(\"loaded\");\r\n\r\n    })\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90320407ae7ca406d90b7d7fabebb53cd65d8f014908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<section class=\"row\">\r\n    <div");
            BeginWriteAttribute("_ngcontent-qpt-c23", " _ngcontent-qpt-c23=\"", 332, "\"", 353, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"col-sm-12\">\r\n        <div");
            BeginWriteAttribute("_ngcontent-qpt-c23", " _ngcontent-qpt-c23=\"", 387, "\"", 408, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"content-header\">\r\n            <div class=\"fs-5\">\r\n                <i class=\"fa fa-address-card\"></i>\r\n                نظرات و پیشنهادات من\r\n                <span");
            BeginWriteAttribute("_ngcontent-qpt-c23", " _ngcontent-qpt-c23=\"", 578, "\"", 599, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"float-right\">\r\n            </div>\r\n            <i");
            BeginWriteAttribute("_ngcontent-qpt-c23", " _ngcontent-qpt-c23=\"", 657, "\"", 678, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"ft-chevron-left c-gray m-r-3 m-l-3 ripple cursor-pointer\" placement=\"right\"></i><i");
            BeginWriteAttribute("_ngcontent-qpt-c23", " _ngcontent-qpt-c23=\"", 769, "\"", 790, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"ft-home c-gray m-r-3 m-l-3 ripple cursor-pointer\" placement=\"right\"></i></span>\r\n        </div><p");
            BeginWriteAttribute("_ngcontent-qpt-c23", " _ngcontent-qpt-c23=\"", 896, "\"", 917, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"content-sub-header mt-3\">در این صفحه میتوانید لیست پیشنهادات و نظرات خود را مشاهده کنید.</p><hr");
            BeginWriteAttribute("_ngcontent-qpt-c23", " _ngcontent-qpt-c23=\"", 1021, "\"", 1042, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""m-t-0 m-b-0"">
    </div>
</section>
<section class=""row"">
    <div class=""mb-3 mx-3 col-12 col-md-6 col-lg-6 col-xl-4"">
        <label for=""input-search"" class=""form-label"">لیست نظرات من</label>
        <div class=""search-container"">
            <input type=""text"" class=""form-control input-search"" id=""input-search"" placeholder=""جست و جو..."">
            <i class=""fa fa-search search-icon""></i>
        </div>
    </div>
</section>



<section class=""ftco-section"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-12"">

                <div class=""table-wrap"">
                    <table class=""table table-responsive-xl"">
                        <thead dir=""rtl"">
                            <tr>
                                <th");
            BeginWriteAttribute("id", " id=\"", 1849, "\"", 1854, 0);
            EndWriteAttribute();
            WriteLiteral(@">عنوان تیکت</th>
                                <th>موضوع تیکت</th>
                                <th>وضعیت</th>
                                <th>سال </th>
                                <th>کد تیکت </th>
                                <th>زمان ثبت نظر</th>
                                <th>گفت و گو</th>

                            </tr>
                        </thead>
                        <tbody sgs-ticket-section>
                        </tbody>
                    </table>

                </div>
                <div class=""d-flex justify-content-center preloader-container"">
                    <div class=""spinner-border"" role=""status"">
                        <span class=""visually-hidden"">Loading...</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<button class=""accordion"">Section 1</button>
<div class=""panel"">
    <div class=""row justify-content-start"">
        <section class=""col-8 col-md-6 col-l");
            WriteLiteral(@"g-4 card-text-ticketconversation-store"">
            <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                <section class=""card bg-primary text-white border-none"">
                    <section class=""card-body"">
                        <section class=""d-flex justify-content-between"">
                            <section class=""info-box-body"">
                                <p> شش  سس بب اا متن تیکت تستی </p>
                            </section>
                        </section>
                    </section>
                    <section class=""p-2 info-box-footer"">
                        <i class=""fas fa-clock mx-2""></i>
                        24:42
                    </section>
                </section>
            </a>
        </section>
    </div>
                     <div class=""row justify-content-end"">
                <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-admin justify-content-end"">
                    <a href=""#"" ");
            WriteLiteral(@"class=""text-decoration-none d-block mb-4 margin-botton"">
                        <section class=""card bg-gray-costom  text-white"">
                            <section class=""card-body"">
                                <section class=""d-flex justify-content-between"">
                                    <section class=""info-box-body"">
                                        <p>متن تییسشببسیبسیسین تبنشسیتن تتن ت تشسیبتن تت شستب تینت شیستبیکتبشت ت تشکتشیتشبتسیمتبشبتشیمستب کت تتشببشیتشیکتشسیتبنیتبک ت تستی </p>
                                    </section>

                                </section>
                            </section>
                            <section class=""p-2 info-box-footer"">
                                <i class=""fas fa-clock mx-2""></i>
                                  24:42
                            </section>
                        </section>
                    </a>
                </section>
             </div>
                          <div class=""row just");
            WriteLiteral(@"ify-content-end"">
                <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-admin justify-content-end"">
                    <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                        <section class=""card bg-gray-costom  text-white"">
                            <section class=""card-body"">
                                <section class=""d-flex justify-content-between"">
                                    <section class=""info-box-body"">
                                        <p>متن تییسشببسیبسیسین تبنشسیتن تتن ت تشسیبتن تت شستب تینت شیستبیکتبشت ت تشکتشیتشبتسیمتبشبتشیمستب کت تتشببشیتشیکتشسیتبنیتبک ت تستی </p>
                                    </section>

                                </section>
                            </section>
                            <section class=""p-2 info-box-footer"">
                                <i class=""fas fa-clock mx-2""></i>
                                  24:42
                            </se");
            WriteLiteral(@"ction>
                        </section>
                    </a>
                </section>
             </div><div class=""row justify-content-start"">
        <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-store"">
            <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                <section class=""card bg-primary text-white border-none"">
                    <section class=""card-body"">
                        <section class=""d-flex justify-content-between"">
                            <section class=""info-box-body"">
                                <p> شش  سس بب اا متن تیکت تستی </p>
                            </section>
                        </section>
                    </section>
                    <section class=""p-2 info-box-footer"">
                        <i class=""fas fa-clock mx-2""></i>
                        24:42
                    </section>
                </section>
            </a>
        </section>
    </div>
</di");
            WriteLiteral(@"v>
<button class=""accordion"">Section 1</button>
<div class=""panel"">
                     <div class=""row justify-content-end"">
                <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-admin justify-content-end"">
                    <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                        <section class=""card bg-gray-costom  text-white"">
                            <section class=""card-body"">
                                <section class=""d-flex justify-content-between"">
                                    <section class=""info-box-body"">
                                        <p>متن تییسشببسیبسیسین تبنشسیتن تتن ت تشسیبتن تت شستب تینت شیستبیکتبشت ت تشکتشیتشبتسیمتبشبتشیمستب کت تتشببشیتشیکتشسیتبنیتبک ت تستی </p>
                                    </section>

                                </section>
                            </section>
                            <section class=""p-2 info-box-footer"">
                            ");
            WriteLiteral(@"    <i class=""fas fa-clock mx-2""></i>
                                  24:42
                            </section>
                        </section>
                    </a>
                </section>
             </div>
                          <div class=""row justify-content-end"">
                <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-admin justify-content-end"">
                    <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                        <section class=""card bg-gray-costom  text-white"">
                            <section class=""card-body"">
                                <section class=""d-flex justify-content-between"">
                                    <section class=""info-box-body"">
                                        <p>متن تییسشببسیبسیسین تبنشسیتن تتن ت تشسیبتن تت شستب تینت شیستبیکتبشت ت تشکتشیتشبتسیمتبشبتشیمستب کت تتشببشیتشیکتشسیتبنیتبک ت تستی </p>
                                    </section>

              ");
            WriteLiteral(@"                  </section>
                            </section>
                            <section class=""p-2 info-box-footer"">
                                <i class=""fas fa-clock mx-2""></i>
                                  24:42
                            </section>
                        </section>
                    </a>
                </section>
             </div>
    <div class=""row justify-content-start"">
        <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-store"">
            <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                <section class=""card bg-primary text-white border-none"">
                    <section class=""card-body"">
                        <section class=""d-flex justify-content-between"">
                            <section class=""info-box-body"">
                                <p> شش  سس بب اا متن تیکت تستی </p>
                            </section>
                        </section>
            ");
            WriteLiteral(@"        </section>
                    <section class=""p-2 info-box-footer"">
                        <i class=""fas fa-clock mx-2""></i>
                        24:42
                    </section>
                </section>
            </a>
        </section>
    </div> <div class=""row justify-content-start"">
        <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-store"">
            <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                <section class=""card bg-primary text-white border-none"">
                    <section class=""card-body"">
                        <section class=""d-flex justify-content-between"">
                            <section class=""info-box-body"">
                                <p> شش  سس بب اا متن تیکت تستی </p>
                            </section>
                        </section>
                    </section>
                    <section class=""p-2 info-box-footer"">
                        <i class=""fas fa-cl");
            WriteLiteral(@"ock mx-2""></i>
                        24:42
                    </section>
                </section>
            </a>
        </section>
    </div>
</div>
<button class=""accordion"">Section 1</button>
<div class=""panel"">
    <div class=""row justify-content-start"">
        <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-store"">
            <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                <section class=""card bg-primary text-white border-none"">
                    <section class=""card-body"">
                        <section class=""d-flex justify-content-between"">
                            <section class=""info-box-body"">
                                <p> شش  سس بب اا متن تیکت تستی </p>
                            </section>
                        </section>
                    </section>
                    <section class=""p-2 info-box-footer"">
                        <i class=""fas fa-clock mx-2""></i>
                        24");
            WriteLiteral(@":42
                    </section>
                </section>
            </a>
        </section>
    </div> <div class=""row justify-content-start"">
        <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-store"">
            <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                <section class=""card bg-primary text-white border-none"">
                    <section class=""card-body"">
                        <section class=""d-flex justify-content-between"">
                            <section class=""info-box-body"">
                                <p> شش  سس بب اا متن تیکت تستی </p>
                            </section>
                        </section>
                    </section>
                    <section class=""p-2 info-box-footer"">
                        <i class=""fas fa-clock mx-2""></i>
                        24:42
                    </section>
                </section>
            </a>
        </section>
    </div>
       ");
            WriteLiteral(@"          <div class=""row justify-content-end"">
                <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-admin justify-content-end"">
                    <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                        <section class=""card bg-gray-costom  text-white"">
                            <section class=""card-body"">
                                <section class=""d-flex justify-content-between"">
                                    <section class=""info-box-body"">
                                        <p>متن تییسشببسیبسیسین تبنشسیتن تتن ت تشسیبتن تت شستب تینت شیستبیکتبشت ت تشکتشیتشبتسیمتبشبتشیمستب کت تتشببشیتشیکتشسیتبنیتبک ت تستی </p>
                                    </section>

                                </section>
                            </section>
                            <section class=""p-2 info-box-footer"">
                                <i class=""fas fa-clock mx-2""></i>
                                  24:42
  ");
            WriteLiteral(@"                          </section>
                        </section>
                    </a>
                </section>
             </div>
                          <div class=""row justify-content-end"">
                <section class=""col-8 col-md-6 col-lg-4 card-text-ticketconversation-admin justify-content-end"">
                    <a href=""#"" class=""text-decoration-none d-block mb-4 margin-botton"">
                        <section class=""card bg-gray-costom  text-white"">
                            <section class=""card-body"">
                                <section class=""d-flex justify-content-between"">
                                    <section class=""info-box-body"">
                                        <p>متن تییسشببسیبسیسین تبنشسیتن تتن ت تشسیبتن تت شستب تینت شیستبیکتبشت ت تشکتشیتشبتسیمتبشبتشیمستب کت تتشببشیتشیکتشسیتبنیتبک ت تستی </p>
                                    </section>

                                </section>
                            </section>
            ");
            WriteLiteral(@"                <section class=""p-2 info-box-footer"">
                                <i class=""fas fa-clock mx-2""></i>
                                  24:42
                            </section>
                        </section>
                    </a>
                </section>
             </div>
</div>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2"" crossorigin=""anonymous""></script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90320407ae7ca406d90b7d7fabebb53cd65d8f0123336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90320407ae7ca406d90b7d7fabebb53cd65d8f0124376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
