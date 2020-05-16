<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormAddUser.aspx.cs" Inherits="Web.UI.FormAddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="content">
        <section class="section-new-user">
            <div class="_shadow">
                <h3>Add New User</h3>
            </div>
            <div class="_shadow">
                <div class="user-info">
                    <div class="heading">
                        <h4>User Information</h4>
                        <hr />
                    </div>
                    <div class="_form">
                        <div class="personal-form">
                            <div class="container">
                                <div class="row">
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">Full Name: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtName" runat="server" placeholder="User Name"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">Username: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtUsername" runat="server" placeholder="User Username"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">Password: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="User Password"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">Confirm Password: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtPasswordCnfrm"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtPasswordCnfrm" runat="server" TextMode="Password" placeholder="Confirm Password"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <label>Is Admin</label>
                                        <asp:CheckBox ID="checkAdmin" runat="server" CssClass="checkbox" />
                                    </div>
                                    <div class="col-6">
                                        <label>Is Active</label>
                                        <asp:CheckBox ID="checkActive" runat="server" CssClass="checkbox" Checked="true" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </section>

        <asp:Button ID="btnAdd" runat="server" Text="+" CssClass="_btn-fixed--add" OnClick="btnAdd_Click" />

    </div>

</asp:Content>
