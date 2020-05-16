<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Layout.Master" AutoEventWireup="true" CodeBehind="FormAddCustomer.aspx.cs" Inherits="Web.UI.FormAddCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>TMS - Add Customer</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div class="content">
        <section class="section-new-user">
            <div class="_shadow">
                <h3>Add New Customer</h3>
            </div>
            <div class="_shadow">
                <div class="customer-personal-info">
                    <div class="heading">
                        <h4>Personal Information</h4>
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
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Fill this field" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtName" runat="server" placeholder="Customer Name"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">CNIC Number: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Fill this field" ControlToValidate="txtCNIC"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtCNIC" runat="server" placeholder="Customer CNIC"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">Mobile Number: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Fill this field" ControlToValidate="txtNumber"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtNumber" runat="server" placeholder="Customer Mobile Number"></asp:TextBox>
                                    </div>
                                    <div class="col-6">
                                        <div class="row">
                                            <div class="col-6">
                                                <label for="">Address: </label>
                                            </div>
                                            <div class="col-6 validate">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Fill this field" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <asp:TextBox ID="txtAddress" runat="server" placeholder="Customer Address"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-12">
                                        <label>Remarks</label>
                                        <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine" CssClass="multiline" placeholder="Add Remarks"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="_shadow">
                <div class="customer-measurement">
                    <div class="heading">
                        <h4>Measurements Info</h4>
                        <hr />
                    </div>
                    <div class="measurements">
                        <div class="measurement--btns">
                            <a id="measurement--btns-add">+</a>
                            <a id="measurement--btns-remove">-</a>
                        </div>
                        <asp:ListBox ID="listMeasurements" runat="server" CssClass="listBox"></asp:ListBox>
                    </div>
                </div>
            </div>

        </section>
        <asp:Button ID="btnAdd" runat="server" Text="+" CssClass="_btn-fixed--add" OnClick="btnAdd_Click" />

    </div>

    <div class="_popup" id="popup-add_measurement">
        <div class="_popup-body">
            <div class="_popup-close_btn">
                <i class="fas fa-times " id="popup-close"></i>
            </div>


            <div class="measurement-data">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <h5>Select Type</h5>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <asp:DropDownList ID="ddlMeasurementType" runat="server" AutoPostBack="true" CssClass="measurement-list" OnSelectedIndexChanged="ddlMeasurementType_SelectedIndexChanged"></asp:DropDownList>
                            <hr />
                            <asp:GridView ID="gridMeasurements" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" CssClass="table" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:TemplateField HeaderText="Measurements Name">
                                        <EditItemTemplate>
                                            <asp:Label ID="lblMeasurementName" runat="server" Text='<%# Eval("[Measurements Name]") %>'></asp:Label>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="txtMeasurementName" runat="server" Text='<%# Bind("[Measurements Name]") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Measurements Value">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtMeasurementValue" runat="server" Text='<%# Bind("[Measurements Value]") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:TextBox ID="txtMeasurementValue" runat="server" Text='<%# Bind("[Measurements Value]") %>'></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>

                                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                <SortedDescendingHeaderStyle BackColor="#242121" />

                            </asp:GridView>
                        </div>
                    </div>
                </div>


                <asp:Button ID="btnAddMeasurement" runat="server" Text="Add" CssClass="_btn-measurement_add" OnClick="btnAddMeasurement_Click" />

            </div>

        </div>
    </div>

</asp:Content>
