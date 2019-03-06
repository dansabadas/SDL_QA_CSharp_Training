<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="panel1" runat="server">  

    <asp:Button ID="Button1" runat="server" Text="Press me" OnClick="Button1_Click" />

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
     </asp:Panel>
   
    <asp:Panel ID="panel2" runat="server">
    <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </asp:Panel>

    <asp:Panel ID="panel3" runat="server" >

       

    <asp:Button ID="Button3" runat="server" Text="hide panel alternate" OnClick="Button3_Click" />

    </asp:Panel>


    <asp:ListBox ID="ListBox1" runat="server">
         <Items>
            <asp:ListItem Text="text1" Value="1">  </asp:ListItem>
            <asp:ListItem Text="text2" Value="2">  </asp:ListItem>
          
        </Items>
    </asp:ListBox>
    

    

      


</asp:Content>

