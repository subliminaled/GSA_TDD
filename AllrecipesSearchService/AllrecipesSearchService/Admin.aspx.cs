using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using System.IO;

namespace AllrecipesSearchService
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            //string xml = txtQuery.Text;
            //byte[] buffer = Encoding.UTF8.GetBytes(xml);

            //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(service + "update?commit=true");
            //request.Method = "POST";
            //request.ContentType = "text/xml";
            //request.ContentLength = buffer.Length;

            //Stream ReqStream = request.GetRequestStream();
            //ReqStream.Write(buffer, 0, buffer.Length);
            //ReqStream.Close();
            //WebResponse WebRes = request.GetResponse();

            ////Console.WriteLine(WebResp.StatusCode); 
            ////Console.WriteLine(WebResp.Server); 
            //Stream ResStream = WebRes.GetResponseStream();
            //StreamReader ResReader = new StreamReader(ResStream);
            //string sResponse = ResReader.ReadToEnd(); 


        }
    }
}
