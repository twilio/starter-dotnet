using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;

namespace twilio_dotnet
{
    /// <summary>
    /// Summary description for Capability
    /// </summary>
    public class Capability : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            var capability = new TwilioCapability(Settings.AccountSid, Settings.AuthToken);
            capability.AllowClientOutgoing("AP784bd34e34fab9759b8e91d3ef3680b9");

            string token = capability.GenerateToken();

            context.Response.Write(string.Format("{{ \"token\" : \"{0}\" }}", token));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}   