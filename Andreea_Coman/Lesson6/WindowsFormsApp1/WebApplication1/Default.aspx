<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <asp:Panel ID="Panel1" runat="server"> 

    <asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" Text="Do not press " Width="166px" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
      

    <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:ImageMap ID="ImageMap1" runat="server" Height="55px" Width="212px">

     </asp:ImageMap>
             

  </asp:Panel>
   <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" Height="34px" Width="167px" />
     <br />
     <asp:Panel ID="Panel2" runat="server"> 
    <asp:Button ID="Button2" runat="server" Height="31px" OnClick="Button2_Click" Text="Button" Width="168px" />
    
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label2"></asp:Label>
           </asp:Panel>
    <br />
    <asp:ListBox ID="ListBox1" runat="server">
        <Items>
                        <asp:ListItem runat="server" Text="One" Value =" 1 "></asp:ListItem>
                        <asp:ListItem runat="server" Text="Two" Value =" 2 "></asp:ListItem>
                        <asp:ListItem runat="server" Text="Three" Value =" 3 "></asp:ListItem>
                        <asp:ListItem runat="server" Text="Four" Value =" 4 "></asp:ListItem>
        </Items>

    </asp:ListBox>

    <br />
    <br />
    <p>
    </p>

    

</asp:Content>
