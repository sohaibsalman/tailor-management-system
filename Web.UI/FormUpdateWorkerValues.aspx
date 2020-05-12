<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormUpdateWorkerValues.aspx.cs" Inherits="Web.UI.FormUpdateWorkerValues" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Update Worker</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="content">
        <section class="section-new-user">
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
                                    <div class="col-md-6">
                                         <label>Salary: </label>
                                         <asp:TextBox runat="server" ID="txtSalary"/>
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

        </section>

        <asp:Button ID="btnUpdate" runat="server" Text="&#10004;" CssClass="_btn-fixed--add" OnClick="btnUpdate_Click"/>

    </div>
</asp:Content>
