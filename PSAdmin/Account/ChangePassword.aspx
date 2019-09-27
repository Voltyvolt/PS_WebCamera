<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="ChangePassword.aspx.cs" Inherits="PSAdmin.ChangePassword" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <div class="accountHeader">
        <table style="width:100%;">
            <tr>
                <td style="width: 50px">&nbsp;</td>
                <td>
                    <div class="accountHeader">
                        <h2 runat="server" ID="PageHeader">����¹���ʼ�ҹ</h2>
                        <p runat="server" ID="PageDescription">
            ��͡��������´���Ẻ�������ҹ��ҧ</p>
                        <p style="color:red">
                            <asp:Literal runat="server" ID="ErrorMessage" />
                        </p>
                    </div>
                    <dx:ASPxTextBox ID="tbCurrentPassword" runat="server" Caption="�������" Password="true" Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="��س��к� ��������ͧ��ҹ" IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="tbPassword" ClientInstanceName="Password" Caption="���ʼ�ҹ����" Password="true" runat="server"
      Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="��س��к� ���ʼ�ҹ����" IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="tbConfirmPassword" Password="True" Caption="�׹�ѹ���ʼ�ҹ" runat="server" Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="��س��к� �����׹�ѹ" IsRequired="true" />
                        </ValidationSettings>
                        <ClientSideEvents Validation="function(s, e) {
    }" />
                    </dx:ASPxTextBox>
                    <br />
                    <dx:ASPxButton ID="btnChangePassword" runat="server" Text="����¹���ʼ�ҹ" ValidationGroup="ChangeUserPasswordValidationGroup"
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