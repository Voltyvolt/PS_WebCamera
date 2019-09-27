<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="ResetPassword.aspx.cs" Inherits="PSAdmin.ResetPassword" %>

<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">
     
    <table style="width: 100%;">
        <tr>
            <td style="width: 50px">&nbsp;</td>
            <td>
                <h2>รีเซ็ตรหัสผ่าน</h2>
                <h4>กรุณาระบุ รหัสผู้ใช้งาน และ Email ที่ใช้สมัครไว้ตอนแรก<dx:ASPxTextBox runat="server" ID="txtUserID" Caption="รหัสผุ้ใช้งาน" ClientInstanceName="Password" Width="200px">
                    <CaptionSettings Position="Top" />
                    <ValidationSettings>
                        <RequiredField IsRequired="true" ErrorText="กรุณาระบุรหัสผู้ใช้งาน" />
                    </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox runat="server" ID="txtEmail" Caption="Email" Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings>
                            <RequiredField IsRequired="true" ErrorText="กรุณาระบุ Email ที่ใช้สมัคร" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </h4>
                <h4>
                    <dx:ASPxButton runat="server" ID="Reset" Text="ส่งข้อมูล" OnClick="Reset_Click" Width="200px" >
                        <ClientSideEvents Click="function(s, e) {
	}" />
                        <Image IconID="mail_send_16x16">
                        </Image>
                    </dx:ASPxButton>
                </h4>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 50px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:content>