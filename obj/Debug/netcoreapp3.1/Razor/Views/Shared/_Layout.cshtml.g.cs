#pragma checksum "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "735b99e4a8543bd0db60853d0af82ff238846b92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\хну\курсач\Курсач\Views\_ViewImports.cshtml"
using Курсач;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\хну\курсач\Курсач\Views\_ViewImports.cshtml"
using Курсач.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"735b99e4a8543bd0db60853d0af82ff238846b92", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b30e1fcb2ed95335fbfcb7b35b8212e7df55c40a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "735b99e4a8543bd0db60853d0af82ff238846b925204", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Humanitrian UA </title>\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN\" crossorigin=\"anonymous\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "735b99e4a8543bd0db60853d0af82ff238846b926048", async() => {
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
                WriteLiteral("\r\n    <link rel=\"stylesheet\"\r\n          href=\"https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "735b99e4a8543bd0db60853d0af82ff238846b928048", async() => {
                WriteLiteral(@"
    <header class=""header"">
        <div class=""app-container"">
            <nav class=""nav"">

                <ul class=""nav-list"">

                    <li class=""nav-item""><a class=""nav-link"" href=""/all-container"">Harvest</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""/news/newsN"">News</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""/""><img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/%D0%A2%D1%80%D0%B8%D0%B7%D1%83%D0%B1.svg/1200px-%D0%A2%D1%80%D0%B8%D0%B7%D1%83%D0%B1.svg.png"" alt=""Alternate Text"" /></a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""/start-container"">Start harvest</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""/contacts"">Contacts</a></li>
                </ul>
            </nav>
        </div>
    </header>
    ");
#nullable restore
#line 28 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "735b99e4a8543bd0db60853d0af82ff238846b929428", async() => {
                    WriteLiteral("\r\n    ");
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
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.js\">\r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "735b99e4a8543bd0db60853d0af82ff238846b9210675", async() => {
                    WriteLiteral("\r\n    ");
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "735b99e4a8543bd0db60853d0af82ff238846b9211822", async() => {
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 35 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        footer {
        background-color: #f8f9fa;
        padding: 40px 0;
        color: #495057;
        }

        footer h2 {
        color: #007bff;
        }

        footer p {
        font-size: 16px;
        }

        footer img {
        max-width: 100%;
        height: auto;
        margin-top: 20px;
        }
    </style>
    ");
#nullable restore
#line 58 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scriptss", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 59 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
      
        var isAuthenticatedCookie = Context.Request.Cookies["IsAuthenticated"];
        var showElement = User.Identity.IsAuthenticated || (isAuthenticatedCookie != null && isAuthenticatedCookie.ToLower() == "true");
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
     if (showElement)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <a class=""all-page-ico"" href=""/logout"" class=""login-ico"">
            <?xml version=""1.0"" encoding=""iso-8859-1"" ?>
            <!-- Uploaded to: SVG Repo, www.svgrepo.com, Generator: SVG Repo Mixer Tools -->
            <svg fill=""#000000"" height=""800px"" width=""800px"" version=""1.1"" id=""Capa_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink""
                 viewBox=""0 0 384.971 384.971"" xml:space=""preserve"">
<g>
            <g id=""Sign_Out"">
            <path d=""M180.455,360.91H24.061V24.061h156.394c6.641,0,12.03-5.39,12.03-12.03s-5.39-12.03-12.03-12.03H12.03
			C5.39,0.001,0,5.39,0,12.031V372.94c0,6.641,5.39,12.03,12.03,12.03h168.424c6.641,0,12.03-5.39,12.03-12.03
			C192.485,366.299,187.095,360.91,180.455,360.91z"" />



























































































































");
                WriteLiteral(@"



































































































































































































































































































































































































            <path d=""M381.481,184.088l-83.009-84.2c-4.704-4.752-12.319-4.74-17.011,0c-4.704,4.74-4.704,12.439,0,17.179l62.558,63.46H96.279
			c-6.641,0-12.03,5.438-12.03,12.151c0,6.713,5.39,12.151,12.03,12.151h247.74l-62.558,63.46c-4.704,4.752-4.70");
                WriteLiteral(@"4,12.439,0,17.179
			c4.704,4.752,12.319,4.752,17.011,0l82.997-84.2C386.113,196.588,386.161,188.756,381.481,184.088z"" />


































































































































































































































































































































































































































































");
                WriteLiteral(@"




























































	</g>
            <g>
	</g>
            <g>
	</g>
            <g>
	</g>
            <g>
	</g>
            <g>
	</g>
            <g>
	</g>
</g>
</svg>
        </a>
");
#nullable restore
#line 1116 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <a class=""all-page-ico"" href=""/login"" class=""login-ico"">
            <?xml version=""1.0"" encoding=""utf-8"" ?>
            <svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" viewBox=""0 0 122.88 122.88"" style=""enable-background:new 0 0 122.88 122.88"" xml:space=""preserve""><g><path d=""M61.44,0c8.32,0,16.25,1.66,23.5,4.66l0.11,0.05c7.47,3.11,14.2,7.66,19.83,13.3l0,0c5.66,5.65,10.22,12.42,13.34,19.95 c3.01,7.24,4.66,15.18,4.66,23.49c0,8.32-1.66,16.25-4.66,23.5l-0.05,0.11c-3.12,7.47-7.66,14.2-13.3,19.83l0,0 c-5.65,5.66-12.42,10.22-19.95,13.34c-7.24,3.01-15.18,4.66-23.49,4.66c-8.31,0-16.25-1.66-23.5-4.66l-0.11-0.05 c-7.47-3.11-14.2-7.66-19.83-13.29L18,104.87C12.34,99.21,7.78,92.45,4.66,84.94C1.66,77.69,0,69.76,0,61.44s1.66-16.25,4.66-23.5 l0.05-0.11c3.11-7.47,7.66-14.2,13.29-19.83L18.01,18c5.66-5.66,12.42-10.22,19.94-13.34C45.19,1.66,53.12,0,61.44,0L61.44,0z M16.99,94.47l0.24-0.14c5.9-3.29,21.26-4.38,27.64-8.83c0.47-0.7,0.97-1.72,1.46");
                WriteLiteral(@"-2.83c0.73-1.67,1.4-3.5,1.82-4.74 c-1.78-2.1-3.31-4.47-4.77-6.8l-4.83-7.69c-1.76-2.64-2.68-5.04-2.74-7.02c-0.03-0.93,0.13-1.77,0.48-2.52 c0.36-0.78,0.91-1.43,1.66-1.93c0.35-0.24,0.74-0.44,1.17-0.59c-0.32-4.17-0.43-9.42-0.23-13.82c0.1-1.04,0.31-2.09,0.59-3.13 c1.24-4.41,4.33-7.96,8.16-10.4c2.11-1.35,4.43-2.36,6.84-3.04c1.54-0.44-1.31-5.34,0.28-5.51c7.67-0.79,20.08,6.22,25.44,12.01 c2.68,2.9,4.37,6.75,4.73,11.84l-0.3,12.54l0,0c1.34,0.41,2.2,1.26,2.54,2.63c0.39,1.53-0.03,3.67-1.33,6.6l0,0 c-0.02,0.05-0.05,0.11-0.08,0.16l-5.51,9.07c-2.02,3.33-4.08,6.68-6.75,9.31C73.75,80,74,80.35,74.24,80.7 c1.09,1.6,2.19,3.2,3.6,4.63c0.05,0.05,0.09,0.1,0.12,0.15c6.34,4.48,21.77,5.57,27.69,8.87l0.24,0.14 c6.87-9.22,10.93-20.65,10.93-33.03c0-15.29-6.2-29.14-16.22-39.15c-10-10.03-23.85-16.23-39.14-16.23 c-15.29,0-29.14,6.2-39.15,16.22C12.27,32.3,6.07,46.15,6.07,61.44C6.07,73.82,10.13,85.25,16.99,94.47L16.99,94.47L16.99,94.47z"" /></g></svg>
        </a>
");
#nullable restore
#line 1123 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 1125 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 1126 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
      
        var isAdminCookie = Context.Request.Cookies["IsAdmin"];
        var showElement1 = User.Identity.IsAuthenticated || (isAdminCookie != null && isAdminCookie.ToLower() == "true");
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 1130 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
     if (showElement1)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <button style=""position:fixed; left:20px;bottom:40px"" class=""btn btn-primary"" type=""button"" data-bs-toggle=""offcanvas"" data-bs-target=""#staticBackdrop"" aria-controls=""staticBackdrop"">
            Адміністративна панель
        </button>
        <div class=""offcanvas offcanvas-start"" data-bs-backdrop=""static"" tabindex=""-1"" id=""staticBackdrop"" aria-labelledby=""staticBackdropLabel"">
            <div class=""offcanvas-header"">
                <h5 class=""offcanvas-title"" id=""staticBackdropLabel"">Посилання адміністративної панелі</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""offcanvas"" aria-label=""Закрити""></button>
            </div>
            <div class=""offcanvas-body"">
                <div class=""container mt-4"">
                    <div class=""row"">
                        <a href=""/all-container_admin"" class=""btn btn-primary mr-2"">Перегляд таблиці всіх контейнерів</a>
                    </div>
                    <div class=""row mt-2"">
                  ");
                WriteLiteral(@"      <a href=""/all-news_admin"" class=""btn btn-primary mr-2"">Перегляд таблиці всіх новин</a>
                    </div>
                    <div class=""row mt-2"">
                        <a href=""/all-users_admin"" class=""btn btn-primary mr-2"">Перегляд таблиці всіх користувачів</a>
                    </div>
                    <div class=""row mt-2"">
                        <a href=""/all-noncontainer_admin"" class=""btn btn-primary mr-2"">Перегляд таблиці всіх запропонованих контейнерів</a>
                    </div>
                </div>

            </div>
        </div>
");
#nullable restore
#line 1158 "D:\хну\курсач\Курсач\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL"" crossorigin=""anonymous"">
    </script>
    <div class="" my-5"">
        <footer class=""text-center text-lg-start text-white"" style=""background-color: #45526e"">
            <div class=""p-4 pb-0"">
                <section");
                BeginWriteAttribute("class", " class=\"", 10190, "\"", 10198, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""row"">
                        <div class=""col-md-3 col-lg-3 col-xl-3 mx-auto mt-3"">
                            <h6 class=""text-uppercase mb-4 font-weight-bold"">
                                Гуманітарка UA
                            </h6>
                            <p>
                                ""We help fulfill the dreams of those in need. Join the circle of kindness.""
                            </p>
                        </div>
                        <hr class=""w-100 clearfix d-md-none"" />
                        <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mt-3"">
                            <h6 class=""text-uppercase mb-4 font-weight-bold"">Harvest</h6>
                            <p>
                                <a href=""/all-container"" class=""text-white"">All Harvest</a>
                            </p>
                            <p>
                                <a href=""/start-container"" class=""text-white"">Suggest a collection</a>
 ");
                WriteLiteral(@"                           </p>
                        </div>
                        <hr class=""w-100 clearfix d-md-none"" />
                        <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mt-3"">
                            <h6 class=""text-uppercase mb-4 font-weight-bold"">
                                News
                            </h6>
                            <p>
                                <a href=""/news/newsN"" class=""text-white"">All news</a>
                            </p>
                        </div>
                        <hr class=""w-100 clearfix d-md-none"" />
                        <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mt-3"">
                            <h6 class=""text-uppercase mb-4 font-weight-bold"">Contact</h6>
                            <p><i class=""fas fa-home mr-3""></i>Ukraine</p>
                            <p><i class=""fas fa-envelope mr-3""></i> info@gmail.com</p>
                            <p><a href=""callto:+ 380 676 018 496"" class=""fas f");
                WriteLiteral(@"a-phone mr-3""></a> + 380 676 018 496</p>
                            <p><a href=""callto:+ 380 676 018 496"" class=""fas fa-phone mr-3""></a> + 380 676 018 496</p>
                        </div>
                        <!-- Grid column -->
                    </div>
                    <!-- Grid row -->
                </section>
                <!-- Section: Links -->

                <hr class=""my-3"" />

                <!-- Section: Copyright -->
                <section class=""p-3 pt-0"">
                    <div class=""row d-flex align-items-center"">
                        <!-- Grid column -->
                        <div class=""col-md-7 col-lg-8 text-center text-md-start"">
                            <!-- Copyright -->
                            <div class=""p-3"">
                                © 2020 Copyright:
                                <a class=""text-white"" target=""_blank"" href=""https://t.me/+BY_vmco3JqI3NGNi"">Гуманітарка UA</a>
                            </div>
              ");
                WriteLiteral(@"              <!-- Copyright -->
                        </div>
                        <!-- Grid column -->
                        <!-- Grid column -->
                        <!-- Grid column -->
                    </div>
                </section>
                <!-- Section: Copyright -->
            </div>
            <!-- Grid container -->
        </footer>
        <!-- Footer -->
    </div>
    <!-- End of .container -->

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
            WriteLiteral("\r\n</html>\r\n");
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
