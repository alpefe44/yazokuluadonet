<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListe.aspx.cs" Inherits="OgrenciListe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="table  table-bordered table-hover">
        <tr>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Öğrenci Bakiye</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

            <tr>
                <td><%#Eval("OGRAD") %></td>
                <td><%#Eval("OGRSOYAD") %></td>
                <td><%#Eval("OGRNUMARA") %></td>
                <td><%#Eval("OGRSIFRE") %></td>
                <td><%#Eval("OGRMAIL") %></td>
                <td><%#Eval("OGRBAKIYE") %></td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server"   NavigateUrl = '<%#string.Format("OgrenciSil.aspx?ID={0}",Eval("OGRID")) %>'
                        CssClass = "btn btn-danger">Sil</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass = "btn btn-success" NavigateUrl = '<%#string.Format("OgrenciGuncelle.aspx?ID={0}",Eval("OGRID")) %>'>Güncelle</asp:HyperLink>

                </td>
            </tr>

                </ItemTemplate>
            </asp:Repeater>
        </tbody>
      
    </table>
</asp:Content>

