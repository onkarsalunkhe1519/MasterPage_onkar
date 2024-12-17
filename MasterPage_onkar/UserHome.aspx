<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="MasterPage_onkar.UserHome" EnableEventValidation="false"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    User Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="max-width: 1200px; margin: 0 auto; padding: 20px;">
        <!-- Flexbox container for cards -->
        <div style="display: flex; flex-wrap: wrap; justify-content: space-between; gap: 20px;">
            <%--<asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand1">
                <ItemTemplate>
                    <!-- Each card -->
                    <div style="width: 18rem; border: 1px solid #ccc; border-radius: 8px; box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); overflow: hidden; background: white; transition: transform 0.3s ease;">
                        <img class="card-img-top" src='<%# Eval("pic") %>' alt="Card image cap" style="width: 100%; height: auto;">
                        <div style="padding: 15px;">
                            <h5 style="font-size: 1.2em; color: #333;"><%# Eval("pname") %></h5>
                        </div>
                        <ul style="list-style-type: none; padding: 0; margin: 0; background-color: #f8f9fa;">
                            <li style="padding: 10px; border-bottom: 1px solid #ddd;">Product Category: <%# Eval("pcat") %></li>
                            <li style="padding: 10px; border-bottom: 1px solid #ddd;">Product Price: <%# Eval("price") %></li>
                            <li style="padding: 10px; border-bottom: 1px solid #ddd;">Product Qty: 
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem Value="1">1</asp:ListItem>
                                    <asp:ListItem Value="2">2</asp:ListItem>
                                    <asp:ListItem Value="3">3</asp:ListItem>
                                    <asp:ListItem Value="4">4</asp:ListItem>
                                </asp:DropDownList>
                            </li>
                        </ul>
                        <div style="padding: 10px; text-align: center;">
                            <asp:Button ID="Button1" runat="server" Text="Add to Cart" CommandName="AddToCart" CommandArgument='<%# Eval("pid") %>' />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>--%>



        </div>

        <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" ViewStateMode="Disabled">
            <ItemTemplate>
    <!-- Each card -->
    <div style="width: 18rem; border: 1px solid #ccc; border-radius: 8px; box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); overflow: hidden; background: white; transition: transform 0.3s ease;">
        <img class="card-img-top" src='<%# Eval("pic") %>' alt="Card image cap" style="width: 100%; height: auto;">
        <div style="padding: 15px;">
            <h5 style="font-size: 1.2em; color: #333;"><%# Eval("pname") %></h5>
        </div>
        <ul style="list-style-type: none; padding: 0; margin: 0; background-color: #f8f9fa;">
            <li style="padding: 10px; border-bottom: 1px solid #ddd;">Product Category: <%# Eval("pcat") %></li>
            <li style="padding: 10px; border-bottom: 1px solid #ddd;">Product Price: <%# Eval("price") %></li>
            <li style="padding: 10px; border-bottom: 1px solid #ddd;">Product Qty: 
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="1">1</asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                    <asp:ListItem Value="3">3</asp:ListItem>
                    <asp:ListItem Value="4">4</asp:ListItem>
                </asp:DropDownList>
            </li>
        </ul>
        <div style="padding: 10px; text-align: center;">
            <asp:Button ID="Button1" runat="server" Text="Add to Cart" CommandName="AddToCart" CommandArgument='<%# Eval("pid") %>' />
        </div>
    </div>
</ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
