<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="frmQuota.aspx.cs" Inherits="PSAdmin.PS_CaneData.frmQuota" %>
<%@ Register assembly="DevExpress.Web.ASPxSpreadsheet.v17.1, Version=17.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpreadsheet" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="ข้อมูลโควต้า" Width="100%">
        <HeaderStyle Font-Bold="True" Font-Size="20pt" HorizontalAlign="Center" />
        <PanelCollection>
            <dx:PanelContent runat="server">
                <table style="width:100%;">
                    <tr>
                        <td>
                            <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="4000px" Width="100%">
                                <Panes>
                                    <dx:SplitterPane AutoWidth="True" MaxSize="250px">
                                        <ContentCollection>
                                            <dx:SplitterContentControl runat="server">
                                                <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Width="250px">
                                                    <Items>
                                                        <dx:LayoutItem Caption="เลขโควตา" HorizontalAlign="Left" Width="300px">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxTextBox ID="txtQuota" runat="server" Width="200px" HorizontalAlign="Center" ReadOnly="True">
                                                                        <ValidationSettings SetFocusOnError="True" CausesValidation="True" ValidationGroup="A">
                                                                            <RequiredField IsRequired="True" />
                                                                        </ValidationSettings>
                                                                    </dx:ASPxTextBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <CaptionSettings HorizontalAlign="Left" Location="Top" />
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem Caption="คำนำหน้า" HorizontalAlign="Left" Width="300px">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxComboBox ID="txtPrefix" runat="server" SelectedIndex="0" Width="200px">
                                                                        <Items>
                                                                            <dx:ListEditItem Selected="True" Text="นาย" Value="นาย" />
                                                                            <dx:ListEditItem Text="นาง" Value="นาง" />
                                                                            <dx:ListEditItem Text="นางสาว" Value="นางสาว" />
                                                                        </Items>
                                                                        <ValidationSettings SetFocusOnError="True" ValidationGroup="A">
                                                                        </ValidationSettings>
                                                                    </dx:ASPxComboBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <CaptionSettings HorizontalAlign="Left" Location="Top" />
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem Caption="ชื่อ" HorizontalAlign="Left" Width="300px">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxTextBox ID="txtName" runat="server" Width="200px">
                                                                        <ValidationSettings SetFocusOnError="True" CausesValidation="True" ValidationGroup="A">
                                                                            <RequiredField IsRequired="True" />
                                                                        </ValidationSettings>
                                                                    </dx:ASPxTextBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <CaptionSettings HorizontalAlign="Left" Location="Top" />
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem Caption="นามสกุล" HorizontalAlign="Left" Width="300px">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxTextBox ID="txtLName" runat="server" Width="200px">
                                                                        <ValidationSettings SetFocusOnError="True" CausesValidation="True" ValidationGroup="A">
                                                                            <RequiredField IsRequired="True" />
                                                                        </ValidationSettings>
                                                                    </dx:ASPxTextBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <CaptionSettings HorizontalAlign="Left" Location="Top" />
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem Caption="เลขบัตรประชาชน" HorizontalAlign="Left" Width="300px">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxTextBox ID="txtCard" runat="server" Width="200px">
                                                                        <ValidationSettings SetFocusOnError="True" CausesValidation="True" ValidationGroup="A">
                                                                            <RequiredField IsRequired="True" />
                                                                        </ValidationSettings>
                                                                    </dx:ASPxTextBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <CaptionSettings HorizontalAlign="Left" Location="Top" />
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem Caption="ที่อยู่" HorizontalAlign="Left" Width="300px">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxMemo ID="txtAddress" runat="server" Height="100px" Width="200px">
                                                                    </dx:ASPxMemo>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <CaptionSettings HorizontalAlign="Left" Location="Top" />
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem Caption="เขต" HorizontalAlign="Left" Width="300px">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxComboBox ID="txtKet" runat="server" Width="200px">
                                                                        <Items>
                                                                            <dx:ListEditItem Text="1" Value="1" />
                                                                            <dx:ListEditItem Text="2" Value="2" />
                                                                            <dx:ListEditItem Text="3" Value="3" />
                                                                            <dx:ListEditItem Text="4" Value="4" />
                                                                            <dx:ListEditItem Text="5" Value="5" />
                                                                            <dx:ListEditItem Text="6" Value="6" />
                                                                            <dx:ListEditItem Text="7" Value="7" />
                                                                            <dx:ListEditItem Text="8" Value="8" />
                                                                            <dx:ListEditItem Text="9" Value="9" />
                                                                            <dx:ListEditItem Text="10" Value="10" />
                                                                            <dx:ListEditItem Text="11" Value="11" />
                                                                            <dx:ListEditItem Text="12" Value="12" />
                                                                            <dx:ListEditItem Text="13" Value="13" />
                                                                            <dx:ListEditItem Text="14" Value="14" />
                                                                            <dx:ListEditItem Text="15" Value="15" />
                                                                            <dx:ListEditItem Text="16" Value="16" />
                                                                            <dx:ListEditItem Text="17" Value="17" />
                                                                            <dx:ListEditItem Text="18" Value="18" />
                                                                            <dx:ListEditItem Text="0" Value="0" />
                                                                        </Items>
                                                                        <ValidationSettings CausesValidation="True" SetFocusOnError="True" ValidationGroup="A">
                                                                            <RequiredField IsRequired="True" />
                                                                        </ValidationSettings>
                                                                    </dx:ASPxComboBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <CaptionSettings HorizontalAlign="Left" Location="Top" />
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem Caption="สาย" HorizontalAlign="Left" Width="300px">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxTextBox ID="txtSai" runat="server" Width="200px">
                                                                        <ValidationSettings CausesValidation="True" SetFocusOnError="True" ValidationGroup="A">
                                                                            <RequiredField IsRequired="True" />
                                                                        </ValidationSettings>
                                                                    </dx:ASPxTextBox>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <CaptionSettings HorizontalAlign="Left" Location="Top" />
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem HorizontalAlign="Left" ShowCaption="False">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxButton ID="btnSave" runat="server" Height="50px" Text="บันทึกข้อมูล" Width="200px" OnClick="btnSave_Click" ValidationGroup="A">
                                                                        <Image IconID="save_save_16x16">
                                                                        </Image>
                                                                    </dx:ASPxButton>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                        <dx:LayoutItem Caption="Layout Item" HorizontalAlign="Left" ShowCaption="False">
                                                            <LayoutItemNestedControlCollection>
                                                                <dx:LayoutItemNestedControlContainer runat="server">
                                                                    <dx:ASPxButton ID="btnClear" runat="server" Height="50px" OnClick="btnClear_Click" Text="ยกเลิก" Width="200px">
                                                                        <Image IconID="actions_clear_32x32">
                                                                        </Image>
                                                                    </dx:ASPxButton>
                                                                </dx:LayoutItemNestedControlContainer>
                                                            </LayoutItemNestedControlCollection>
                                                            <Paddings PaddingLeft="35px" />
                                                        </dx:LayoutItem>
                                                    </Items>
                                                </dx:ASPxFormLayout>
                                            </dx:SplitterContentControl>
                                        </ContentCollection>
                                    </dx:SplitterPane>
                                    <dx:SplitterPane>
                                        <ContentCollection>
                                            <dx:SplitterContentControl runat="server">
                                                <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="ASPxGridView1_RowCommand" Width="100%" OnPageIndexChanged="ASPxGridView1_PageIndexChanged">
                                                    <SettingsPager PageSize="50">
                                                    </SettingsPager>
                                                    <Settings ShowFilterRow="True" />
                                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                                    <Columns>
                                                        <dx:GridViewCommandColumn ShowClearFilterButton="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                                        </dx:GridViewCommandColumn>
                                                        <dx:GridViewDataTextColumn Caption="โควตา" FieldName="Q_ID" ShowInCustomizationForm="True" VisibleIndex="1" Width="50px">
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <CellStyle HorizontalAlign="Center">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="คำนำหน้า" FieldName="Q_Prefix" ShowInCustomizationForm="True" VisibleIndex="2" Width="50px">
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <CellStyle HorizontalAlign="Center">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="ชื่อ" FieldName="Q_FirstName" ShowInCustomizationForm="True" VisibleIndex="3">
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <CellStyle HorizontalAlign="Left">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="นามสกุล" FieldName="Q_LastName" ShowInCustomizationForm="True" VisibleIndex="4">
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <CellStyle HorizontalAlign="Left">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="เขต" FieldName="Q_Ket" ShowInCustomizationForm="True" VisibleIndex="5" Width="50px">
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <CellStyle HorizontalAlign="Center">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="สาย" FieldName="Q_KetDisplay" ShowInCustomizationForm="True" VisibleIndex="6" Width="50px">
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <CellStyle HorizontalAlign="Center">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="เลขบัตรประชาชน" FieldName="Q_CardID" ShowInCustomizationForm="True" VisibleIndex="7">
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <CellStyle HorizontalAlign="Center">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="ที่อยู่" FieldName="Q_Address" ShowInCustomizationForm="True" VisibleIndex="8">
                                                            <HeaderStyle HorizontalAlign="Center" />
                                                            <CellStyle HorizontalAlign="Left">
                                                            </CellStyle>
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataButtonEditColumn Caption="แก้ไข" ShowInCustomizationForm="True" VisibleIndex="9" Width="20px">
                                                            <DataItemTemplate>
                                                                <dx:ASPxButton ID="btnTEdit" runat="server" CommandName="E" Theme="Moderno" UseSubmitBehavior="False" Width="10px" RenderMode="Link" ValidateRequestMode="Disabled">
                                                                    <Image IconID="edit_edit_16x16">
                                                                    </Image>
                                                                </dx:ASPxButton>
                                                            </DataItemTemplate>
                                                            <CellStyle HorizontalAlign="Center" VerticalAlign="Middle">
                                                            </CellStyle>
                                                        </dx:GridViewDataButtonEditColumn>
                                                    </Columns>
                                                </dx:ASPxGridView>
                                            </dx:SplitterContentControl>
                                        </ContentCollection>
                                    </dx:SplitterPane>
                                </Panes>
                            </dx:ASPxSplitter>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <table style="width: 100%;">
        <tr>
            <td style="height: 90px"></td>
            <td style="height: 90px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="TopLeft_Table_1">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 25px"></td>
            <td style="height: 25px"></td>
        </tr>
    </table>
</asp:Content>
