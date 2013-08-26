using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.TwiML;
using Twilio.TwiML.Mvc;

namespace twilio_dotnet.Controllers
{
    public class HomeController : TwilioController
    {
        TwilioRestClient client;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sms(string to)
        {
            client = new TwilioRestClient(Settings.AccountSid, Settings.AuthToken);

            var result = client.SendSmsMessage(Settings.TwilioNumber, to, "Hello there! Your Twilio environment has been configured.");

            if (result.RestException != null)
            {
                return new System.Web.Mvc.HttpStatusCodeResult(500, result.RestException.Message);
            }

            return Json(new { error = false });
        }

        public ActionResult Call(string to)
        {
            client = new TwilioRestClient(Settings.AccountSid, Settings.AuthToken);

            var result = client.InitiateOutboundCall(Settings.TwilioNumber, to, Settings.BaseUrl + Url.Action("Hello"));

            if (result.RestException != null)
            {
                return new System.Web.Mvc.HttpStatusCodeResult(500, result.RestException.Message);
            }

            return Json(new { error = false });
        }

        public ActionResult Capability()
        {
            var capability = new TwilioCapability(Settings.AccountSid, Settings.AuthToken);
            capability.AllowClientOutgoing("AP784bd34e34fab9759b8e91d3ef3680b9");

            return Json(new { token = capability.GenerateToken() });
        }

        public ActionResult Hello()
        {
            var response = new TwilioResponse();
            response.Say("Hello there! Your Twilio environment has been configured.");
            response.Say("Good luck during the workshop!", new { Voice = "woman" });
            return TwiML(response);
        }
    }
}
