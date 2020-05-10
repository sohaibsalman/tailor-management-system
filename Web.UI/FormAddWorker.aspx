<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormAddWorker.aspx.cs" Inherits="Web.UI.FormAddWorker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="content">
        <section class="section-new-user">
            <div class="_shadow">
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
                                        <label for="">Joining Date: </label>
                                        <asp:TextBox ID="dateJoining" runat="server" TextMode="DateTime"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                   
                                    <div class="col-6">
                                        <label for="">Address: </label>
                                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" CssClass="multiline"></asp:TextBox>
                                    </div>

                                     <div class="col-md-6">
                                         <label>Salary: </label>
                                         <asp:TextBox runat="server" ID="txtSalary"/>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </section>

        <asp:Button ID="btnAdd" runat="server" Text="+" CssClass="_btn-fixed--add" OnClick="btnAdd_Click" />

            <div class="_popup" id="popup-add_measurement">
        <div class="_popup-body">
            <div class="_popup-close_btn">
                <i class="fas fa-times " id="popup-close"></i>
            </div>


            <div class="form-data">
                <h5>Are you sure you want to add following data?</h5>


                
            </div>

        </div>
    </div>

    </div>


</asp:Content>
