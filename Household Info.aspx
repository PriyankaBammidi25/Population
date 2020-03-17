<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Household Info.aspx.cs" Inherits="Population.Household_Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
        
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    .BorderStyle{
    border-radius:10px;}
        </style>
    <table align="center">
        <tr>
            <td>Create Application</td>
            <td></td>
            <td></td>
            <td style="color: #FF0000">*RequiredField</td>
        </tr>
        <tr>
            <td>Household member</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"></asp:Label>Firstname</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>M.I</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label>Lastname</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label">Suffix</asp:Label></td>
            </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtfname" runat="server" ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Fname" ControlToValidate="txtfname" Display="None"></asp:RequiredFieldValidator></td>
           
            <td>
                <asp:TextBox ID="txtmname" runat="server" ></asp:TextBox></td>
           
            <td>
                <asp:TextBox ID="txtlname" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlname" Display="None" ErrorMessage="Enter Lname"></asp:RequiredFieldValidator></td>
            
            
            <td>
                <asp:DropDownList ID="DDList" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem>Mr</asp:ListItem>
                    <asp:ListItem>Mrs</asp:ListItem>
                    <asp:ListItem>Miss</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red"></asp:Label>Date of Birth(mm/dd/yyyy)</td>
        <td>
            <asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label>Gender</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtDate" TextMode="Date" runat="server" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Date" ControlToValidate="txtDate" Display="None"></asp:RequiredFieldValidator></td>
            <td>
                <asp:RadioButton ID="RadioButton1" Groupname="Gender" runat="server" />Male             
                <asp:RadioButton ID="RadioButton2" Groupname="Gender" runat="server" />Female
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Button ID="btnAdd" runat="server" Text="Add Member" BackColor="#669900" class="BorderStyle" Height="35px" OnClick="Button1_Click1" OnClientClick="return Validate();" /></td>
        </tr>
       
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save and Exit" BackColor="#669900" class="BorderStyle" Height="33px" OnClick="btnSave_Click" /></td>
        </tr>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Display="List" Height="200px" />
</asp:Content>
