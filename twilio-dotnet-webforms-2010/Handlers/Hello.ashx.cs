using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio.TwiML;

namespace twilio_dotnet.Handlers
{
    /// <summary>
    /// Summary description for Hello
    /// </summary>
    public class Hello : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/xml";

            var response = new TwilioResponse();
            response.Say("Hello there! You have successfully configured a web hook.");
            response.Say("Good luck on your Twilio quest!", new { Voice = "woman" });
           
            context.Response.Write(response.ToString());
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