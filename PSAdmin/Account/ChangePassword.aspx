<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="ChangePassword.aspx.cs" Inherits="PSAdmin.ChangePassword" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <div class="accountHeader">
        <table style="width:100%;">
            <tr>
                <td style="width: 50px">&nbsp;</td>
                <td>
                    <div class="accountHeader">
                        <h2 runat="server" ID="PageHeader">เปลี่ยนรหัสผ่าน</h2>
                        <p runat="server" ID="PageDescription">
            กรอกรายละเอียดตามแบบฟอร์มด้านล่าง</p>
                        <p style="color:red">
                            <asp:Literal runat="server" ID="ErrorMessage" />
                        </p>
                    </div>
                    <dx:ASPxTextBox ID="tbCurrentPassword" runat="server" Caption="รหัสเดิม" Password="true" Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="กรุณาระบุ รหัสเดิมของท่าน" IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="tbPassword" ClientInstanceName="Password" Caption="รหัสผ่านใหม่" Password="true" runat="server"
      Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="กรุณาระบุ รหัสผ่านใหม่" IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="tbConfirmPassword" Password="True" Caption="ยืนยันรหัสผ่าน" runat="server" Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="กรุณาระบุ รหัสยืนยัน" IsRequired="true" />
                        </ValidationSettings>
                        <ClientSideEvents Validation="function(s, e) {
    }" />
                    </dx:ASPxTextBox>
                    <br />
                    <dx:ASPxButton ID="btnChangePassword" runat="server" Text="เปลี่ยนรหัสผ่าน" ValidationGroup="ChangeUserPasswordValidationGroup"
    OnClick="btnChangePassword_Click" Width="200px">
                        <Image IconID="save_save_16x16">
                        </Image>
                    </dx:ASPxButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 50px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </h2>
    </div>
    </asp:Content>