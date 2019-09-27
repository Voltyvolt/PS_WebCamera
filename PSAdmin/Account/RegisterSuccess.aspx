<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="RegisterSuccess.aspx.cs" Inherits="PSAdmin.RegisterSuccess" %>

<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">
    <div class="accountHeader">
    <h2>ลงทะเบียน</h2>
    <p>ลงทะเบียนเรียบร้อยแล้ว กรุณาเข้าสู่ระบบ.. 
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Account/Login.aspx">ที่นี่</asp:HyperLink>
        </p>
</div>
</asp:content>