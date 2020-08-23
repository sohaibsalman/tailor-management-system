<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormSearchCustomer.aspx.cs" Inherits="Web.UI.FormSearchCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Search Customer</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <section class="section-update_customer">
        <div class="content">
            <div class="_shadow gradient gradient--1">
                <h3>Search Customer</h3>
            </div>

            <div class="_form">
                <div class="customer_data">
                    <div class="_shadow search_bar">
                        <div class="container">
                            <div class="row">
                                <div class="col-12">
                                    <label>Search Customer:</label>
                                    <asp:TextBox ID="txtSearch" runat="server" placeholder="Search Customer Here" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="_shadow">
                        <div class="row">
                            <div class="col-12">
                                <h5>Customers List</h5>
                                <hr />
                                <div class="gridView">
                                    <asp:GridView ID="gridCustomer" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
        </div>
    </section>
</asp:Content>
