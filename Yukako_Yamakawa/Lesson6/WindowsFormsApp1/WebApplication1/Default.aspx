<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="panel1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Press Me!" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

    <asp:ListBox ID="ListBox1" runat="server">
        <Items>
            <asp:ListItem runat="server" Text="text1" Value="1"></asp:ListItem>
            <asp:ListItem runat="server" Text="text2" Value="2"></asp:ListItem>
        </Items>
    </asp:ListBox>

    <asp:Button ID="Button3" runat="server" Text="Hide Panel Alternate" OnClick="Button3_Click" />
    
    <asp:Panel ID="panel2" runat="server">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button 2" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

</asp:Content>
