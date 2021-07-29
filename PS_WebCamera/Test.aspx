<%@ Page Title="" Language="C#" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="PS_WebCamera.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">

     <script type="text/javascript">
        function grid_SelectionChanged(s,e) {
            s.GetSelectedFieldValues("ContactName",GetSelectedFieldValuesCallback);
        }
        function GetSelectedFieldValuesCallback(values) {
            selList.BeginUpdate();
            try {
                selList.ClearItems();
                for(var i=0;i<values.length;i++) {
                    selList.AddItem(values[i]);
                }
            } finally {
                selList.EndUpdate();
            }
            document.getElementById("selCount").innerHTML=grid.GetSelectedRowCount();
        }
    </script>

     <div style="float: left; width: 20%">
        <div class="BottomPadding">
            Selected values:
        </div>
        <dx:ASPxListBox ID="ASPxListBox1" ClientInstanceName="selList" runat="server" Height="250px" Width="100%" />
        <div class="TopPadding">
            Selected count: <span id="selCount" style="font-weight: bold">0</span>
        </div>
    </div>
    <div style="float: right; width: 78%">
        <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="CustomersDataSource" KeyFieldName="CustomerID" Width="100%">
            <Columns>
                <dx:GridViewCommandColumn ShowSelectCheckbox="true" />
                <dx:GridViewDataTextColumn FieldName="I_Dump" ShowInCustomizationForm="True" Caption="ดั้มที่" VisibleIndex="4"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="I_Date" ShowInCustomizationForm="True" Caption="วันที่" VisibleIndex="5"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="I_Time" ShowInCustomizationForm="True" Caption="เวลา" VisibleIndex="6"></dx:GridViewDataTextColumn>
            </Columns>
            <ClientSideEvents SelectionChanged="grid_SelectionChanged" />
        </dx:ASPxGridView>
    </div>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource" ContextTypeName="DevExpress.Web.Demos.NorthwindContext" EntitySetName="Customers" />

</asp:Content>
