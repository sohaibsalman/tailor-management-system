<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormReports.aspx.cs" Inherits="Web.UI.FormReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Reports</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <section class="content">
        <div class="section-reports">
            <div class="container">
                <div class="total_summary">
                    <div class="row">
                        <div class="col-4">
                            <div class="_shadow sales-stats sales-stats--3">
                                <i class="fas fa-user-shield"></i>
                                <asp:Label ID="lblTotalUsers" runat="server" Text=""></asp:Label>
                                <h5>Total users</h5>
                            </div>
                        </div>
                        <div class="col-4">
                            <div class="_shadow sales-stats sales-stats--3">
                                <i class="fas fa-users"></i>
                                <asp:Label ID="lblTotalWorkers" runat="server" Text=""></asp:Label>
                                <h5>Total workers</h5>
                            </div>
                        </div>
                        <div class="col-4">
                            <div class="_shadow sales-stats sales-stats--3">
                                <i class="fas fa-user-tie"></i>
                                <asp:Label ID="lblTotalCustomers" runat="server" Text=""></asp:Label>
                                <h5>Total customers</h5>
                            </div>
                        </div>
                    </div>
                </div>


                <div class="new_oders_list">
                    <div class="_shadow">
                        <div class="row">
                            <div class="col-12">
                                <h4>Orders not Assigned</h4>
                                <hr />
                            </div>
                            <div class="col-12">
                                <div class="gridView" id="divPendingOrders" runat="server">
                                    <asp:GridView ID="gridPendingOrders" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
                </div>

                <div class="orders_inprogress_list">
                    <div class="_shadow">
                        <div class="row">
                            <div class="col-md-12">
                                <h4>Orders in Progress</h4>
                                <hr />
                            </div>
                            <div class="col-12">
                                <div class="gridView">
                                    <asp:GridView ID="gridInProgress" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
                </div>

                <div class="earnings_summary">
                    <div class="row">
                        <div class="col-md-4">
                            <div class="_shadow sales-stats sales-stats--1">
                                <asp:Label ID="lblEarningsCompleted" runat="server" Text="RS. "></asp:Label>
                                <hr />
                                <h6>Earnings from completed orders</h6>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="_shadow sales-stats sales-stats--1">
                                <asp:Label ID="lblEarningsPending" runat="server" Text="RS. "></asp:Label>
                                <hr />
                                <h6>Earnings from pending orders</h6>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="_shadow sales-stats sales-stats--1">
                                <asp:Label ID="lblEarningsTotal" runat="server" Text="RS. "></asp:Label>
                                <hr />
                                <h6>Total Earnings expected this month</h6>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>
