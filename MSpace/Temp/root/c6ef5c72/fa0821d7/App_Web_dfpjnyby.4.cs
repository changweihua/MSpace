﻿#pragma checksum "E:\VS2012\MSpace\MSpace\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B9D0535472782A91468CC3489C9D8E961CCCA83B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18034
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using MSpace.Models;
    
    
    public class _Page_Views_Home_Login_cshtml : System.Web.Mvc.WebViewPage<dynamic> {
        
#line hidden

        
        public _Page_Views_Home_Login_cshtml() {
        }
        
        protected ASP.global_asax ApplicationInstance {
            get {
                return ((ASP.global_asax)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {

            
            #line 1 "E:\VS2012\MSpace\MSpace\Views\Home\Login.cshtml"
  
    ViewBag.Title = "Login";


            
            #line default
            #line hidden
WriteLiteral(@"<ul class=""nav pull-right"">
        <li><a href=""/signup"">注册</a></li>
        <li class=""divider-vertical""></li>
        <li class=""dropdown"">
            <a class=""dropdown-toggle"" href=""#"" data-toggle=""dropdown"">登录<strong class=""caret""></strong></a>
                <div class=""dropdown-menu"" style=""padding: 15px; padding-bottom: 0px;"">
                <form method=""post"" action=""login"" accept-charset=""UTF-8"">
                    <input style=""margin-bottom: 15px;"" type=""text"" placeholder=""用户名"" id=""username"" name=""username"">
                    <input style=""margin-bottom: 15px;"" type=""password"" placeholder=""密码"" id=""password"" name=""password"">
                    <input style=""float: left; margin-right: 10px;"" type=""checkbox"" name=""remember-me"" id=""remember-me"" value=""1"">
                    <label class=""string optional"" for=""user_remember_me"">记住我</label>
                    <input class=""btn btn-primary btn-block"" type=""submit"" id=""sign-in"" value=""登录"">
                    <label style=""text-align:center;margin-top:5px"">您也可以</label>
                    <input class=""btn btn-primary btn-block"" type=""button"" id=""sign-in-google"" value=""Sign In with Google"">
                    <input class=""btn btn-primary btn-block"" type=""button"" id=""sign-in-twitter"" value=""Sign In with Twitter"">
                </form>
            </div>
        </li>
    </ul>
<h2>Login</h2>
");


        }
    }
}
