<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="twilio_dotnet.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Twilio Jumpstart!</title>

        <!-- A little CSS to make our page prettier -->
    <link rel="stylesheet" runat="server" href="~/Content/app.css"/>
    <link rel="icon" type="image/png" runat="server" href="~/Content/favicon.css">

    <!-- Third Party JavaScript Dependencies -->
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js"></script>
    <script src="//static.twilio.com/libs/twiliojs/1.1/twilio.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">

    <!-- A simple UI to test our Twilio back end -->
    <div id="content">
        <img id="logo" src="~/Content/img/twilio.png" runat="server" alt="Twilio: Cloud Communications"/>

        <!-- A phone number to use for these simple tests -->
        <input id="number" type="text" placeholder="Enter your mobile phone number" autofocus="true" value=""/>

        <!-- Exercise various pieces of Twilio functionality -->
        <button id="text">Send Me a Text</button>
        <button id="call">Call My Phone</button>
        <button id="voip">Outbound Call from My Browser</button>
    </div>

    <!-- include our application logic -->
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Path="~/Scripts/app.js" />
        </Scripts>
    </asp:ScriptManager>
B
    </form>
</body>
</html>