<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Login.aspx.cs" Inherits="PSAdmin.Login" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnLogin" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>--%>
    <dx:ASPxFormLayout ID="ASPxLayoutLogin" runat="server" EnableTheming="True" Theme="Moderno">
        <Items>
            <dx:LayoutItem Caption="">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxLabel ID="ASPxLayoutLogin_E1" runat="server" Font-Bold="True" Text="กรุณาระบุ รหัสผู้ใช้ และ รหัสผ่าน">
                        </dx:ASPxLabel>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxLabel ID="lbAlert" runat="server" ForeColor="Red">
                        </dx:ASPxLabel>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox ID="txtUser" runat="server" Caption="รหัสผู้ใช้" Width="200px">
                            <CaptionSettings Position="Top" />
                            <ValidationSettings>
                                <RequiredField ErrorText="กรุณาระบุรหัสผู้ใช้งาน" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox ID="txtPass" runat="server" Caption="รหัสผ่าน" Width="200px" ClientInstanceName="txtPass" Password="True">
                            <CaptionSettings Position="Top" />
                            <ValidationSettings>
                                <RequiredField ErrorText="กรุณาระบุรหัสผ่าน" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:EmptyLayoutItem>
            </dx:EmptyLayoutItem>
            <dx:LayoutItem Caption="">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxButton ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="เข้าสู่ระบบ" Width="200px">
                            <Image IconID="businessobjects_bopermission_16x16">
                            </Image>
                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="" HorizontalAlign="Left" Width="200px">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxHyperLink ID="ASPxLayoutLogin_E2" runat="server" Cursor="pointer" NavigateUrl="~/Account/ResetPassword.aspx" Text="รีเซ็ตรหัสผ่าน">
                        </dx:ASPxHyperLink>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
        </Items>
    </dx:ASPxFormLayout>

<%--        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnLogin" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>--%>
</asp:Content>