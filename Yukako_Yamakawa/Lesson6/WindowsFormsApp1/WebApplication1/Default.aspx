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
    
    <asp:DropDownList ID="DropDownList1" runat="server">   
    </asp:DropDownList>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="10" >
        <Columns>
        <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="Soldier Name" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Kills" HeaderText="Enemies Annihilated" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Country" HeaderText="Homeland" />
        <asp:BoundField ItemStyle-Width="150px" DataField="SouldierId" HeaderText="Souldier ID" Visible="false"/>
        </Columns>
    </asp:GridView>
    
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Filter Soldiers" />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    
    <asp:Panel ID="panel2" runat="server">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button 2" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

</asp:Content>
