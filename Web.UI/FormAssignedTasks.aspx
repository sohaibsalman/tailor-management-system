<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormAssignedTasks.aspx.cs" Inherits="Web.UI.FormAssignedTasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Assigned Tasks</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="section-assigned_tasks">
        <section class="content">
            <div class="_shadow">
                <h3>Tasks Assigned to Workers</h3>
            </div>

            <div class="_form">
                <div class="_shadow search">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12">
                                <label>Search Order: </label>
                                <asp:TextBox ID="txtSearch" runat="server" AutoPostBack="true" placeholder="Search Order Here..." OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="_shadow">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12">
                                <h5>Assigned Orders List</h5>
                                <hr />
                                <div class="gridView" id="divOrdersAssigned" runat="server">
                                    <asp:GridView ID="gridOrdersAssigned" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
    </div>

</asp:Content>
