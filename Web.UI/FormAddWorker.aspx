<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormAddWorker.aspx.cs" Inherits="Web.UI.FormAddWorker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Add Worker</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="content">
        <section class="section-new-user">
            <div class="_shadow gradient gradient--4">
                <h3>Add New Worker</h3>
            </div>
            <div class="_shadow">
                <div class="worker-info">
                    <div class="heading">
                        <h4>Worker Information</h4>
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
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtName" runat="server"  placeholder="Woker Name"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">CNIC Number: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtCNIC"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtCNIC" runat="server" placeholder="Woker CNIC"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">Mobile Number </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtNumber"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtNumber" runat="server" placeholder="Woker Mobile Number"></asp:TextBox>
                                    </div>
                                    <div class="col-md-6">
                                         <div class="row">
                                            <div class="col-6">
                                                <label for="">Salary </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtSalary"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                         <asp:TextBox runat="server" ID="txtSalary"  placeholder="Woker Salary"/>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-12">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">Address: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Field is Required" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" CssClass="multiline"  placeholder="Address"></asp:TextBox>
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
