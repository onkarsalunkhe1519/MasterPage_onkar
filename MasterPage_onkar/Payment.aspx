<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="MasterPage_onkar.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="https://checkout.razorpay.com/v1/checkout.js"></script>

  
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />

  
</asp:Content>
