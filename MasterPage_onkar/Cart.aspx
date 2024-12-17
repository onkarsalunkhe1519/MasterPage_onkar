<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Cart.aspx.cs" Inherits="MasterPage_onkar.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="pid" ViewStateMode="Disabled" >
        <Columns>
            <asp:TemplateField HeaderText="PID">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("pid") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Image ID="Image1" Height="100px" Width="100px" ImageUrl='<%#Eval("pic") %>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PNAME">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("pname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PCAT">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("pcat") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Price">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("price") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Qty">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("qty") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="total">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("total") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("dt") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Remove">
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" Text="Remove"  CommandName="Delete"/>
         </ItemTemplate>
            </asp:TemplateField>

            

        </Columns>
    </asp:GridView>

</asp:Content>
