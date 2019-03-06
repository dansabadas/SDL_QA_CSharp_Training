<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Click meeeee" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server">
            <asp:Button ID="Button2" runat="server" Height="33px" OnClick="Button2_Click" Text="Button2" Width="121px" />
            <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
    </asp:Panel>
    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="109px" Rows="3">
        <Items>
            <asp:ListItem Text="text 1" Value ="1" />
            <asp:ListItem Text="text 2" Value ="2" />
            <asp:ListItem Text="text 4" Value ="4" />
            <asp:ListItem Text="text 3" Value ="3" />
        </Items>
    </asp:ListBox>

&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Switch Panel visibilty" />

    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns = "false" AllowPaging ="true" PageSize="10">
        <Columns>
            <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="Soldier Name" />
            <asp:BoundField ItemStyle-Width="150px" DataField="Kills" HeaderText="Soldier Kills" />
            <asp:BoundField ItemStyle-Width="150px" DataField="Country" HeaderText="Homeland" />
            <asp:BoundField ItemStyle-Width="150px" DataField="Id" HeaderText="Soldier Id" Visible = "false" />
        </Columns>
    </asp:GridView>

    <br />
    <asp:Button ID="Button_SearchSoldiers" runat="server" OnClick="Button_SearchSoldiers_Click" Text="SearchSoldiers" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />

</asp:Content>
