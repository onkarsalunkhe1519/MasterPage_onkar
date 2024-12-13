<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="MasterPage_onkar.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Add Product
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    Product name&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    Category&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList class="form-control" ID="DropDownList1" runat="server" >
        <asp:ListItem>Laptop</asp:ListItem>
        <asp:ListItem>Mobile</asp:ListItem>
        <asp:ListItem>Food</asp:ListItem>
    </asp:DropDownList>
    <br />
    Img&nbsp;&nbsp;&nbsp; <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
    <br />
    price
    <asp:TextBox class="form-control" ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button  ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
    <br />
    <br />
</div>
</asp:Content>
