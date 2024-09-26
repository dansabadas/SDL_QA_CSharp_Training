<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Button ID="HidePanelButton" runat="server" Height="50px" Text="Hide Panel" Width="150px" OnClick="HidePanelButton_Click" />

    <asp:Button ID="Filter" runat="server" Height="50px" Text="Filter" Width="150px" OnClick="Filter_Click" />

    <br />

    <asp:DropDownList ID="ListOFCountries" runat="server" Height="30px" Width="150px">
    </asp:DropDownList>

    <br />

    <asp:ListBox ID="ListBox1" runat="server" Width="50">
        <Items>
            <asp:ListItem runat="server" Text="1" Value="1"></asp:ListItem>
            <asp:ListItem runat="server" Text="1" Value="1"></asp:ListItem>
        </Items>
    </asp:ListBox>

    <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
    </asp:GridView>

    <br />

   <asp:Panel ID="Panel1" runat="server" Visible="False">
       <asp:Button ID="IncrementButton" runat="server" Text="Increment Button" Height="50px" OnClick="IncrementButton_Click" Width="150px" />
        <asp:TextBox ID="TextBox1" runat="server" Width="60px"></asp:TextBox>
   </asp:Panel> 

    <br />

    <asp:Panel ID="Panel2" runat="server">
        <asp:Button ID="ViewStateButton" runat="server" Height="50px" OnClick="Button1_Click" Text="View State" Width="150px" />
        <asp:TextBox ID="TextBox2" runat="server" Width="60px"></asp:TextBox>
    </asp:Panel>
    
    <br />

    

   
</asp:Content>
