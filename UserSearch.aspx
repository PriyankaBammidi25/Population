<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UserSearch.aspx.cs" Inherits="Population.UserSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
      
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
        <tr>
            <th>UserSearch</th>
        </tr>
        
        <tr><td>Use any combination of fields below to search through all customers</td></tr>
        <tr>
            <td>FirstName</td>
            <td>LastName</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtFname" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>DOB</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox3" TextMode="Date" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>ApplicationID</td>
            
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtAppId" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Search" BackColor="#669900" class="BorderStyle" Height="35px" OnClick="Button1_Click" /></td>
        </tr>
        <tr>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" OnPageIndexChanged="GridView1_PageIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="1"></asp:GridView>
        </tr>
    </table>
</asp:Content>
