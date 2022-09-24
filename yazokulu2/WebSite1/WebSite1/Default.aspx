<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id ="Form1" runat="server">

        <div>
            <asp:Label ID="Label1" runat="server" Text="Ogrenci Ad"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"  CssClass ="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Label ID="Label2" runat="server" Text="Ogrenci Soyad"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"  CssClass ="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Öğrenci Numara"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Öğrenci Şifre"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"  CssClass ="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label5" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"  CssClass ="form-control"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn btn-info" OnClick="Button1_Click" />




    </form>
</asp:Content>

