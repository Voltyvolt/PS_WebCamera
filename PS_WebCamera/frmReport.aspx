<%@ Page Title="" Language="C#" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeBehind="frmReport.aspx.cs" Inherits="PS_WebCamera.frmReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">

    <script type="text/javascript">
        function GridV1_SelectionChanged(s, e) {
            s.GetSelectedFieldValues("I_QNo", GetSelectedFieldValuesCallback);
        }
        function GetSelectedFieldValuesCallback(values) {
            selList.BeginUpdate();
            try {
                selList.ClearItems();
                for (var i = 0; i < values.length; i++) {
                    selList.AddItem(values[i]);
                }
            } finally {
                selList.EndUpdate();
            }
            document.getElementById("selCount").innerHTML = GridV1.GetSelectedRowCount();
        }
    </script>

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <p>
        <br />
        <center>
            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Font-Size="X-Large" Text="พิมพ์รายงาน">
        </dx:ASPxLabel>
            <br />
            <br />
             
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Theme="DevEx">
        <Items>
            <dx:LayoutGroup Caption="กรองข้อมูล" ColCount="15">
                <Items>
                    <dx:LayoutItem Caption="เลขที่คิว" ColSpan="3">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer runat="server">
                                <dx:ASPxTextBox ID="txt_QNo" runat="server" BackColor="#FFFF99">
                                </dx:ASPxTextBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
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
                                 <dx:ASPxDateEdit ID="cmb_SearchDate" runat="server" BackColor="#FFFF99" Date="2020-04-11" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" Width="100%">
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
            <br />
<dx:ASPxGridView runat="server" AutoGenerateColumns="False" ClientInstanceName="GridV1" Theme="MaterialCompact" Width="742px" EnableTheming="True" ID="GridV1" KeyFieldName="I_QNo" OnPageIndexChanged="GridV1_PageIndexChanged"><Columns>
      <dx:GridViewCommandColumn ShowSelectCheckbox="true" />
<dx:GridViewDataTextColumn FieldName="I_Dump" ShowInCustomizationForm="True" Caption="ดั้มที่" VisibleIndex="4"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="I_Date" ShowInCustomizationForm="True" Caption="วันที่" VisibleIndex="5"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="I_Time" ShowInCustomizationForm="True" Caption="เวลา" VisibleIndex="6"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="I_Rail" ShowInCustomizationForm="True" Caption="ราง" VisibleIndex="3"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="I_Name_30" ShowInCustomizationForm="True" Caption="รูปที่ 1" Visible="False" VisibleIndex="8"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="I_Name_45" ShowInCustomizationForm="True" Caption="รูปที่ 2" Visible="False" VisibleIndex="9"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="I_Name_60" ShowInCustomizationForm="True" Caption="รูปที่ 3" Visible="False" VisibleIndex="10"></dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="โควต้า" FieldName="Q_Quota" VisibleIndex="1">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="ทะเบียนรถ" FieldName="Q_CarNum" VisibleIndex="2">
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn Caption="คิวที่" FieldName="I_QNo" VisibleIndex="0">
                                    </dx:GridViewDataTextColumn>
</Columns>
<ClientSideEvents SelectionChanged="GridV1_SelectionChanged" />
<Border BorderColor="#0066FF" BorderStyle="Solid" BorderWidth="2px"></Border>
</dx:ASPxGridView>


            <br />
            <dx:ASPxFormLayout ID="ASPxFormLayout2" runat="server">
                <Items>
                    <dx:LayoutGroup Caption="" ColCount="6">
                        <Items>
                            <dx:LayoutItem Caption="อ้อยคุณภาพ" ColSpan="3">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxCheckBox ID="chk_Typegood" runat="server" CheckState="Unchecked">
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="อ้อยสกปรก" ColSpan="3">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxCheckBox ID="chk_Typebad" runat="server" CheckState="Unchecked">
                                        </dx:ASPxCheckBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="สถานะ" ColSpan="3">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxComboBox ID="cmb_Status" runat="server">
                                            <Items>
                                                <dx:ListEditItem Text="ผ่าน" Value="0" />
                                                <dx:ListEditItem Text="ไม่ผ่าน" Value="1" />
                                            </Items>
                                        </dx:ASPxComboBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                            <dx:LayoutItem Caption="เพราะ" ColSpan="3">
                                <LayoutItemNestedControlCollection>
                                    <dx:LayoutItemNestedControlContainer runat="server">
                                        <dx:ASPxTextBox ID="txt_Remark" runat="server">
                                        </dx:ASPxTextBox>
                                    </dx:LayoutItemNestedControlContainer>
                                </LayoutItemNestedControlCollection>
                            </dx:LayoutItem>
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>


            <br />
            <br />

    <center>
        <dx:ASPxButton ID="btn_Print" runat="server" Text="พิมพ์รายงาน" Theme="MetropolisBlue" OnClick="btn_Print_Click">
        </dx:ASPxButton>
                <br />
                <br />
                <dx:ASPxListBox ID="QList" ClientInstanceName="selList" runat="server" ValueType="System.String" Width="300px" />
                <div class="TopPadding">
                    Selected count: <span id="selCount" style="font-weight: bold">0</span>
                 </div>
    </center>


        </center>


    </p>

</asp:Content>
