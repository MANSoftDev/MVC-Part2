<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    CodeBehind="Albums.aspx.cs" Inherits="Mvc.Views.Music.Albums" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <asp:Panel ID="Menu" runat="server"></asp:Panel>
    <asp:Label runat="server" ID="ArtistName"></asp:Label>
    <asp:ListView ID="AlbumList" runat="server">
        <LayoutTemplate>
            <ul>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <%# Html.RouteLink((string)Eval("name"), new RouteValueDictionary(new { controller="Music", action = "Songs", id = Eval("id") }))%>
            <br />
        </ItemTemplate>
        <EmptyDataTemplate>
            No albums currently available...
        </EmptyDataTemplate>
    </asp:ListView>
</asp:Content>
