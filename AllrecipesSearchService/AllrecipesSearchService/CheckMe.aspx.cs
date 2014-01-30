using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Allrecipes.Solr.Query;
using Allrecipes.Web.Business;
using Allrecipes.Web.Monitoring.Controls;
using Allrecipes.Utilities;
using Allrecipes.Solr.Search;

namespace AllrecipesSearchService
{
    public partial class CheckMe : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationStatus result = ApplicationStatus.Unknown;

            if (SearchManager.Instance.IsAlive())
            {
                result = ApplicationStatus.Healthy;
            }
            else
            {
                result = ApplicationStatus.Unavailable;
            }

            status.ApplicationStatus = result;
        }
    }
}
