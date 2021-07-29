<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="ChangePasswordSuccess.aspx.cs" Inherits="PS_WebCamera.ChangePasswordSuccess" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="accountHeader">
    <h2>เปลี่ยนรหัสผ่าน</h2>
    <p>รหัสผ่านของท่านได้เปลี่ยนใหม่เรียบร้อยแล้ว กรุณาเข้าสู่ระบบใหม่อีกครั้ง 
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Account/Login.aspx">ที่นี่</asp:HyperLink>
    </p>
</div>
</asp:Content>