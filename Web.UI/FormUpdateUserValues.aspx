﻿<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormUpdateUserValues.aspx.cs" Inherits="Web.UI.FormUpdateUserValues" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Update Users</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <section class="content">
        <div class="section-new-user">
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
                                        <label for="">Full Name: </label>
                                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <label for="">Username: </label>
                                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <label for="">Password: </label>
                                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <label for="">Confirm Password: </label>
                                        <asp:TextBox ID="txtPasswordCnfrm" runat="server" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <label>Is Admin</label>
                                        <asp:CheckBox ID="checkAdmin" runat="server" CssClass="checkbox" />
                                    </div>
                                    <div class="col-6">
                                        <label>Is Active</label>
                                        <asp:CheckBox ID="checkActive" runat="server" CssClass="checkbox" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <asp:Button ID="btnUpdate" runat="server" Text="&#10004;" CssClass="_btn-fixed--add" OnClick="btnUpdate_Click"/>
    </section>
</asp:Content>
