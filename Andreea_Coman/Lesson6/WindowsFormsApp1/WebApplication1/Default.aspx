<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <asp:Panel ID="Panel1" runat="server"> 

        <br />
        <br />

    <asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" Text="Do not press " Width="166px" />
        &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
      

        <br />
        <br />
      

        <br />
             

  </asp:Panel>
   <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" Height="41px" Width="167px" BackColor="#876879" />
     &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
     <br />
    <br />
     <br />
     <asp:Panel ID="Panel2" runat="server"> 
    <asp:Button ID="Button2" runat="server" Height="37px" OnClick="Button2_Click" Text="Button" Width="163px" />
    
         &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>
           </asp:Panel>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ListBox ID="ListBox1" runat="server" >
        <Items>
                        <asp:ListItem runat="server" Text="One" Value =" 1 "></asp:ListItem>
                        <asp:ListItem runat="server" Text="Two" Value =" 2 "></asp:ListItem>
                        <asp:ListItem runat="server" Text="Three" Value =" 3 "></asp:ListItem>
                        <asp:ListItem runat="server" Text="Four" Value =" 4 "></asp:ListItem>
        </Items>

    </asp:ListBox>

    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns =" false">
        <Columns>
        <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="Soldier Name" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Kills" HeaderText="Enemies Anihilated" />
        <asp:BoundField ItemStyle-Width="150px" DataField="Country" HeaderText="Home Land" />
        <asp:BoundField ItemStyle-Width="150px" DataField="SoldierID" HeaderText="Whatever"  />
            </Columns>

    </asp:GridView>

    <br />
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Search Button" />

    <br />
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" Width="143px">
    </asp:DropDownList>


</asp:Content>
