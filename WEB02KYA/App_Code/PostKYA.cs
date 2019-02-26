using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB02KYA.Handlers
{
    public class PostKYA : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            response.ContentType = "text/html";
            response.Write("<html><head>" +
                "<title>" + this.GetType().Name + "</title>" +
                "</head><body>" +
                "<div>" + buildHeadersStr(context) + "</div> " +
                "<br /><br />" +
                "<div>" + buildParametrsString(context) + "</div>" +
                "</body></html>");
        }

        private String buildHeadersStr(HttpContext context)
        {
            String result = null;

            for(int i= 0; i < context.Request.Headers.Count; i++)
            {
                result += "<p> Key header: " + context.Request.Headers.GetKey(i) + " value header: " + context.Request.Headers.GetValues(i) + "</p>";
            }
            return result; 
        }

        private String buildParametrsString(HttpContext context)
        {
            String result = null;

            for(int i=0; i < context.Request.Params.Count; i++)
            {
                result += "<p> Param name: " + context.Request.Params.GetKey(i) + " value param: " + context.Request.Params.GetValues(i) + "</p>";
            }
            return result;
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}