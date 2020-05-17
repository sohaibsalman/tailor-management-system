<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.UI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <section class="content">
        <div class="section-homepage">
            <div class="container">
                <div class="row">
                    <div class="col-md-4">
                        <div class="_shadow orders-data orders-data--1">
                            <asp:Label ID="lblCountNewOrders" runat="server" Text="" CssClass="count_label"></asp:Label>
                            <h5>New Orders</h5>
                        </div>
                    </div>

                    <div class="col-md-4">
                        <div class="_shadow orders-data orders-data--2">
                            <asp:Label ID="lblCountCompletedOrders" runat="server" Text="" CssClass="count_label"></></asp:Label>
                            <h5>Completed Orders</h5>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="_shadow orders-data orders-data--3">
                            <asp:Label ID="lblCountPendingOrders" runat="server" Text="" CssClass="count_label"></></asp:Label>
                            <h5>In progress Orders</h5>
                        </div>
                    </div>

                </div>

                <div class="row">
                    <div class="col-3">
                        <div class="_shadow sales-stats sales-stats--1">
                            <h1>Rs. 25,000
                            </h1>
                            <hr>
                            <h6>Sales this month</h6>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="_shadow sales-stats sales-stats--2">
                            <h1>Rs. 67,000
                            </h1>
                            <hr>
                            <h6>Sales last month</h6>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="_shadow sales-stats sales-stats--3">
                            <h1>Rs. 75,000
                            </h1>
                            <hr>
                            <h6>Sales Income</h6>
                        </div>
                    </div>
                    <div class="col-3">
                        <div class="_shadow sales-stats sales-stats--4">
                            <h1>Rs. 15,000
                            </h1>
                            <hr />
                            <h6>Total Revenue</h6>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <div class="_shadow .worker-table">
                            <h3>Workers List</h3>
                            <hr />
                            <div class="worker_table gridView">
                                <asp:GridView ID="gridWorkersList" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AllowPaging="True" OnPageIndexChanging="gridWorkersList_PageIndexChanging" PageSize="5">
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

        </div>

    </section>

</asp:Content>
