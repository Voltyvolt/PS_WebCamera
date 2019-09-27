<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="frmReportlist.aspx.cs" Inherits="PSAdmin.frmReportlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align: center">
                <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="รายงานต่างๆ" Width="100%" Theme="iOS" View="GroupBox">
                    <HeaderStyle Font-Bold="True" Font-Size="Large" Font-Underline="True" />
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <dx:ASPxTreeView ID="ASPxTreeView1" runat="server" EnableTheming="True" Theme="Moderno" Width="100%">
                                <Nodes>
                                    <dx:TreeViewNode Text="แผนก จัดหาวัตถุดิบ" Expanded="True">
                                        <Image IconID="actions_open_16x16">
                                        </Image>
                                        <Nodes>
                                            <dx:TreeViewNode Text="MAT01 : แบบฟอร์ม - ใบนำตัด" NavigateUrl="~/MATERIAL/PS_MAT01.aspx">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="MAT02 : แบบฟอร์ม - ทะเบียนรถบรรทุก" NavigateUrl="~/MATERIAL/PS_MAT02.aspx">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="MAT03 : แบบฟอร์ม - หนังสือรับรองปริมาณอ้อย" NavigateUrl="~/MATERIAL/PS_MAT03.aspx">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                        </Nodes>
                                    </dx:TreeViewNode>
                                    <dx:TreeViewNode Text="แผนก บัญชีอ้อย" Expanded="True">
                                        <Image IconID="actions_open_16x16">
                                        </Image>
                                        <Nodes>
                                            <dx:TreeViewNode Text="CA01 : แบบฟอร์ม - ใบเสร็จ รับเงิน/หักเงิน">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CA02 : แบบฟอร์ม - ">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CA03 : แบบฟอร์ม - ">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CA04 : แบบฟอร์ม - ค่าบริการรถตัด">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CA05 : แบบฟอร์ม - รับเงินช่วยเหลือและแก้ไขปัญหาความเดือดร้อนของชาวไร่อ้อย">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                        </Nodes>
                                    </dx:TreeViewNode>
                                    <dx:TreeViewNode Expanded="True" Text="แผนก คอมพิวเตอร์">
                                        <Image IconID="actions_open_16x16">
                                        </Image>
                                        <Nodes>
                                            <dx:TreeViewNode Text="CM01 : พิมพ์บัตรโควต้า" NavigateUrl="~/PS_QuotaCard/CM01_QuotaCard.aspx">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM02 : เช็คข้อมูลโควต้า" Target="~/PS_QuotaCard/CM02_QuotaCheck.aspx">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM03 : รายงาน - สรุปการส่งอ้อย แยกตามเขต">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM04 : รายงาน - สรุปการส่งอ้อย แยกตามส่วน">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM05 : รายงาน - สรุปการส่งอ้อย แยกตามประเภทอ้อย (เขต)">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM06 : รายงาน - สรุปการส่งอ้อย แยกตามประเภทอ้อย (ส่วน)">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM07 : รายงาน - สรุปการส่งอ้อย แยกตามประเภทอ้อย (รวม)">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM08 : รายงาน - ตันส่งอ้อยโควต้าพิเศษ">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM09 : รายงาน - การส่งอ้อยประจำวัน">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM10 : รายงาน - การส่งอ้อยตามช่วงวันที่">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode Text="CM11 : รายงาน - CCS สูงสุด - ต่ำสุด">
                                                <Image IconID="actions_right_16x16">
                                                </Image>
                                            </dx:TreeViewNode>
                                            <dx:TreeViewNode>
                                            </dx:TreeViewNode>
                                        </Nodes>
                                    </dx:TreeViewNode>
                                </Nodes>
                            </dx:ASPxTreeView>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxRoundPanel>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
