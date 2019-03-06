<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="Panel1" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Press Here" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </asp:Panel>
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
    <asp:ListBox ID="ListBox1" runat="server"> 
        <items>
            <asp:ListItem runat="server" Text="1" Value="1" ></asp:ListItem>
            <asp:ListItem runat="server" Text="2" Value="2" ></asp:ListItem>
        </items>
    </asp:ListBox>
       
    <asp:Button ID="HidePanel" runat="server" OnClick="HidePanel_Click" Text="HidePanel" />
    
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    
    <asp:Panel ID="Panel2" runat="server">
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button2" />
    <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>
    </asp:Panel>

    <asp:Button ID="SearchSoldiers" runat="server" Text="Button" OnClick="SearchSoldiers_Click" />

    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

</asp:Content>
