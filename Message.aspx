<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="Population.Message" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <style>
    .BorderStyle{
    border-radius:10px;}
        </style>
    <table align="center">
        <tr>
            <td>
                 <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr><td>
            <asp:Button ID="Button1" runat="server" Text="Home" BackColor="#669900" Height="33px" Width="80px" class="BorderStyle" OnClick="Button1_Click" />
            </td>
             
        </tr>
    </table>
   
</asp:Content>
