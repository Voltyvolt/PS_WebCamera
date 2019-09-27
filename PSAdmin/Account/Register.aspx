<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Register.aspx.cs" Inherits="PSAdmin.Register" %>

<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">

    <dx:ASPxFormLayout ID="ASPxLayoutLogin" runat="server" EnableTheming="True" Theme="Moderno" ColCount="2" Font-Size="Smaller">
        <Items>
            <dx:LayoutItem Caption="" ColSpan="2" HorizontalAlign="Left">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxLabel ID="ASPxLayoutLogin_E1" runat="server" Font-Bold="True" Text="ลงทะเบียนเข้าใช้งาน">
                        </dx:ASPxLabel>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="" ColSpan="2" HorizontalAlign="Left">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxLabel ID="lbAlert" runat="server" ForeColor="Red">
                        </dx:ASPxLabel>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="" ColSpan="2" HorizontalAlign="Left">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox ID="txtUser" runat="server" Caption="รหัสผู้ใช้" Width="200px">
                            <CaptionSettings Position="Top" />
                            <ValidationSettings>
                                <RequiredField ErrorText="กรุณาระบุ รหัสผุ้ใช้งาน" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="" ColSpan="2" HorizontalAlign="Left">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox ID="txtPass" runat="server" Caption="รหัสผ่าน" Width="200px" Password="True">
                            <CaptionSettings Position="Top" />
                            <ValidationSettings>
                                <RequiredField ErrorText="กรุณาระบุ รหัสผ่าน" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="" ColSpan="2" HorizontalAlign="Left">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox ID="txtConfirmPass" runat="server" Caption="ยืนยันรหัสผ่าน" Width="200px" Password="True">
                            <CaptionSettings Position="Top" />
                            <ValidationSettings>
                                <RequiredField ErrorText="กรูณาระบุ รหัสยืนยัน" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="" ColSpan="2" HorizontalAlign="Left">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox ID="txtEmpID" runat="server" Caption="รหัสพนักงาน" Width="200px">
                            <CaptionSettings Position="Top" />
                            <ValidationSettings>
                                <RequiredField ErrorText="กรุณาระบุ รหัสพนักงาน " IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="" HorizontalAlign="Left">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxTextBox ID="txtEmail" runat="server" Caption="E-Mail (สามารถใช้รีเซ็ตรหัสผ่านได้)" Width="200px">
                            <HelpTextSettings Position="Top">
                            </HelpTextSettings>
                            <CaptionSettings Position="Top" />
                            <ValidationSettings>
                                <RequiredField ErrorText="กรุณาระบุ Email ที่ใช้อยู่ปัจจุบัน" IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem HorizontalAlign="Left" ShowCaption="False" VerticalAlign="Middle">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="" ColSpan="2" HorizontalAlign="Left">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxButton ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="ลงทะเบียน" Width="200px">
                            <Image IconID="save_save_16x16">
                            </Image>
                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
        </Items>
    </dx:ASPxFormLayout>

</asp:content>