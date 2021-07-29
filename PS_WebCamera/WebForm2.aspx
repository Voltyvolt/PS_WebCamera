<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PS_WebCamera.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxImage ID="ASPxImage1" runat="server" Height="112px" ShowLoadingImage="true" Width="154px">
            </dx:ASPxImage>
            <dx:ASPxButton ID="ASPxButton1" runat="server" OnClick="ASPxButton1_Click" Text="ASPxButton">
            </dx:ASPxButton>
        </div>
    </form>
</body>
</html>
