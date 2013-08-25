# Welcome to the .NET Guild!

As members of the .NET guild, you will be working through the challenges of TwilioQuest using ASP.NET with either C# or VB.NET programming languages.  This startup project is pre-configured to do some interesting Twilio stuff, allowing you to verify your development environment is configured properly.

## Setting Up

We assume that before you begin you will have some flavor of Visual Studio 2010 or newer installed.  The free [Visual Studio Express for Web 2010]() [or newer]() will also work fine.

The projects contain libraries that have been installed using the NuGet package manager extension available for Visual Studio 2010 and 2012.  By default, Microsoft Visual Studio 2010 installs version 1.2 of NuGet. Installing the Twilio libraries requires version 1.6 of NuGet or higher. For information on installing or updating NuGet, see http://nuget.org/.

NOTE
To install the latest verison of NuGet, you must first uninstall the loaded version using the Visual Studio Extension Manager. To do so, you must run Visual Studio as administrator. Otherwise, the Uninstall button is disabled.

Four different Visual Studio solutions are available:

* twilio-dotnet-mvc4-2012 - A Visual Studio 2012 solution that contains a single ASP.NET MVC 4 project
* twilio-dotnet-webforms-2012 - A Visual Studio 2012 solution that contains a single ASP.NET WebForms project
* twilio-dotnet-mvc3-2010 - A Visual Studio 2010 solution that contains a single ASP.NET MVC 3 project
* twilio-dotnet-webforms-2010 - A Visual Studio 2010 solution that contains a single ASP.NET WebForms project

Before you can run any of these projects, you will need to set modify the return values of three static properties located in the Settings.cs file.  These are:

* `AccountSid` : Your Twilio "account SID" - it's like your username for the Twilio API.  This and the auth token (below) can be found [on your account dashboard](https://www.twilio.com/user/account).
* `AuthToken` : Your Twilio "auth token" - it's your password for the Twilio API.  This and the account SID (above) can be found [on your account dashboard](https://www.twilio.com/user/account).
* `TwilioNumber` : A Twilio number that you own, that can be used for making calls and sending messages.  You can find a list of phone numbers you control (and buy another one, if necessary) [in the account portal](https://www.twilio.com/user/account/phone-numbers/incoming).

## Running the application

[Download the project source code directly](https://github.com/twilio/starter-ditnet/archive/master.zip) or [clone the repository on GitHub](https://github.com/twilio/starter-dotnet).  Navigate to the folder with the source code on your machine.

[solutions include nuget package restore.  build the project to make sure the nuget dependencies are downloaded and installed]

## Begin Questing!
This is but your first step into a larger world.  [Return to TwilioQuest](http://quest.twilio.com) to continue your adventure.  Huzzah!
