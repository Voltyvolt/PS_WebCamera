<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="frmAdmin.aspx.cs" Inherits="PSAdmin.frmAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="750px">
            <Panes>
                <dx:SplitterPane>
                    <ContentCollection>
<dx:SplitterContentControl runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" ShowCollapseButton="True" ShowHeader="False" Width="200px">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxRoundPanel ID="เลือกผู้ใช้" runat="server" HeaderText="เลือกผู้ใช้" ShowCollapseButton="True" Width="879px">
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                                <Items>
                                    <dx:LayoutGroup Caption="" ColCount="2">
                                        <Items>
                                            <dx:LayoutItem Caption="UserID" ColSpan="2">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox ID="cmbUserID" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbUserID_SelectedIndexChanged" Width="350px">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="รหัสพนักงาน" ColSpan="2">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxTextBox ID="txtUserEmpID" runat="server" Width="350px">
                                                        </dx:ASPxTextBox>
                                                        <br />
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxButton ID="btnEditUser" runat="server" OnClick="btnEditUser_Click" Text="Edit" Width="150px">
                                                            <Image IconID="save_saveto_16x16">
                                                            </Image>
                                                        </dx:ASPxButton>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxButton ID="btnCancelUser" runat="server" OnClick="btnCancelUser_Click" Text="Cancel" Width="150px">
                                                            <Image IconID="actions_cancel_16x16">
                                                            </Image>
                                                        </dx:ASPxButton>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                </Items>
                            </dx:ASPxFormLayout>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
                <br />
                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="รายละเอียด" HorizontalAlign="Center" ShowCollapseButton="True" Width="879px">
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server">
                                <Items>
                                    <dx:LayoutGroup Caption="แก้ไข" ColCount="4">
                                        <Items>
                                            <dx:LayoutItem Caption="User" ColSpan="4">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxTextBox ID="txtUser" runat="server">
                                                        </dx:ASPxTextBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="รหัสพนักงาน" ColSpan="4">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxTextBox ID="txtEmpID" runat="server">
                                                        </dx:ASPxTextBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="Email" ColSpan="4">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxTextBox ID="txtEmail" runat="server">
                                                        </dx:ASPxTextBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="โปรแกรม" ColSpan="2">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox ID="cmbCode" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbCode_SelectedIndexChanged">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="รายงาน" ColSpan="2">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxComboBox ID="cmbRep" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbRep_SelectedIndexChanged">
                                                        </dx:ASPxComboBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="เพิ่ม">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxCheckBox ID="chkAdd" runat="server" CheckState="Unchecked">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="แก้ไข">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxCheckBox ID="chkEdit" runat="server" CheckState="Unchecked">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="ลบ">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxCheckBox ID="chkDelete" runat="server" CheckState="Unchecked">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="อนุมัติ">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxCheckBox ID="chkApprove" runat="server" CheckState="Unchecked">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="ยกเลิกเอกสาร">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxCheckBox ID="chkCancel" runat="server" CheckState="Unchecked">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="พิมพ์">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxCheckBox ID="chkPrint" runat="server" CheckState="Unchecked">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="การเข้าถึง">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxCheckBox ID="chkEntry" runat="server" CheckState="Unchecked">
                                                        </dx:ASPxCheckBox>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="" ColSpan="2">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxButton ID="btnSaveDetail" runat="server" OnClick="btnSaveDetail_Click" Text="Save">
                                                            <Image IconID="save_saveto_16x16">
                                                            </Image>
                                                        </dx:ASPxButton>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                            <dx:LayoutItem Caption="" ColSpan="2">
                                                <LayoutItemNestedControlCollection>
                                                    <dx:LayoutItemNestedControlContainer runat="server">
                                                        <dx:ASPxButton ID="btnCancelDetail" runat="server" OnClick="btnCancelDetail_Click" Text="Cancel">
                                                            <Image IconID="actions_cancel_16x16">
                                                            </Image>
                                                        </dx:ASPxButton>
                                                    </dx:LayoutItemNestedControlContainer>
                                                </LayoutItemNestedControlCollection>
                                            </dx:LayoutItem>
                                        </Items>
                                    </dx:LayoutGroup>
                                </Items>
                            </dx:ASPxFormLayout>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
                        </dx:SplitterContentControl>
</ContentCollection>
                </dx:SplitterPane>
                <dx:SplitterPane>
                    <ContentCollection>
<dx:SplitterContentControl runat="server">
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False">
        <SettingsPager PageSize="17">
        </SettingsPager>
        <Columns>
            <dx:GridViewDataTextColumn Caption="UserID" ShowInCustomizationForm="True" VisibleIndex="0" FieldName="Permission_UserID">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="รหัสโปรแกรม" ShowInCustomizationForm="True" VisibleIndex="1" FieldName="Permission_Code">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="เพิ่ม" ShowInCustomizationForm="True" VisibleIndex="2" FieldName="Permission_New">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="แก้ไข" ShowInCustomizationForm="True" VisibleIndex="3" FieldName="Permission_Edit">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="ลบ" ShowInCustomizationForm="True" VisibleIndex="4" FieldName="Permission_Del">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="อนุมัติ" ShowInCustomizationForm="True" VisibleIndex="5" FieldName="Permission_AppDoc">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="ยกเลิก" ShowInCustomizationForm="True" VisibleIndex="6" FieldName="Permission_CancelDoc">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="พิมพ์" ShowInCustomizationForm="True" VisibleIndex="7" FieldName="Permission_Print">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="การเข้าถึง" ShowInCustomizationForm="True" VisibleIndex="8" FieldName="Permission_Entry">
            </dx:GridViewDataTextColumn>
        </Columns>
    </dx:ASPxGridView>
                        </dx:SplitterContentControl>
</ContentCollection>
                </dx:SplitterPane>
            </Panes>
        </dx:ASPxSplitter>
    </p>
</asp:Content>
