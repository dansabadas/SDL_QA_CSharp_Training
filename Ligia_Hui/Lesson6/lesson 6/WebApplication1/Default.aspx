﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="panel1" runat="server">
       <asp:Button ID="Button1" runat="server" Text="Press Me!" OnClick="Button1_Click" />
       <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

    <asp:ListBox ID="ListBox1" runat="server">
    <Items>
        <asp:ListItem runat="server" Text="text 1" value="text"></asp:ListItem>
        <asp:ListItem runat="server" Text="text 2" value="text"></asp:ListItem>
    </Items>
        </asp:ListBox>
    <asp:Button ID="Button3" runat="server" Text="visible/invisible" OnClick="Button3_Click" />

    <asp:Panel ID="panel2" runat="server">
       <asp:Button ID="Button2" runat="server" Text="Press Me 2!" OnClick="Button2_Click" />
       <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </asp:Panel>
</asp:Content>