﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.ConfigMgr.EditorTemplates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/ConfigMgr/EditorTemplates/ConfigBlock.cshtml")]
    public partial class ConfigBlock_ : System.Web.Mvc.WebViewPage<Piranha.Manager.Config.ConfigBlock>
    {
        public ConfigBlock_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("id", Tuple.Create(" id=\"", 49), Tuple.Create("\"", 70)
, Tuple.Create(Tuple.Create("", 54), Tuple.Create("pnl", 54), true)
            
            #line 3 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
, Tuple.Create(Tuple.Create("", 57), Tuple.Create<System.Object, System.Int32>(Model.Name
            
            #line default
            #line hidden
, 57), false)
);

WriteLiteral(" class=\"panel panel-white\"");

WriteLiteral(">\r\n\t<div");

WriteLiteral(" class=\"notification\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"icon\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-ok-circle\"");

WriteLiteral("></span></div>\r\n\t</div>\r\n\t<div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n\t\t<!-- Save -->\r\n\t\t<div");

WriteLiteral(" class=\"btn-group pull-right\"");

WriteLiteral(">\r\n\t\t\t<button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-labeled btn-success\"");

WriteLiteral(" data-bind=\"click: function() { saveBlock(\'");

            
            #line 10 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
                                                                                                           Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\'); }\"");

WriteLiteral(">\r\n\t\t\t\t<span");

WriteLiteral(" class=\"btn-label\"");

WriteLiteral(">\r\n\t\t\t\t\t<i");

WriteLiteral(" class=\"glyphicon glyphicon-ok\"");

WriteLiteral("></i>\r\n\t\t\t\t</span>\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 14 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
           Write(Piranha.Manager.Resources.Global.Save);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</button>\r\n\t\t</div>\r\n\r\n\t\t<h3>");

            
            #line 18 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
       Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
		
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
         foreach (var row in Model.Rows) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 22 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
				
            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
                 foreach (var col in row.Columns) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<div");

WriteAttribute("class", Tuple.Create(" class=\"", 716), Tuple.Create("\"", 776)
            
            #line 23 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
, Tuple.Create(Tuple.Create("", 724), Tuple.Create<System.Object, System.Int32>(row.Columns.Count == 1 ? "col-sm-12" : "col-sm-6"
            
            #line default
            #line hidden
, 724), false)
);

WriteLiteral(">\r\n");

            
            #line 24 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
						
            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
                         foreach (var item in col.Items) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<label>");

            
            #line 26 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
                                  Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");

            
            #line 27 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
								
            
            #line default
            #line hidden
            
            #line 27 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
                                 if (!(item is Piranha.Manager.Config.ConfigText)) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t\t\t<input");

WriteAttribute("id", Tuple.Create(" id=\"", 967), Tuple.Create("\"", 983)
            
            #line 28 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
, Tuple.Create(Tuple.Create("", 972), Tuple.Create<System.Object, System.Int32>(item.Param
            
            #line default
            #line hidden
, 972), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 984), Tuple.Create("\"", 1002)
            
            #line 28 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
, Tuple.Create(Tuple.Create("", 991), Tuple.Create<System.Object, System.Int32>(item.Param
            
            #line default
            #line hidden
, 991), false)
);

WriteLiteral(" ");

            
            #line 28 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
                                                                           Write(item is Piranha.Manager.Config.ConfigInteger ? "type=number" : "type=text");

            
            #line default
            #line hidden
WriteLiteral(" class=\"form-control\" value=\"");

            
            #line 28 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
                                                                                                                                                                                    Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");

            
            #line 29 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
								} else {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t\t\t<textarea");

WriteAttribute("id", Tuple.Create(" id=\"", 1163), Tuple.Create("\"", 1179)
            
            #line 30 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
, Tuple.Create(Tuple.Create("", 1168), Tuple.Create<System.Object, System.Int32>(item.Param
            
            #line default
            #line hidden
, 1168), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1180), Tuple.Create("\"", 1198)
            
            #line 30 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
, Tuple.Create(Tuple.Create("", 1187), Tuple.Create<System.Object, System.Int32>(item.Param
            
            #line default
            #line hidden
, 1187), false)
);

WriteLiteral(">");

            
            #line 30 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
                                                                             Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n");

            
            #line 31 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
								}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t\t\t</div>\r\n");

            
            #line 33 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
						}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t</div>\r\n");

            
            #line 35 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t</div>\r\n");

            
            #line 37 "..\..\Areas\Manager\Views\ConfigMgr\EditorTemplates\ConfigBlock.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\t</div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591