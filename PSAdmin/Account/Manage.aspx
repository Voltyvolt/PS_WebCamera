<%@ Page Title="" Language="C#" MasterPageFile="~/Light.master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="PSAdmin.WebForm1" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
        <table style="width: 100%;">
            <tr>
                <td style="width: 50px">&nbsp;</td>
                <td>
                    <div class="accountHeader">
                        <h2>แก้ไขการตั้งค่า</h2>
                        <ul>
                            <li>รหัสผ่าน:
                                <dx:ASPxHyperLink NavigateUrl="/Account/ChangePassword.aspx" Text="[แก้ไข]" ID="ChangePassword" runat="server" />
                            </li>
                        </ul>
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
