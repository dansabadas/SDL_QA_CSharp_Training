<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Button ID="HidePanelButton" runat="server" Height="50px" Text="Hide Panel" Width="150px" OnClick="HidePanelButton_Click" />

    <asp:ListBox ID="ListBox1" runat="server">
        <Items>
            <asp:ListItem runat="server" Text="1" Value="1"></asp:ListItem>
            <asp:ListItem runat="server" Text="1" Value="1"></asp:ListItem>
        </Items>
    </asp:ListBox>

   <asp:Panel ID="Panel1" runat="server" Visible="False">
       <asp:Button ID="IncrementButton" runat="server" Text="Increment Button" Height="50px" OnClick="IncrementButton_Click" Width="150px" />
        <asp:TextBox ID="TextBox1" runat="server" Width="60px"></asp:TextBox>
   </asp:Panel> 

    <asp:Panel ID="Panel2" runat="server">
        <asp:Button ID="ViewStateButton" runat="server" Height="50px" OnClick="Button1_Click" Text="View State" Width="150px" />
        <asp:TextBox ID="TextBox2" runat="server" Width="60px"></asp:TextBox>
    </asp:Panel>
    
    

    

   
</asp:Content>
