<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="ResetPassword.aspx.cs" Inherits="PSAdmin.ResetPassword" %>

<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">
     
    <table style="width: 100%;">
        <tr>
            <td style="width: 50px">&nbsp;</td>
            <td>
                <h2>�������ʼ�ҹ</h2>
                <h4>��س��к� ���ʼ����ҹ ��� Email �������Ѥ����͹�á<dx:ASPxTextBox runat="server" ID="txtUserID" Caption="���ʼ����ҹ" ClientInstanceName="Password" Width="200px">
                    <CaptionSettings Position="Top" />
                    <ValidationSettings>
                        <RequiredField IsRequired="true" ErrorText="��س��к����ʼ����ҹ" />
                    </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox runat="server" ID="txtEmail" Caption="Email" Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings>
                            <RequiredField IsRequired="true" ErrorText="��س��к� Email �������Ѥ�" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                </h4>
                <h4>
                    <dx:ASPxButton runat="server" ID="Reset" Text="�觢�����" OnClick="Reset_Click" Width="200px" >
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