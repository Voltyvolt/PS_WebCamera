<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Lockout.aspx.cs" Inherits="PSAdmin.Lockout" %>

<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">

    
    <div class="accountHeader">
        <h2>ออกจากระบบเรียบร้อยแล้ว</h2>
        <p>
            ขณะนี้ได้ออกจากระบบเรียบร้อยแล้ว หากต้องการใช้งานอีกครั้ง กรุณาเข้าสู่ระบบ&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/Account/Login.aspx">ที่นี่</asp:HyperLink>
        </p>
    </div>
</asp:content>