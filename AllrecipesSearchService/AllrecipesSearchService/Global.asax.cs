using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;
using Allrecipes.CoreClasses.Search;
using System.Diagnostics;
using Allrecipes.Web.Business;
using Allrecipes.Solr.Query;
using Allrecipes.Utilities;
using Allrecipes.Solr.Search;

namespace AllrecipesSearchService
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            ServerStatus.LogInfo("AllrecipesSearchService", "Application_Start", "The AllrecipesSearchService has successfully started");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            ServerStatus.LogInfo("AllrecipesSearchService", "Application_End", "The AllrecipesSearchService has successfully shut down");
        }
    }
}