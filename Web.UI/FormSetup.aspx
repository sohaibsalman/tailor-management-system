<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormSetup.aspx.cs" Inherits="Web.UI.FormSetup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Setup</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="content">
        <section class="section-setup">
            <div class="_shadow">
                <div class="add-new-data">
                    <div class="heading">
                        <h4>Add New Data</h4>
                        <hr />
                    </div>
                    <div class="links">
                        <ul>
                            <li>
                                <asp:LinkButton ID="linkNewCustomer" runat="server" OnClick="linkNewCustomer_Click">Add Customer Data</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="linkNewWorker" runat="server">Add Worker Data</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="linkNewUser" runat="server">Add User Data</asp:LinkButton>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="_shadow">
                <div class="add-new-data">
                    <div class="heading">
                        <h4>Update Existing Data</h4>
                        <hr />
                    </div>
                    <div class="links">
                        <ul>
                            <li>
                                <asp:LinkButton ID="linkUpdateCustomer" runat="server">Update Customer Data</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="linkUpdateWorker" runat="server">Update Worker Data</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="linkUpdateUser" runat="server">Update User Data</asp:LinkButton>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="_shadow">
                <div class="add-new-data">
                    <div class="heading">
                        <h4>Delete Data</h4>
                        <hr />
                    </div>
                    <div class="links">
                        <ul>
                            <li>
                                <asp:LinkButton ID="linkDeleteCustomer" runat="server">Delete Customer Data</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="linkDeleteWorker" runat="server">Delete Worker Data</asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="linkDeleteUser" runat="server">Delete User Data</asp:LinkButton>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>

    </div>

</asp:Content>
