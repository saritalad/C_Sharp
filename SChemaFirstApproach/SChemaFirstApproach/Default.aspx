<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SChemaFirstApproach._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <table class="nav-justified">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Font-Size="20px" ForeColor="#CC0066" Text="Entity Data Model,used to Bind Data"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

    

</asp:Content>
