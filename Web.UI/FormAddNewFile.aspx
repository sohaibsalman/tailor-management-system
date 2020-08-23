<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormAddNewFile.aspx.cs" Inherits="Web.UI.FormAddNewFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Add File</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <section class="content">
        <div class="_form">
            <div class="_shadow gradient gradient--1">
                <h3>Add new file</h3>
            </div>

            <div class="_shadow search_bar">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <label>File Name:</label>
                        </div>
                        <div class="col-12">
                            <asp:TextBox ID="txtFileName" runat="server" placeholder="Enter File Name..."></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>

            <div class="_shadow">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <label>Measurement Name:</label>
                        </div>
                        <div class="col-11">
                            <asp:TextBox ID="txtMeasurementName" runat="server" placeholder="Enter Measurement Name..."></asp:TextBox>
                        </div>
                        <div class="col-1">
                            <asp:Button ID="btnAddName" runat="server" Text="+" OnClick="btnAddName_Click" />
                        </div>
                    </div>
                    <div class="row u-margin-top-medium">
                        <div class="col-12">
                            <h5>Measurements List</h5>
                            <hr />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <asp:ListBox ID="listMeasurmentName" runat="server"></asp:ListBox>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <asp:Button ID="btnAddFile" runat="server" Text="+" CssClass="_btn-fixed--add" OnClick="btnAddFile_Click"/>

    </section>

</asp:Content>
