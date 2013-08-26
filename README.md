# Welcome to the .NET Guild!

As members of the .NET guild, you will be working through the challenges of TwilioQuest using ASP.NET with either C# or VB.NET programming languages.  This startup project is pre-configured to do some interesting Twilio stuff, allowing you to verify your development environment is configured properly.  

Please read this document carefully to make sure you have the appropriate prerequisites installed in order to run the starter project.

## Setting Up

First, we assume that before you begin you will have some flavor of Visual Studio 2010 or newer installed.  You can also use [Visual Studio Express for Web 2010](http://www.microsoft.com/visualstudio/eng/downloads#d-2010-express) or [Visual Studio Express for Web 2012](http://www.microsoft.com/visualstudio/eng/downloads#d-2012-express) if you are looking for free alternatives.

Second, the starter projects makes use of the free NuGet package manager to manage several project dependencies.  On first build of the project, Visual Studio will use NuGet to download and restore the required depencencies.  If you are using Visual Studio 2010, you may need to upgrade your installed version of NuGet to version 1.6 or higher.  For information on installing or updating NuGet, see http://nuget.org/.

**Note**
To install the latest verison of NuGet, you must first uninstall the loaded version using the Visual Studio Extension Manager. To do so, you must run Visual Studio as administrator. Otherwise, the Uninstall button is disabled.

## Running the application

Once you have Visual Studio and NuGet installed, you can choose the type of starter template project you want to use.  We have provided the template in four different flavors:

* `twilio-dotnet-mvc4-2012` : A Visual Studio 2012 solution that contains an ASP.NET MVC 4 project
* `twilio-dotnet-webforms-2012` : A Visual Studio 2012 solution that contains an ASP.NET WebForms project
* `twilio-dotnet-mvc3-2010` : A Visual Studio 2010 solution that contains an ASP.NET MVC 3 project
* `twilio-dotnet-webforms-2010` : A Visual Studio 2010 solution that contains an ASP.NET WebForms project

[Download the project source code directly](https://github.com/twilio/starter-ditnet/archive/master.zip) or [clone the repository on GitHub](https://github.com/twilio/starter-dotnet), and open the solution file that best matches platform you'd like to use.

Once you've opened the correct solutoin file, before you can run any of these projects you will need to modify the return values of three static properties located in the Settings.cs file.  These are:

* `AccountSid` : Your Twilio "account SID" - it's like your username for the Twilio API.  This and the auth token (below) can be found [on your account dashboard](https://www.twilio.com/user/account).
* `AuthToken` : Your Twilio "auth token" - it's your password for the Twilio API.  This and the account SID (above) can be found [on your account dashboard](https://www.twilio.com/user/account).
* `TwilioNumber` : A Twilio number that you own, that can be used for making calls and sending messages.  You can find a list of phone numbers you control (and buy another one, if necessary) [in the account portal](https://www.twilio.com/user/account/phone-numbers/incoming).

Build the project to make sure the nuget dependencies are downloaded and installed and then run the project.

## Begin Questing!
This is but your first step into a larger world.  [Return to TwilioQuest](http://quest.twilio.com) to continue your adventure.  Huzzah!
