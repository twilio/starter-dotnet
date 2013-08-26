using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace twilio_dotnet
{
    public static class Settings
    {
        public static string AccountSid { get { return "[YOUR_ACCOUNT_SID]"; } }
        public static string AuthToken { get { return "[YOUR_AUTH_TOKEN]"; } }

        public static string TwilioNumber { get { return "[YOUR_TWILIO_PHONE_NUMBER]"; } }

        public static string BaseUrl { get { return "[YOUR_SERVER_URL]"; } }
    }
}