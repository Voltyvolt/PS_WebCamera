<%@ Page Title="Matching ข้อมูล" Language="C#" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeBehind="frmMatching.aspx.cs" Inherits="PS_WebCamera.frmMatching" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
     
        <p>
        <br />
        <dx:ASPxLabel ID="ASPxLabel3" runat="server" Font-Size="X-Large" Text="Matching ข้อมูล">
        </dx:ASPxLabel>
        </p>
             
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Theme="DevEx">
        <Items>
            <dx:LayoutGroup Caption="ค้นหาข้อมูล" ColCount="15">
                <Items>
                    <dx:LayoutItem Caption="ราง" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxComboBox ID="cmb_Rail" runat="server" BackColor="#FFFF99" SelectedIndex="0">
                                    <Items>
                                        <dx:ListEditItem Selected="True" Text="เลือก" Value="0" />
                                        <dx:ListEditItem Text="A" Value="1" />
                                        <dx:ListEditItem Text="B" Value="2" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="วันที่" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                 <dx:ASPxDateEdit ID="cmb_SearchDate" runat="server" BackColor="#FFFF99" Date="2021-07-13" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" Width="100%">
                        </dx:ASPxDateEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="กะ" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxComboBox ID="cmb_Ka" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmb_Ka_SelectedIndexChanged" SelectedIndex="0" BackColor="#FFFF99">
                                    <Items>
                                        <dx:ListEditItem Selected="True" Text="เลือก" Value="0" />
                                        <dx:ListEditItem Text="กลางวัน" Value="1" />
                                        <dx:ListEditItem Text="กลางคืน" Value="2" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="ช่วงเวลา" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxComboBox ID="cmb_Time" runat="server" BackColor="#FFFF99">
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="ดั้มที่" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxComboBox ID="cmb_Dump" runat="server" BackColor="#FFFF99">
                                    <Items>
                                        <dx:ListEditItem Text="1" Value="0" />
                                        <dx:ListEditItem Text="2" Value="1" />
                                        <dx:ListEditItem Text="3" Value="2" />
                                        <dx:ListEditItem Text="4" Value="3" />
                                        <dx:ListEditItem Text="5" Value="4" />
                                        <dx:ListEditItem Text="6" Value="5" />
                                        <dx:ListEditItem Text="7" Value="6" />
                                        <dx:ListEditItem Text="8" Value="7" />
                                    </Items>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btn_Search" runat="server" Text="ค้นหา" Theme="MaterialCompact" OnClick="btn_Search_Click">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
    <br />

    <center>
        <div>

      </div>
    </center>

    <br />
    <br />
    <br />
    <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="900px">
        <Panes>
            <dx:SplitterPane ScrollBars="Auto">
                <ContentCollection>
<dx:SplitterContentControl runat="server">
                    <br />
    <dx:ASPxFormLayout ID="ASPxFormLayout6" runat="server">
        <Items>
            <dx:LayoutGroup Caption="" ColCount="12">
                <Items>
                    <dx:LayoutItem Caption="" ColSpan="6" VerticalAlign="Middle">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <asp:Image ID="AspImageShow1" runat="server" Height="200px" Width="300px" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6" VerticalAlign="Middle">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btnAdd1F" runat="server" Text="รูปที่ 1" OnClick="btnAdd1F_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd1S" runat="server" Text="รูปที่ 2" OnClick="btnAdd1S_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd1T" runat="server" Text="รูปที่ 3" OnClick="btnAdd1T_Click">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <asp:Image ID="AspImageShow2" runat="server" Height="200px" Width="300px" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btnAdd2F" runat="server" Text="รูปที่ 1" OnClick="btnAdd2F_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd2S" runat="server" Text="รูปที่ 2" OnClick="btnAdd2S_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd2T" runat="server" Text="รูปที่ 3" OnClick="btnAdd2T_Click">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <asp:Image ID="AspImageShow3" runat="server" Height="200px" Width="300px" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btnAdd3F" runat="server" Text="รูปที่ 1" OnClick="btnAdd3F_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd3S" runat="server" Text="รูปที่ 2" OnClick="btnAdd3S_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd3T" runat="server" Text="รูปที่ 3" OnClick="btnAdd3T_Click">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <asp:Image ID="AspImageShow4" runat="server" Height="200px" Width="300px" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btnAdd4F" runat="server" Text="รูปที่ 1" OnClick="btnAdd4F_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd4S" runat="server" Text="รูปที่ 2" OnClick="btnAdd4S_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd4T" runat="server" Text="รูปที่ 3" OnClick="btnAdd4T_Click">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <asp:Image ID="AspImageShow5" runat="server" Height="200px" Width="300px" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btnAdd5F" runat="server" Text="รูปที่ 1" OnClick="btnAdd5F_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd5S" runat="server" Text="รูปที่ 2" OnClick="btnAdd5S_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd5T" runat="server" Text="รูปที่ 3" OnClick="btnAdd5T_Click">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <asp:Image ID="AspImageShow6" runat="server" Height="200px" Width="300px" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btnAdd6F" runat="server" Text="รูปที่ 1" OnClick="btnAdd6F_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd6S" runat="server" Text="รูปที่ 2" OnClick="btnAdd6S_Click">
                                </dx:ASPxButton>
                                <dx:ASPxButton ID="btnAdd6T" runat="server" Text="รูปที่ 3" OnClick="btnAdd6T_Click">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6" HorizontalAlign="Left">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btn_After" runat="server" OnClick="btn_After_Click" Text="ย้อนกลับ" Theme="MetropolisBlue" Width="75px">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="" ColSpan="6" HorizontalAlign="Right">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxButton ID="btn_Next" runat="server" OnClick="btn_Next_Click" Text="ถัดไป" Theme="MetropolisBlue" Width="75px">
                                </dx:ASPxButton>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
                    </dx:SplitterContentControl>
</ContentCollection>
            </dx:SplitterPane>
            <dx:SplitterPane  ScrollBars="Auto">
                <ContentCollection>
<dx:SplitterContentControl runat="server">
    <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
        <Items>
            <dx:LayoutGroup Caption="ตารางข้อมูล">
                <Items>
                    <dx:LayoutItem Caption="">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <right><dx:ASPxButton ID="ASPxButton22" runat="server" Text="พิมพ์รายงาน" Theme="MaterialCompact" OnClick="ASPxButton22_Click">
                                </dx:ASPxButton>
                                    </right>
                                <br />
                                <dx:ASPxGridView ID="GridV1" runat="server" AutoGenerateColumns="False" EnableTheming="True" OnRowCommand="GridV1_RowCommand" Theme="MaterialCompact" Width="742px">
                                    <Columns>
                                        <dx:GridViewDataTextColumn Caption="ดั้มที่" FieldName="I_Dump" ShowInCustomizationForm="True" VisibleIndex="1">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="วันที่" FieldName="I_Date" ShowInCustomizationForm="True" VisibleIndex="2">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="เวลา" FieldName="I_Time" ShowInCustomizationForm="True" VisibleIndex="3">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="เลือก" ShowInCustomizationForm="True" VisibleIndex="7">
                                            <DataItemTemplate>
                                                <dx:ASPxButton ID="ASPxButton21" runat="server" CommandName="E" Text="เลือก" Theme="Material">
                                                </dx:ASPxButton>
                                            </DataItemTemplate>
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="ราง" FieldName="I_Rail" ShowInCustomizationForm="True" VisibleIndex="0">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="รูปที่ 1" FieldName="I_Name_30" ShowInCustomizationForm="True" Visible="False" VisibleIndex="4">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="รูปที่ 2" FieldName="I_Name_45" ShowInCustomizationForm="True" Visible="False" VisibleIndex="5">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="รูปที่ 3" FieldName="I_Name_60" ShowInCustomizationForm="True" Visible="False" VisibleIndex="6">
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                    <Border BorderColor="#0066FF" BorderStyle="Solid" BorderWidth="2px" />
                                </dx:ASPxGridView>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
    <br />
    <dx:ASPxFormLayout ID="ASPxFormLayout5" runat="server" Width="500px">
        <Items>
            <dx:LayoutGroup Caption="ข้อมูลรูปภาพ" ColCount="12">
                <Items>
                    <dx:LayoutItem Caption="วันที่" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtDate" runat="server" ReadOnly="True">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="ดั้มที่" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtDump" runat="server" ReadOnly="True">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="เวลา" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtTime" runat="server" ReadOnly="True">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="เลขที่คิว" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtQNo" runat="server" AutoPostBack="True" OnTextChanged="txtQNo_TextChanged" BackColor="#FFFF99">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="โควต้า" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtQuota" runat="server" Enabled="False" ReadOnly="True">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="ทะเบียนรถ" ColSpan="4">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txtCarNum" runat="server" Enabled="False" ReadOnly="True">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
                    <br />
    <center>
        <dx:ASPxImage ID="ASPxImage1" runat="server" Height="200px" ImageUrl="~/images/568122.png" ShowLoadingImage="True" Width="300px">
    </dx:ASPxImage>
        <br />
        <dx:ASPxLabel runat="server" Text="รูปที่ 1" ID="lbName1"></dx:ASPxLabel>
        <br />
        <br />
         <dx:ASPxImage ID="ASPxImage2" runat="server" Height="200px" ImageUrl="~/images/568122.png" ShowLoadingImage="True" Width="300px">
    </dx:ASPxImage>
        <br />
        <dx:ASPxLabel runat="server" Text="รูปที่ 2" ID="lbName2"></dx:ASPxLabel>
        <br />
        <br />
         <dx:ASPxImage ID="ASPxImage3" runat="server" Height="200px" ImageUrl="~/images/568122.png" ShowLoadingImage="True" Width="300px">
    </dx:ASPxImage>
        <br />
        <dx:ASPxLabel runat="server" Text="รูปที่ 3" ID="lbName3"></dx:ASPxLabel>
        <br />
        <br />
        
    </center>
    <div>
        <center>
          
                                    <dx:ASPxButton ID="btn_Delete" runat="server" OnClick="btn_Delete_Click" Text="ลบข้อมูล" Theme="Mulberry">
                                    </dx:ASPxButton>
                                
                                   <dx:ASPxButton ID="btn_Cancel" runat="server" Text="ยกเลิก" Theme="Mulberry" OnClick="btn_Cancel_Click">
                                    </dx:ASPxButton>
         </center>            
    </div>
    
    
                    </dx:SplitterContentControl>
</ContentCollection>
            </dx:SplitterPane>
        </Panes>
    </dx:ASPxSplitter>
    <br />
    <br />

    <br />
    <br />
    <center>
        <dx:ASPxButton ID="btn_Matching" runat="server" Text="Matching ข้อมูล" Theme="MaterialCompact" OnClick="btn_Matching_Click">
    </dx:ASPxButton>
    </center>
    <br />
    <br />
    <br />
      
</asp:Content>
