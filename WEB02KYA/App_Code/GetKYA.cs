using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB02KYA.Handlers
{
    public class GetKYA : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var reqParam = context.Request["getKYAparm"];

            HttpResponse response = context.Response;
            response.AddHeader("X-KYA", "Kukareko Yulya");
            response.ContentType = "text/html";
            response.Write("<!DOCTYPE html><html><head><meta charset=\"utf-8\"/><title>" + this.GetType().Name + "</title>" +
                "<link type=\"text/css\" rel=\"stylesheet\" src=\"./Content/CSS/css1KYA.css\">" +
                "<link type=\"text/css\" rel=\"stylesheet\" src=\"./Content/CSS/css2KYA.css\">" +
                "<script  type=\"text/javascript\" src=\"./Content/JS/js1KYA.js\"></script>" +
                "<script type=\"text/javascript\" src=\"./Content/JS/js2KYA.js\"></script></head>" +
                "<body>" +
                "<h1> getKYAParam=" + context.Request["getKYAparm"] + "</h1><br /><br />" +
                "<a href=\"./Content/htmlKYA.html\">htmlKYA</a><br /><br />" +
                "<img src=\"./Content/imgKYA.png\" /><br /><br />" +
                "<form action=\"http://localhost:8086/post.KYA\" method=\"POST\">" +
                "<input type=\"text\" name:\"firstName\"/><br /><br />" +
                "<input type=\"checkbox\" value:\"Y\"/><br /><br />" +
                "<input type=\"radio\" value:\"Y\"/><br /><br /><br /><br />" +
                "<input type=\"submit\" /><br /><br />" +
                "</form>" + 
                "</body></html>");
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}