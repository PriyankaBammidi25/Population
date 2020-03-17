<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Population.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <td> <asp:Button ID="btnCreate" runat="server" Text="Create Application"  BackColor="#00CC00" OnClick="btnCreate_Click" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSearch" runat="server" Text="Search Application"  BackColor="#00CC00" OnClick="btnSearch_Click" /></td>
        </tr>
        
    </table>
    
    
</asp:Content>
