<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormAddCustomer.aspx.cs" Inherits="Web.UI.FormAddCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Add Customer</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="content">
        <section class="section-new-user">
            <div class="_shadow">
                <h3>Add New Customer</h3>
            </div>
            <div class="_shadow">
                <div class="customer-personal-info">
                    <div class="heading">
                        <h4>Personal Information</h4>
                        <hr />
                    </div>
                    <div class="_form">
                        <div class="personal-form">
                            <div class="container">
                                <div class="row">
                                    <div class="col-6">
                                        <label for="">Full Name: </label>
                                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <label for="">CNIC Number: </label>
                                        <asp:TextBox ID="txtCNIC" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <label for="">Mobile Number: </label>
                                        <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <label for="">Phone Number: </label>
                                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-12">
                                        <label for="">Address: </label>
                                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" CssClass="multiline"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="_shadow">
                <div class="customer-measurement">
                    <div class="heading">
                        <h4>Measurements Info</h4>
                        <hr />
                    </div>
                    <div class="measurements">
                        <div class="measurement--btns">
                            <a id="measurement--btns-add">+</a>
                            <a id="measurement--btns-remove">-</a>
                        </div>
                        <asp:ListBox ID="ListBox1" runat="server" CssClass="listBox"></asp:ListBox>
                    </div>
                </div>
            </div>

        </section>

    </div>

    <div class="_popup" id="popup-add_measurement">
        <div class="_popup-body">
            <div class="_popup-close_btn">
                <i class="fas fa-times " id="popup-close"></i>
            </div>


            <div class="measurement-data">
                <h5>Select Type</h5>
                <asp:DropDownList ID="ddlMeasurementType" runat="server" CssClass="measurement-list" OnSelectedIndexChanged="ddlMeasurementType_SelectedIndexChanged"></asp:DropDownList>
                <hr />
                <asp:GridView ID="gridMeasurements" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" CssClass="table" OnRowEditing="gridMeasurements_RowEditing">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
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

</asp:Content>
