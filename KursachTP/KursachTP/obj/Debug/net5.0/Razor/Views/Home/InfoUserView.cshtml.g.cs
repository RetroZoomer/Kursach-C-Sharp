#pragma checksum "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InfoUserView), @"mvc.1.0.view", @"/Views/Home/InfoUserView.cshtml")]
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
#line 1 "Z:\FindFriends\KursachTP\KursachTP\Views\_ViewImports.cshtml"
using KursachTP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\FindFriends\KursachTP\KursachTP\Views\_ViewImports.cshtml"
using KursachTP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a9fb3377f9ea1464fce597281ad3ef2901a4ceb", @"/Views/Home/InfoUserView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09f9c4958aecc0e01e6232212a84d918761e2f66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InfoUserView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KursachTP.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav_link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WarningView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProfileView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style>
    body {
        font-family: 'Roboto', sans-serif;
        font-size: 16px;
        background: #7CA8FF;
        width: 70%;
        margin: 0 auto;
    }

    .header {
        position: absolute;
        width: 100%;
        height: 10%;
        left: 0px;
        top: 0px;
        min-width: 20%;
        background: #6296E4;
        box-shadow: 0px 10px 10px rgba(0, 0, 0, 0.25);
    }

    .nav {
        display: flex;
        align-items: center;
        justify-content: end;
        min-width: 20%;
        min-height: 50%;
    }

    .header-intro {
        display: flex;
        align-items: center;
        justify-content: space-between;
        margin-top: 1.3%;
        margin-left: 15%;
        margin-right: 15%;
        min-width: none;
    }

    .logo {
        text-decoration: none;
        color: white;
        font: 'Roboto';
        font-size: 24pt;
        min-width: 20%;
        min-height: 100%;
    }

    .nav_link_find {
        d");
            WriteLiteral(@"isplay: inline-block;
        text-decoration: none;
        color: #6296E4;
        font: 'Roboto';
        font-size: 24pt;
        background-color: #FFFFFF;
        border-radius: 51px;
        padding: 0 15px 0 15px;
    }

    .nav_link {
        display: inline-block;
        margin-left: 10%;
        text-decoration: none;
        color: white;
        font: 'Roboto';
        font-size: 24pt;
        white-space: nowrap;
        max-height: 100%;
        min-width: auto;
        min-height: 100%;
    }

    .main {
        align-items: center;
        margin: 13% auto 0 auto;
    }

    .title {
        text-align: center;
        color: #FFFFFF;
        font-size: 26px;
        padding: 0% 5% 5% 5%;
    }

    .dateTime {
        font-size: 16px;
        color: #d6d6d6;
    }

    .content {
        text-align: center;
        padding-top: 2%;
        padding-bottom: 2%;
        margin: 0 auto;
        width: 40%;
        background: #6296E4;
        box");
            WriteLiteral(@"-shadow: 0px 12px 15px rgba(0, 0, 0, 0.25);
        border-radius: 20px;
    }

    .mainInf {
        color: #FFFFFF;
        font-size: 21px;
        display: flex;
        flex-direction: column;
        flex-flow: column nowrap;
        align-items: stretch;
        justify-content: normal;
        height: auto;
        padding: 2% 4% 0% 4%;
    }

    .Text {
        text-align: left;
        padding: 0% 0% 3% 0%;
    }

    .input {
        background: #8aaaf3;
        border-radius: 10px;
        color: white;
        width: 96%;
        height: auto;
        padding: 1% 2% 1% 2%;
        word-break: break-word;
        display: flex;
        flex-direction: column;
        justify-content: flex-start;
        align-items: stretch;
    }

    .inputDate {
        background: #8aaaf3;
        border-radius: 10px;
        color: white;
        padding-left: 2%;
        padding-right: 2%;
        width: 160px;
        height: 30px;
    }

    .inputBig {
     ");
            WriteLiteral(@"   background: #5389DA;
        border-radius: 18px;
        border: 2px solid #4876bb;
        font-size: 21px;
        color: white;
        padding: 0% 2% 0 2%;
        resize: none;
        width: 96%;
        min-height: 30px;
    }

    .button {
        margin: 10% auto 0% auto;
        padding: 1px 1px 1px 1px;
        width: 280px;
        border-radius: 51px;
        border: 2px solid white;
        background: white;
        color: #6296E4;
        font-size: 24px;
        text-decoration: none;
    }


    .contentF {
        justify-content: space-between;
        max-width: 100%;
        margin-right: 0;
        margin-left: 0;
    }

    footer {
        display: flex;
        justify-content: space-between;
        color: #FFFFFF;
        width: 100%;
        margin-top: 2%;
        margin-bottom: 5%;
    }

    .aboutF {
        float: right;
    }

    .footerA {
        text-decoration: none;
        color: #FFFFFF;
    }

</style>
         ");
            WriteLiteral("                                                \r\n<header class=\"header\">\r\n    <div class=\"header-intro\">\r\n        <div class=\"logo\">Logo</div>\r\n        <nav class=\"nav\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb11412", async() => {
                WriteLiteral("Пользователи");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb13075", async() => {
                WriteLiteral("Жалобы");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb14732", async() => {
                WriteLiteral("Посты");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb16388", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 203 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
                 try
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(User.FindFirst(x => x.Type == ClaimTypes.Name).Value);

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
                                                                         
                }
                catch (NullReferenceException ex)
                {

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb18859", async() => {
                WriteLiteral("Выход");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </nav>
    </div>
</header>

<div class=""main"">
    <div class=""content"">

        <div class=""title"">
            Информация о пользователе:
        </div>

        <div class=""mainInf"">

            <div class=""Text"">
                ID:
                <div class=""input"">
                    ");
#nullable restore
#line 229 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Имя:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 236 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Фамилия:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 243 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Дата рождения:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 250 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Пол:\r\n                <div class=\"input\">\r\n");
#nullable restore
#line 257 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
                     if (@Model.Pol == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>Мужской</div> ");
#nullable restore
#line 259 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
                                           }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>Женский</div>");
#nullable restore
#line 262 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Описпание:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 269 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.UserDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Ссылка на мессенджер:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 276 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.LinkMes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Логин:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 283 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Хеш-пароль:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 290 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Номер телефона:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 297 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"Text\">\r\n                Роль:\r\n                <div class=\"input\">\r\n                    ");
#nullable restore
#line 304 "Z:\FindFriends\KursachTP\KursachTP\Views\Home\InfoUserView.cshtml"
               Write(Model.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb25706", async() => {
                WriteLiteral("Список пользователей");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<hr style=\"margin-top: 15%;\">\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb27150", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a9fb3377f9ea1464fce597281ad3ef2901a4ceb28254", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KursachTP.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
