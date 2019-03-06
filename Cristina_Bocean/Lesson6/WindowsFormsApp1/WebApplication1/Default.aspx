<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="Panel1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Press Me" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </asp:Panel>    

    <asp:ListBox ID="ListBox1" runat="server">
    <Items>
        <asp:ListItem runat="server" Text="text 1" value =" 1"></asp:ListItem>
         <asp:ListItem runat="server" Text="text 2" value =" 2"></asp:ListItem>
    </Items>
        </asp:ListBox>

    <asp:Button ID="Button3" runat="server" Height="31px" OnClick="Button3_click" Text="Hide Panel Alternate" Width="152px" />


     <asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="Button2" runat="server" Height="31px" OnClick="Button2_click" Text="Button2" Width="102px" />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

</asp:Content>
