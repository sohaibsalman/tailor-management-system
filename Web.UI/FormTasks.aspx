<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormTasks.aspx.cs" Inherits="Web.UI.FormAssigWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Tasks</title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="content">
        <div class="section-tasks">
            <div class="_shadow">
                <h4>Assign Work to Worker</h4>
                <hr />
                <asp:LinkButton ID="linkAssignWork" runat="server" CssClass="alert alert-primary" OnClick="linkAssignWork_Click">Assign to Worker</asp:LinkButton>

            </div>

            <div class="_shadow">
                <h4>Complete Order</h4>
                <hr />
                <asp:LinkButton ID="linkCompleteWork" runat="server" CssClass="alert alert-success" OnClick="linkCompleteWork_Click">Complete the Order</asp:LinkButton>

            </div>

            <div class="_shadow">
                <h4>Tasks Assigned</h4>
                <hr />
                <asp:LinkButton ID="linkAssignedTasks" runat="server" CssClass="alert alert-secondary" OnClick="linkAssignedTasks_Click">See Task Assigned</asp:LinkButton>

            </div>
        </div>

    </div>

</asp:Content>
