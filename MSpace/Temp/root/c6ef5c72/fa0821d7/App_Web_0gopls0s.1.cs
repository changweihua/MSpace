﻿#pragma checksum "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91E5FFE7D844ED7ABE4B03066E157EB89E9E6EB0"
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
    
    
    public class _Page_Views_Shared_ArticleTempalte_cshtml : System.Web.Mvc.WebViewPage<dynamic> {
        
#line hidden

        
        public _Page_Views_Shared_ArticleTempalte_cshtml() {
        }
        
        protected ASP.global_asax ApplicationInstance {
            get {
                return ((ASP.global_asax)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n\t<meta charset=\"utf-8\" />\r\n\t<title>");


            
            #line 5 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
"\r\n\t<meta name=\"description\" content=\"\">\r\n\t<meta name=\"author\" content=\"\">\r\n\t<lin" +
"k rel=\"shortcut icon\" type=\"image/x-icon\" href=\"");


            
            #line 9 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                                                Write(Url.Content("~/Content/favicon.ico"));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\r\n\t\t<style type=\"text/css\">\r\n\t\t\tbody {\r\n\t\t\t\tpadding-top: 70px;\r\n\t\t\t\tpadding-" +
"bottom: 40px;\r\n\t\t\t}\r\n\t\t\tform {\r\n\t\t\t\tmargin: 0;\r\n\t\t\t}\r\n\t\t\ttextarea {\r\n\t\t\t\tdisplay" +
": block;\r\n\t\t\t}\r\n\t\t\t\r\n\t\t\t#toTop{width:67px;height:114px;background:url(\'");


            
            #line 23 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                                             Write(Url.Content("~/Content/toTop.gif"));

            
            #line default
            #line hidden
WriteLiteral(@"');position:fixed;bottom:55px;right:25px;display:none;}
		</style>
	<!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
	<!--[if lt IE 9]>
		<script src=""http://html5shim.googlecode.com/svn/trunk/html5.js""></script>
	<![endif]-->
	<link href=""");


            
            #line 29 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
        Write(Url.Content("~/Content/templates/bootstrap/css/bootstrap.min.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n\t<link href=\"");


            
            #line 30 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
        Write(Url.Content("~/Content/templates/jquerybootstrap/css/jquery-ui-1.10.0.custom.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n\t<link href=\"");


            
            #line 31 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
        Write(Url.Content("~/Content/templates/bootstrap/css/font-awesome.min.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n\t<!--[if lte IE 6]>\r\n\t\t<link rel=\"styleshe" +
"et\" type=\"text/css\" href=\"");


            
            #line 33 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                                          Write(Url.Content("~/Content/templates/bootstrap/css/bootstrap-ie6.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t<![endif]-->\r\n\t<!--[if lte IE 7]>\r\n\t\t<link rel=\"stylesheet\" type=\"text/css\" " +
"href=\"");


            
            #line 36 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                                          Write(Url.Content("~/Content/templates/bootstrap/css/ie.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t<link href=\"");


            
            #line 37 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Content/templates/bootstrap/css/font-awesome-ie7.min.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n\t<![endif]-->\r\n\t");



WriteLiteral("\r\n\r\n\t<link href=\"");


            
            #line 41 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
        Write(Url.Content("~/Content/templates/bootstrap/css/bootstrap-responsive.min.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n\t");



WriteLiteral("\r\n\r\n\t<link rel=\"stylesheet\" href=\"");


            
            #line 46 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                         Write(Url.Content("~/Content/templates/bootstrap/plugins/modalDialog/css/animate.css"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/css\" />\r\n\r\n\t<script src=\"");


            
            #line 48 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Scripts/jquery-1.7.2.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 49 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
            Write(Url.Content("~/Scripts/jquery.transit.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\t<script src=\"");


            
            #line 50 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Scripts/modernizr-2.5.3.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>         \r\n\t<script src=\"");


            
            #line 51 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Content/templates/bootstrap/js/bootstrap.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\t<script src=\"");


            
            #line 52 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Scripts/jquery-ui-1.10.0.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\t<script src=\"");


            
            #line 53 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Content/templates/bootstrap/plugins/modalDialog/js/bootstrap-modalmanager.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\t<script src=\"");


            
            #line 54 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Content/widget/glow/jquery.color.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\t<script src=\"");


            
            #line 55 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Content/widget/glow/jquery-glowing.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\t");



WriteLiteral("\r\n\t\r\n\t");



WriteLiteral("\r\n\t<!--[if gte IE 7]><!-->\r\n\t   ");



WriteLiteral("\r\n\t\t<link href=\"");


            
            #line 61 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Content/widgets/artDialog/skins/twitter.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n\t<!--<![endif]-->\r\n\t<!--[if lt IE 7]>\r\n\t  " +
" <link href=\"");


            
            #line 64 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
           Write(Url.Content("~/Content/widgets/artDialog/skins/default.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n\t<![endif]-->\r\n\t\r\n\t<script src=\"");


            
            #line 67 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Content/widgets/artDialog/artDialog.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 68 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
            Write(Url.Content("~/Content/widgets/artDialog/artDialog.plugins.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\r\n    <link href=\"");


            
            #line 70 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
           Write(Url.Content("~/Content/widgets/portlet/css/jquery.portlet.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n    <script src=\"");


            
            #line 71 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
            Write(Url.Content("~/Content/widgets/portlet/script/jquery.portlet.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>  \r\n    <script src=\"");


            
            #line 72 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
            Write(Url.Content("~/Content/widgets/portlet/script/jquery.portlet.pack.js?v=1.1.3"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script> \r\n    <script src=\"");


            
            #line 73 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
            Write(Url.Content("~/Content/widgets/qrcode/jquery.qrcode.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\t<script src=\"");


            
            #line 74 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
         Write(Url.Content("~/Content/widgets/qrcode/qrcode.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 75 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
            Write(Url.Content("~/Scripts/jquery.MyQRCode.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n\r\n\t");


            
            #line 77 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
Write(RenderSection("scripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\t<script type=\"text/javascript\">\r\n\t\t$(function () {\r\n\t\t\t$(\'.blue\').addGlow({ " +
"textColor: \'#00f\', haloColor: \'#00f\', radius: 100 });\r\n\t\t\t$(\'.green\').addGlow({ " +
"textColor: \'#0f0\', haloColor: \'#0f0\', radius: 100 });\r\n\t\t\t$(\'*\').bind(\'glow:star" +
"ted\', console.info);\r\n\t\t\t$(\'*\').bind(\'glow:canceled\', console.info);\r\n\t\t\t$(windo" +
"w).scroll(function () {\r\n\t\t\t\tif ($(this).scrollTop() > 100) {\r\n\t\t\t\t\t$(\'#toTop\')." +
"fadeIn();\r\n\t\t\t\t} else {\r\n\t\t\t\t\t$(\'#toTop\').fadeOut();\r\n\t\t\t\t}\r\n\t\t\t});\r\n\t\t\t$(\"#toTo" +
"p\").click(function () {\r\n\t\t\t\t$(\"html,body\").animate({ scrollTop: 0 }, \"slow\");\r\n" +
"\t\t\t\treturn false;\r\n\t\t\t});\r\n\r\n\t\t\t// Autocomplete\r\n\t\t\tvar availableTags = [\"Action" +
"Script\", \"AppleScript\", \"Asp\", \"BASIC\", \"C\", \"C++\", \"Clojure\", \"COBOL\", \"ColdFus" +
"ion\", \"Erlang\", \"Fortran\", \"Groovy\", \"Haskell\", \"Java\", \"JavaScript\", \"Lisp\", \"P" +
"erl\", \"PHP\", \"Python\", \"Ruby\", \"Scala\", \"Scheme\"];\r\n\r\n\t\t\t$(\"#searchKey\").autocom" +
"plete({\r\n\t\t\t\tsource: availableTags\r\n\t\t\t});\r\n\t\t});\r\n\t</script>\r\n\r\n\t<style type=\"t" +
"ext/css\" media=\"screen\">\r\n\t\ta.glowing {\r\n\t\t\tcolor: #0af;\r\n\t\t}\r\n  </style>\r\n\r\n</h" +
"ead>\r\n\r\n<body>\r\n\t\t<div class=\"navbar navbar-fixed-top\">\r\n\t\t\t<div class=\"navbar-i" +
"nner\">\r\n\t\t\t\t<div class=\"container-fluid\">\r\n\t\t\t\t\t<a class=\"btn btn-navbar\" data-t" +
"oggle=\"collapse\" data-target=\".nav-collapse\">\r\n\t\t\t\t\t\t<span class=\"icon-bar\"></sp" +
"an>\r\n\t\t\t\t\t\t<span class=\"icon-bar\"></span>\r\n\t\t\t\t\t\t<span class=\"icon-bar\"></span>\r" +
"\n\t\t\t\t\t</a>\r\n\t\t\t\t\t<a class=\"brand blue\" href=\"http://www.cmono.net/monobook/\">常伟华" +
"的博客</a>\r\n\t\t\t\t\t<div class=\"nav-collapse\">\r\n\t\t\t\t\t\t<ul id=\"navList\" class=\"nav nav-" +
"pills\">\r\n\t\t\t\t\t\t\t<li><a class=\"blue\" href=\"");


            
            #line 126 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                            Write(Url.RouteUrl("DefaultRoute", new { controller="Home", action="Index" }));

            
            #line default
            #line hidden
WriteLiteral("\"><i class=\"icon-home\"></i> 首页</a></li>\r\n\t\t\t\t\t\t\t<li><a class=\"blue\" href=\"");


            
            #line 127 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                            Write(Url.RouteUrl("DefaultRoute", new { controller="Home", action="About" }));

            
            #line default
            #line hidden
WriteLiteral("\"><i class=\"icon-file\"></i> 关于</a></li>\r\n\t\t\t\t\t\t\t<li><a class=\"blue\" href=\"");


            
            #line 128 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                            Write(Url.RouteUrl("DefaultRoute", new { controller="Article", action="Index" }));

            
            #line default
            #line hidden
WriteLiteral("\"><i class=\"icon-list\"></i> 文章</a></li>\r\n\t\t\t\t\t\t\t<li><a class=\"blue\" href=\"");


            
            #line 129 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                            Write(Url.RouteUrl("DefaultRoute", new { controller="Gallary", action="Index" }));

            
            #line default
            #line hidden
WriteLiteral(@"""><i class=""icon-picture""></i> 相册</a></li>
							<li class=""divider-vertical""></li>
							<li class=""dropdown"">
								<a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""><i class=""icon-external-link""></i> 友链<b class=""caret""></b></a>
								<ul class=""dropdown-menu"">
									<li class=""nav-header"">国内</li>
									<li><a href=""http://www.cnblogs.com/changweihua/"">我的博客园</a></li>
									<li><a href=""http://blog.csdn.net/cqwl200913014060/"">我的CSDN</a></li>
									<li><a href=""http://changvh.blog.51cto.com"">我的51CTO</a></li>
									<li class=""divider""></li>
									<li class=""nav-header"">国外</li>
									<li><a href=""https://github.com/changweihua/""><i class=""icon-github""></i> Github</a></li>
									<li><a href=""#""><i class=""icon-twitter""></i> Twitter</a></li>
									<li><a href=""#""><i class=""icon-facebook""></i> Facebook</a></li>
									<li><a href=""#""><i class=""icon-linkedin""></i> LinkedIn</a></li>
									<li><a href=""#""><i class=""icon-google-plus""></i> Google Plus</a></li>
								</ul>
							</li>
							<li class=""divider-vertical""></li>
                            <li><a data-val=""");


            
            #line 148 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                                        Write(Url.Action("Publish", "Message"));

            
            #line default
            #line hidden
WriteLiteral("\" href=\"");


            
            #line 148 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                                                                                 Write(Url.Action("留言板", "Message"));

            
            #line default
            #line hidden
WriteLiteral("\">留言板</a></li>\t\t\t\t\t\t\r\n                            <li class=\"divider-vertical\"></" +
"li>\r\n\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t<form class=\"navbar-search\" action=\"\">\r\n\t\t\t\t\t\t   ");



WriteLiteral("\r\n\t\t\t\t\t\t\t");



WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"input-append search\">\r\n\t\t\t\t\t\t\t\t<input class=\"input-medium\" p" +
"laceholder=\"关键字\" type=\"text\" id=\"searchKey\" name=\"\">\r\n\t\t\t\t\t\t\t\t<button type=\"subm" +
"it\" class=\"btn\"><i class=\"icon-search\"></i></button>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</for" +
"m>\r\n\t\t\t\t\t\t");


            
            #line 167 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
 Write(RenderSection("Login", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t\t</div><!-- /.nav-collapse -->\r\n\t\t\t\t</div>\r\n\t\t\t</div><!-- /navbar-inner -->" +
"\r\n\t\t</div><!-- /navbar -->\r\n\r\n\t\t<div class=\"container-fluid\">\r\n\t\t\t");


            
            #line 174 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
		</div>
		<a href=""javascript:;"" id=""toTop"" title=""返回顶部"" ></a>
		<div class=""navbar navbar-fixed-bottom"">
			<div class=""navbar-inner"">
				<div class=""container-fluid"">
					<a class=""btn btn-navbar"" data-toggle=""collapse"" data-target="".nav-collapse"">
						<span class=""icon-bar""></span>
						<span class=""icon-bar""></span>
						<span class=""icon-bar""></span>
					</a>					
					<a class=""brand"" href=""#"">常伟华的博客</a>
					<div class=""nav-collapse"">
						<ul class=""nav"">
							<li><a target=""_blank"" href=""http://www.cmono.net"">CMONO.NET</a></li>	
							<li><a href=""");


            
            #line 189 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
               Write(Url.Action("CopyRight", "Global"));

            
            #line default
            #line hidden
WriteLiteral("\">&copy; All Rights Reserved</a></li>\r\n\t\t\t\t\t\t\t<li><a href=\"#\"></a></li>\r\n\t\t\t\t\t\t</" +
"ul>\r\n                        <div class=\"navbar-text pull-left\">");


            
            #line 192 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                                                      Write(RenderSection("BottomLeftBar", false));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\t\t\t\t\t\t<div class=\"navbar-text pull-right\">");


            
            #line 193 "E:\VS2012\MSpace\MSpace\Views\Shared\ArticleTempalte.cshtml"
                                     Write(RenderSection("BottomRightBar", false));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n</body>\r\n</html>\r\n");


        }
    }
}
