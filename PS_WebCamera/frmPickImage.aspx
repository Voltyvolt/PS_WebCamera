<%@ Page Title="" Language="C#" MasterPageFile="~/Root.master" AutoEventWireup="true" CodeBehind="frmPickImage.aspx.cs" Inherits="PS_WebCamera.frmPickImage" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v17.1, Version=17.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <link href="https://fonts.googleapis.com/css2?family=Prompt:wght@500&display=swap" rel="stylesheet" />
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <%--โหลด Script--%>
    <style>
        h4{
            font-family: 'Prompt', sans-serif;
        }
        #Button_search{
            padding-left: 30px;
        }
        .newlist{
            margin: 20px
        }
        .row{
             font-family: 'Prompt', sans-serif;
        }
    </style>

    <br />
    <center><h4>หน้าจอการเลือกรูปอ้อยคุณภาพ</h4></center>

    <div>
        
            <dx:BootstrapFormLayout ID="BootstrapFormLayout1" runat="server">
            <Items>
                <dx:BootstrapLayoutItem Caption="เลขที่คิว" ColSpanMd="3" HorizontalAlign="Center">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:BootstrapComboBox ID="cmb_Qno" runat="server">
                            </dx:BootstrapComboBox>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:BootstrapLayoutItem>
                <dx:BootstrapLayoutItem Caption="วันที่" ColSpanMd="3" HorizontalAlign="Center">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:BootstrapDateEdit ID="cmb_Date" Date="2021-07-16" DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy" runat="server">
                            </dx:BootstrapDateEdit>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:BootstrapLayoutItem>
                <dx:BootstrapLayoutItem Caption="เลขตัวอย่าง" ColSpanMd="3" HorizontalAlign="Center">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:BootstrapComboBox ID="cmb_SampleNo" runat="server">
                            </dx:BootstrapComboBox>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:BootstrapLayoutItem>
                <dx:BootstrapLayoutItem Caption="ราง" ColSpanMd="3" HorizontalAlign="Center">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:BootstrapComboBox ID="cmb_Rail" runat="server">
                            </dx:BootstrapComboBox>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:BootstrapLayoutItem>
                <dx:BootstrapLayoutItem Caption="ดั้ม" ColSpanMd="3" HorizontalAlign="Center">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:BootstrapComboBox ID="cmb_Dump" runat="server">
                            </dx:BootstrapComboBox>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:BootstrapLayoutItem>
                <dx:BootstrapLayoutItem BeginRow="True" Caption="" ColSpanMd="2" HorizontalAlign="Center">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <dx:BootstrapButton ID="Button_search" runat="server" Text="ค้นหา" Width="70px" OnClick="Button_search_Click">
                                <SettingsBootstrap RenderOption="Success" />
                            </dx:BootstrapButton>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:BootstrapLayoutItem>
            </Items>
            </dx:BootstrapFormLayout>

            <dx:BootstrapListBox ID="imagelist" class="newlist" Visible="false" runat="server">
            </dx:BootstrapListBox>
            <br />
            <br />

        <center>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Image runat="server" ID="Image_30" Height="330px" Width="530px" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label Text="รูปที่ 1 30 องศา" runat="server"></asp:Label>
                </div>
            </div>
        </div>

         <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label Text="ชื่อรูปที่ 1" ID="lb_image30" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Image runat="server" ID="Image_45" Height="330px" Width="530px" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label Text="รูปที่ 2 45 องศา" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label Text="ชื่อรูปที่ 2" ID="lb_image45" runat="server"></asp:Label>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Image runat="server" ID="Image_90" Height="330px" Width="530px" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label Text="รูปที่ 3 90 องศา" runat="server"></asp:Label>
                </div>
            </div>
        </div>

            <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <asp:Label Text="ชื่อรูปที่ 3" ID="lb_image90" runat="server"></asp:Label>
                </div>
            </div>
        </div>

      </center>

    </div>

</asp:Content>
