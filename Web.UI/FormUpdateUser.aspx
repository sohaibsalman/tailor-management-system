<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormUpdateUser.aspx.cs" Inherits="Web.UI.FormUpdateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Update User</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <section class="content">
        <div class="_shadow gradient gradient--3">
            <h3>Update User</h3>
        </div>

        <div class="_form">
            <div class="update_user-search">
                <div class="_shadow search_bar">
                    <div class="container">
                        <div class="row">
                            <div class="col-12">
                                <label>Search for User:</label>
                            </div>
                            <div class="col-12">
                                <asp:TextBox ID="txtSearch" runat="server" placeholder="Search user here..." OnTextChanged="txtSearch_TextChanged" AutoPostBack="true"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="_shadow">
                    <div class="container">
                        <div class="row">
                            <div class="col-12">
                                <h5>Users List</h5>
                                <hr />
                                <div class="gridView">
                                    <asp:GridView ID="gridUsers" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnPageIndexChanging="gridUsers_PageIndexChanging" PageSize="5" OnSelectedIndexChanged="gridUsers_SelectedIndexChanged">
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
