using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;

namespace twilio_dotnet.Handlers
{
    /// <summary>
    /// Summary description for Call
    /// </summary>
    public class Call : IHttpHandler
    {
        TwilioRestClient client;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            client = new TwilioRestClient(Settings.AccountSid, Settings.AuthToken);

            var result = client.InitiateOutboundCall(Settings.TwilioNumber, context.Request["to"], Settings.BaseUrl + "/Hello.ashx");

            if (result.RestException != null)
            {
                context.Response.StatusCode = 500;
                context.Response.Write(result.RestException.Message);
            }
            else
            {
                context.Response.Write("{ \"error\":false }");
            }
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