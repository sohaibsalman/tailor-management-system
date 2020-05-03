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
                                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" CssClass ="multiline"></asp:TextBox>
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
                        
                        <asp:ListBox ID="ListBox1" runat="server" CssClass="listBox">
                        </asp:ListBox>
                    </div>
                </div>
            </div>

        </section>
    </div>

</asp:Content>
