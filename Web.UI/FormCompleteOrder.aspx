<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormCompleteOrder.aspx.cs" Inherits="Web.UI.FormCompleteOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Complete Order</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <section class="content">
        <div class="_shadow">
            <h3>Finish Order</h3>
        </div>

        <div class="section-complete_order">
            <div class="_shadow">
                <div class="_form">
                    <label>Search Order</label>
                    <asp:TextBox ID="txtSearchOrder" runat="server" placeholder="Search Order Here..."></asp:TextBox>
                    <div class="gridView">

                        <asp:GridView ID="gridOrdersInfo" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridOrdersInfo_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" />
                                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                                <asp:BoundField DataField="OrderID" HeaderText="Order ID" />
                                <asp:BoundField DataField="OrderName" HeaderText="Order Name" />
                            </Columns>
                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
