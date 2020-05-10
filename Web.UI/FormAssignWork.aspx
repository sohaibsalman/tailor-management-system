<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormAssignWork.aspx.cs" Inherits="Web.UI.FormAssignWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Assign Work</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <section class="content">
        <div class="_shadow">
            <h3>Assign Work</h3>
        </div>

        <div class="section-assign-work">
            <div class="_shadow">
                <div class="_form">
                    <div class="container">
                        <div class="row">
                            <div class="_form"></div>
                            <div class="col-md-6">
                                <label>Select Customer</label>
                                <asp:DropDownList ID="ddlCustomers" runat="server" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                            </div>
                            <div class="col-md-6">
                                <label>Select Worker</label>
                                <asp:DropDownList ID="ddlWorkers" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="_form"></div>
                            <div class="col-md-6">
                                <label>Select Order Name</label>
                                <asp:DropDownList ID="ddlOrderName" runat="server"></asp:DropDownList>
                            </div>
                            <div class="col-md-6">
                                <label>Order Price</label>
                                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-12">
                                <hr />
                                <h4>Workers Info</h4>
                                <asp:GridView ID="gridWorkersInfo" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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
        <asp:Button ID="btnAssign" runat="server" Text="&#10004;" CssClass="_btn-fixed--add" OnClick="btnAssign_Click"/>
    </section>

</asp:Content>
