#pragma checksum "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a61fc72e3d09444bfb941bf3b45507f93aa0755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\_ViewImports.cshtml"
using DirectList_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\_ViewImports.cshtml"
using DirectList_Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\_ViewImports.cshtml"
using DirectList_Final.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a61fc72e3d09444bfb941bf3b45507f93aa0755", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ded8df8bdc87978a086d679cefb80d11354299", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmAbout>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/thumb-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle img-center img-fluid shadow shadow-lg--hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"titlebar\" class=\"gradient\"");
            BeginWriteAttribute("style", " style=\"", 98, "\"", 156, 4);
            WriteAttributeValue("", 106, "background:", 106, 11, true);
            WriteAttributeValue(" ", 117, "url(assets/images/", 118, 19, true);
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
WriteAttributeValue("", 136, Model.Banner.Image, 136, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 155, ")", 155, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"title-bar-inner\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <h2>");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                   Write(Model.Banner.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <span>");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                     Write(Model.Banner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <!-- Breadcrumbs -->\r\n                    <nav id=\"breadcrumbs\">\r\n                        <ul>\r\n                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a61fc72e3d09444bfb941bf3b45507f93aa07557722", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li>");
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                           Write(Model.Banner.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <div class=""title-overlay""></div>
</div>
<div class=""content pt-0"">
    <div class=""about-wrapper"">
        <div class=""block-space"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-10 ml-auto mr-auto"">
                        <div class=""section-title text-center mb-5"">
                            <h2>Three Simple Step To Started Working Process</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 40 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                      
                        var prc = Model.Process;
                        for (int i = 0; i < prc.Count; i++)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1559, "\"", 1621, 4);
            WriteAttributeValue("", 1567, "col-lg-4", 1567, 8, true);
            WriteAttributeValue(" ", 1575, "col-md-12", 1576, 10, true);
            WriteAttributeValue(" ", 1585, "mb-4", 1586, 5, true);
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
WriteAttributeValue(" ", 1590, i==prc.Count-1?"md-mt-5":"", 1591, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"about-info\">\r\n                                    <div class=\"about-num-box\">\r\n                                        <div class=\"about-icon\">\r\n                                            <span><i");
            BeginWriteAttribute("class", " class=\"", 1866, "\"", 1886, 1);
#nullable restore
#line 49 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
WriteAttributeValue("", 1874, prc[i].Icon, 1874, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\r\n                                        </div>\r\n                                        <div class=\"about-highlight\">");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                                                                 Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                    </div>\r\n                                    <div class=\"about-desc\">\r\n                                        <h4>");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                                       Write(prc[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p class=\"mb-0\">\r\n                                            ");
#nullable restore
#line 56 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                                       Write(prc[i].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 61 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                </div>
            </div>
        </div>
        <div class=""block-space bg-secondary"">
            <div class=""container"">
                <div class=""row row-grid align-items-center"">
                    <div class=""col-md-6"">
                        <div class=""card bg-default shadow border-0"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a61fc72e3d09444bfb941bf3b45507f93aa075513815", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2904, "~/assets/images/", 2904, 16, true);
#nullable restore
#line 75 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2920, Model.AboutUs.Image, 2920, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <blockquote class=""card-blockquote"">
                                <svg preserveAspectRatio=""none"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 583 95"" class=""svg-bg"">
                                    <polygon points=""0,52 583,95 0,95"" class=""fill-default""></polygon>
                                    <polygon points=""0,42 583,95 683,0 0,95"" opacity="".2"" class=""fill-default""></polygon>
                                </svg>
                                <h4 class=""display-3 font-weight-bold text-white"">Our Goal</h4>
                                <p class=""lead text-italic text-white"">
                                    ");
#nullable restore
#line 83 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                               Write(Model.AboutUs.ImageText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </blockquote>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""pl-md-5"">
                            <div class=""icon icon-lg icon-shape icon-shape-warning shadow rounded-circle mb-5"">
                                <i");
            BeginWriteAttribute("class", " class=\"", 4058, "\"", 4085, 1);
#nullable restore
#line 91 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
WriteAttributeValue("", 4066, Model.AboutUs.Icon, 4066, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                            <h3>About Us</h3>\r\n                            \r\n                            <p>\r\n                                ");
#nullable restore
#line 96 "C:\Users\ASUS\Desktop\DirectList_Final\DirectList_Final\DirectList_Final\Views\About\Index.cshtml"
                           Write(Model.AboutUs.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            
                            <a href=""#"" class=""font-weight-bold text-warning mt-5"">Explore Your Places</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""block-space"">
            <div class=""container"">
                <div class=""row justify-content-center text-center mb-5"">
                    <div class=""col-lg-8"">
                        <h2 class=""display-3"">The Amazing Team</h2>
                        <p class=""lead"">According to the National Oceanic and Atmospheric Administration, Ted, Scambos, NSIDClead scentist, puts the potentially record maximum.</p>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-6 col-lg-3 mb-5 mb-lg-0"">
                        <div class=""px-4"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a61fc72e3d09444bfb941bf3b45507f93aa075518692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""pt-4 text-center"">
                                <h5 class=""title"">
                                    <span class=""d-block mb-1"">Ryan Tompson</span>
                                    <small class=""h6"">Web Developer</small>
                                </h5>
                                <div class=""mt-3"">
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-twitter text-white""></i>
                                    </a>
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-facebook text-white""></i>
                                    </a>
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-dribbble text-white""></i>
                                    </a>
  ");
            WriteLiteral(@"                              </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3 mb-5 mb-lg-0"">
                        <div class=""px-4"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a61fc72e3d09444bfb941bf3b45507f93aa075521324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""pt-4 text-center"">
                                <h5 class=""title"">
                                    <span class=""d-block mb-1"">Ryan Tompson</span>
                                    <small class=""h6"">Web Developer</small>
                                </h5>
                                <div class=""mt-3"">
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-twitter text-white""></i>
                                    </a>
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-facebook text-white""></i>
                                    </a>
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-dribbble text-white""></i>
                                    </a>
  ");
            WriteLiteral(@"                              </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3 mb-5 mb-lg-0"">
                        <div class=""px-4"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a61fc72e3d09444bfb941bf3b45507f93aa075523956", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""pt-4 text-center"">
                                <h5 class=""title"">
                                    <span class=""d-block mb-1"">Ryan Tompson</span>
                                    <small class=""h6"">Web Developer</small>
                                </h5>
                                <div class=""mt-3"">
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-twitter text-white""></i>
                                    </a>
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-facebook text-white""></i>
                                    </a>
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-dribbble text-white""></i>
                                    </a>
  ");
            WriteLiteral(@"                              </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-3 mb-5 mb-lg-0"">
                        <div class=""px-4"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a61fc72e3d09444bfb941bf3b45507f93aa075526588", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""pt-4 text-center"">
                                <h5 class=""title"">
                                    <span class=""d-block mb-1"">Ryan Tompson</span>
                                    <small class=""h6"">Web Developer</small>
                                </h5>
                                <div class=""mt-3"">
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-twitter text-white""></i>
                                    </a>
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-facebook text-white""></i>
                                    </a>
                                    <a class=""btn btn-primary btn-icon-only rounded-circle"">
                                        <i class=""fa fa-dribbble text-white""></i>
                                    </a>
  ");
            WriteLiteral("                              </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 10933, "\"", 10941, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""container"">
                <div class=""card bg-gradient-warning shadow-lg border-0"">
                    <div class=""p-5"">
                        <div class=""row align-items-center"">
                            <div class=""col-lg-8"">
                                <h3 class=""text-white""> Lorem ipsum dolor sit amet consectetur</h3>
                                <p class=""lead text-white mt-3"">
                                    adipisicing elit. Quos, consectetur ex? Amet facere neque, eaque accusamus cumque, commodi fugit, provident
                                </p>
                            </div>
                            <div class=""col-lg-3 ml-lg-auto"">
                                <a href=""#"" class=""btn btn-lg btn-block btn-white"">Start Now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591
