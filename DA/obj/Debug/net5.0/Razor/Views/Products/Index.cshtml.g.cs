#pragma checksum "D:\DAmoinhat\DA\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9c0a27e36080bc1e245bd1486cdd43b289e93b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "D:\DAmoinhat\DA\Views\_ViewImports.cshtml"
using DA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DAmoinhat\DA\Views\_ViewImports.cshtml"
using DA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9c0a27e36080bc1e245bd1486cdd43b289e93b", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a0e70968d7ed33f8eec9cabc50ae8b6359851b", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<DA.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/icon/heart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/icon/compare.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/icon/search.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
  
    ViewData["TiTle"] = "Shop - " + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-option"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb__text"">
                    <h4>Shop</h4>
                    <div class=""breadcrumb__links"">
                        <a href=""/"">Home</a>
                        <span>Danh sách sản phẩm</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Shop Section Begin -->
<section class=""shop spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""shop__sidebar"">
                    <div class=""shop__sidebar__search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9c0a27e36080bc1e245bd1486cdd43b289e93b7159", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Search...\">\r\n                            <button type=\"submit\"><span class=\"icon_search\"></span></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shop__sidebar__accordion"">
                        <div class=""accordion"" id=""accordionExample"">
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseOne"">Categories</a>
                                </div>
                                <div id=""collapseOne"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__categories"">
                                            <ul class=""nice-scroll"">
                                                <li><a href=""#"">Men (20)</a></li>
                                                <li><a href=""#"">Women (20)</a></li>
                                                <li><a href=""#"">Bags (20)</a></li>
                                    ");
            WriteLiteral(@"            <li><a href=""#"">Clothing (20)</a></li>
                                                <li><a href=""#"">Shoes (20)</a></li>
                                                <li><a href=""#"">Accessories (20)</a></li>
                                                <li><a href=""#"">Kids (20)</a></li>
                                                <li><a href=""#"">Kids (20)</a></li>
                                                <li><a href=""#"">Kids (20)</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseTwo"">Branding</a>
                                </div>
                                <div id=""collapseTwo"" class=""collapse show");
            WriteLiteral(@""" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__brand"">
                                            <ul>
                                                <li><a href=""#"">Louis Vuitton</a></li>
                                                <li><a href=""#"">Chanel</a></li>
                                                <li><a href=""#"">Hermes</a></li>
                                                <li><a href=""#"">Gucci</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseThree"">Filter Price</a>
                                </d");
            WriteLiteral(@"iv>
                                <div id=""collapseThree"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__price"">
                                            <ul>
                                                <li><a href=""#"">$0.00 - $50.00</a></li>
                                                <li><a href=""#"">$50.00 - $100.00</a></li>
                                                <li><a href=""#"">$100.00 - $150.00</a></li>
                                                <li><a href=""#"">$150.00 - $200.00</a></li>
                                                <li><a href=""#"">$200.00 - $250.00</a></li>
                                                <li><a href=""#"">250.00+</a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>");
            WriteLiteral(@"
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseFour"">Size</a>
                                </div>
                                <div id=""collapseFour"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__size"">
                                            <label for=""xs"">
                                                xs
                                                <input type=""radio"" id=""xs"">
                                            </label>
                                            <label for=""sm"">
                                                s
                                                <input type=""radio"" id=""sm"">
                                            </label>
 ");
            WriteLiteral(@"                                           <label for=""md"">
                                                m
                                                <input type=""radio"" id=""md"">
                                            </label>
                                            <label for=""xl"">
                                                xl
                                                <input type=""radio"" id=""xl"">
                                            </label>
                                            <label for=""2xl"">
                                                2xl
                                                <input type=""radio"" id=""2xl"">
                                            </label>
                                            <label for=""xxl"">
                                                xxl
                                                <input type=""radio"" id=""xxl"">
                                            </label>
                                    ");
            WriteLiteral(@"        <label for=""3xl"">
                                                3xl
                                                <input type=""radio"" id=""3xl"">
                                            </label>
                                            <label for=""4xl"">
                                                4xl
                                                <input type=""radio"" id=""4xl"">
                                            </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseFive"">Colors</a>
                                </div>
                                <div id=""collapseFive"" class=""collapse show"" data-parent=""#accordionExample"">
                                 ");
            WriteLiteral(@"   <div class=""card-body"">
                                        <div class=""shop__sidebar__color"">
                                            <label class=""c-1"" for=""sp-1"">
                                                <input type=""radio"" id=""sp-1"">
                                            </label>
                                            <label class=""c-2"" for=""sp-2"">
                                                <input type=""radio"" id=""sp-2"">
                                            </label>
                                            <label class=""c-3"" for=""sp-3"">
                                                <input type=""radio"" id=""sp-3"">
                                            </label>
                                            <label class=""c-4"" for=""sp-4"">
                                                <input type=""radio"" id=""sp-4"">
                                            </label>
                                            <label class=""c-5"" for=""sp-5"">
    ");
            WriteLiteral(@"                                            <input type=""radio"" id=""sp-5"">
                                            </label>
                                            <label class=""c-6"" for=""sp-6"">
                                                <input type=""radio"" id=""sp-6"">
                                            </label>
                                            <label class=""c-7"" for=""sp-7"">
                                                <input type=""radio"" id=""sp-7"">
                                            </label>
                                            <label class=""c-8"" for=""sp-8"">
                                                <input type=""radio"" id=""sp-8"">
                                            </label>
                                            <label class=""c-9"" for=""sp-9"">
                                                <input type=""radio"" id=""sp-9"">
                                            </label>
                                        </div>
      ");
            WriteLiteral(@"                              </div>
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-heading"">
                                    <a data-toggle=""collapse"" data-target=""#collapseSix"">Tags</a>
                                </div>
                                <div id=""collapseSix"" class=""collapse show"" data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""shop__sidebar__tags"">
                                            <a href=""#"">Product</a>
                                            <a href=""#"">Bags</a>
                                            <a href=""#"">Shoes</a>
                                            <a href=""#"">Fashio</a>
                                            <a href=""#"">Clothing</a>
                                            <a href=""#"">Hats</a>
           ");
            WriteLiteral(@"                                 <a href=""#"">Accessories</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9"">
                <div class=""shop__product__option"">
                    <div class=""row"">
                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""shop__product__option__left"">
                                <p>Showing 1–12 of 126 results</p>
                            </div>
                        </div>
                        <div class=""col-lg-6 col-md-6 col-sm-6"">
                            <div class=""shop__product__option__right"">
                                <p>Sort by Price:</p>
                                <select>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9c0a27e36080bc1e245bd1486cdd43b289e93b20541", async() => {
                WriteLiteral("Low To High");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9c0a27e36080bc1e245bd1486cdd43b289e93b21742", async() => {
                WriteLiteral("$0 - $55");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec9c0a27e36080bc1e245bd1486cdd43b289e93b22940", async() => {
                WriteLiteral("$55 - $100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </select>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"row\">\r\n");
#nullable restore
#line 224 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {
                        foreach (var item in Model)
                        {
                            string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 col-sm-6\">\r\n                                <div class=\"product__item\">\r\n                                    <div class=\"product__item__pic set-bg\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 13472, "\"", 13483, 1);
#nullable restore
#line 232 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
WriteAttributeValue("", 13479, url, 13479, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec9c0a27e36080bc1e245bd1486cdd43b289e93b25385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 13558, "~/images/products/", 13558, 18, true);
#nullable restore
#line 233 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 13576, item.Thumb, 13576, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 233 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 13594, item.Title, 13594, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </a>\r\n                                        <ul class=\"product__hover\">\r\n                                            <li><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec9c0a27e36080bc1e245bd1486cdd43b289e93b27536", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\r\n                                            <li>\r\n                                                <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec9c0a27e36080bc1e245bd1486cdd43b289e93b28774", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <span>Compare</span></a>\r\n                                            </li>\r\n                                            <li><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec9c0a27e36080bc1e245bd1486cdd43b289e93b30029", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></li>\r\n                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"product__item__text\">\r\n                                        <h6");
            BeginWriteAttribute("href", " href=\"", 14400, "\"", 14411, 1);
#nullable restore
#line 244 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
WriteAttributeValue("", 14407, url, 14407, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 244 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
                                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 14479, "\"", 14490, 1);
#nullable restore
#line 245 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
WriteAttributeValue("", 14486, url, 14486, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""add-cart"">+ Add To Cart</a>
                                        <div class=""rating"">
                                            <i class=""fa fa-star-o""></i>
                                            <i class=""fa fa-star-o""></i>
                                            <i class=""fa fa-star-o""></i>
                                            <i class=""fa fa-star-o""></i>
                                            <i class=""fa fa-star-o""></i>
                                        </div>
                                        <h5>");
#nullable restore
#line 253 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                        <div class=""product__color__select"">
                                            <label for=""pc-4"">
                                                <input type=""radio"" id=""pc-4"">
                                            </label>
                                            <label class=""active black"" for=""pc-5"">
                                                <input type=""radio"" id=""pc-5"">
                                            </label>
                                            <label class=""grey"" for=""pc-6"">
                                                <input type=""radio"" id=""pc-6"">
                                            </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 268 "D:\DAmoinhat\DA\Views\Products\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""product__pagination"">
                            <a class=""active"" href=""#"">1</a>
                            <a href=""#"">2</a>
                            <a href=""#"">3</a>
                            <span>...</span>
                            <a href=""#"">21</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<DA.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
