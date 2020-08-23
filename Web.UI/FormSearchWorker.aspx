<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormSearchWorker.aspx.cs" Inherits="Web.UI.FormSearchWorker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Search Worker</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="content">
        <div class="update_woker">
            <div class="_shadow gradient gradient--4">
                <h3>Search Worker</h3>
            </div>
            <div class="_form">
                <div class="update_worker-search">
                    <div class="_shadow search_bar">
                        <div class="container">
                            <div class="row">
                                <div class="col-12">
                                    <label>Search Worker:</label>
                                </div>
                                <div class="col-12">
                                    <asp:TextBox ID="txtSearch" runat="server" placeholder="Search worker here..." OnTextChanged="txtSearch_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="_shadow">
                        <div class="container">
                            <div class="row">
                                <div class="col-12">
                                    <h5>Workers List</h5>
                                    <hr />
                                    <div class="gridView">
                                        <asp:GridView ID="gridCustomers" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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

        </div>
    </div>
</asp:Content>
