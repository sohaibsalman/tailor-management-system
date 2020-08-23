<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormSettings.aspx.cs" Inherits="Web.UI.FormSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Settings</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <section class="content">
        <div class="section-settings">
            <div class="_shadow">
                <div class="container">
                    <div class="row">
                        <div class="col-2">
                            <img src="/img/admin.png" alt="" />
                        </div>
                        <div class="col-5">
                            <h4><%=((TMS.Common.User)Session["user"]).Name %></h4>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
