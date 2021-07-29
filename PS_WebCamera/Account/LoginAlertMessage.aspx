<%@ Page Title="" Language="C#" MasterPageFile="~/Light.master" AutoEventWireup="true" CodeBehind="LoginAlertMessage.aspx.cs" Inherits="PS_WebCamera.Account.LoginAlertMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="width: 50px">&nbsp;</td>
            <td>
                <div class="accountHeader">
                    <h2>กรุณาเข้าสู่ระบบก่อน</h2>
                    <p>
                        ระบบไม่พบข้อมูลของท่าน กรุณาเข้าสู่ระบบก่อน คลิก..
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Account/Login.aspx">ที่นี่</asp:HyperLink>
                    </p>
                </div>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 50px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
