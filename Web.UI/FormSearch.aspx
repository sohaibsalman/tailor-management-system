<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormSearch.aspx.cs" Inherits="Web.UI.FormSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Search</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <section class="content">
        <div class="section-search">

            <div class="_shadow">
                <div class="search_link">
                    <h4>Search Customer</h4>
                    <hr />

                    <div class="alert alert-success">
                        <a href="FormSearchCustomer.aspx">Search Customer</a>
                    </div>

                </div>
            </div>
            <div class="_shadow">
                <div class="search_link">
                    <h4>Search Worker</h4>
                    <hr />

                    <div class="alert alert-primary">
                        <a href="FormSearchWorker.aspx">Search Worker</a>
                    </div>

                </div>
            </div>
            <div class="_shadow">
                <div class="search_link">
                    <h4>Search User</h4>
                    <hr />

                    <div class="alert alert-secondary">
                        <a href="FormSearchUser.aspx">Search User</a>
                    </div>

                </div>
            </div>
        </div>
    </section>
</asp:Content>
