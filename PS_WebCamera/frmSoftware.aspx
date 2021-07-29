<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="frmSoftware.aspx.cs" Inherits="PS_WebCamera.frmSoftware" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="height: 25px"></td>
            <td style="height: 25px"></td>
            <td style="height: 25px"></td>
        </tr>
        <tr>
            <td style="height: 204px"></td>
            <td style="text-align: center; height: 204px;">
                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="โปรแกรมต่างๆ" Width="100%" Theme="iOS" View="GroupBox">
                    <HeaderStyle Font-Bold="True" Font-Size="Large" Font-Underline="True" />
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <dx:ASPxTreeView ID="ASPxTreeView1" runat="server" EnableTheming="True" Theme="Moderno" Width="100%">
                                <Nodes>
                                    <dx:TreeViewNode Text="แผนก คอมพิวเตอร์" Expanded="True">
                                        <Image IconID="actions_open_16x16">
                                        </Image>
                                        <Nodes>
                                            <dx:TreeViewNode Text="COM01 : ข้อมูลโควต้า" NavigateUrl="~/PS_CaneData/frmQuota.aspx">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                        </Nodes>
                                    </dx:TreeViewNode>
                                    <dx:TreeViewNode Expanded="True" Text="แผนกกฏหมาย">
                                        <Image IconID="actions_open_16x16">
                                        </Image>
                                        <Nodes>
                                            <dx:TreeViewNode NavigateUrl="~/LAW/LAW_01.aspx" Text="LAW01 : บันทึกเพิ่มเติมแนบท้ายสัญญาซื้อขายอ้อย">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode NavigateUrl="~/LAW/LAW_02.aspx" Text="LAW02 : หนังสือรับสภาพหนี้">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode NavigateUrl="~/LAW/LAW_03.aspx" Text="LAW03 : สัญญาค้ำประกัน">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode NavigateUrl="~/LAW/LAW_04.aspx" Text="LAW04 : สัญญาซื้อขายอ้อย">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                        </Nodes>
                                    </dx:TreeViewNode>
                                    <dx:TreeViewNode Expanded="True" Text="จัดการข้อมูล (Administrator)">
                                        <Image IconID="setup_properties_16x16">
                                        </Image>
                                        <Nodes>
                                            <dx:TreeViewNode Text="ADMIN01 : กำหนดสิทธิ์">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                        </Nodes>
                                    </dx:TreeViewNode>
                                </Nodes>
                            </dx:ASPxTreeView>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
            </td>
            <td style="height: 204px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
