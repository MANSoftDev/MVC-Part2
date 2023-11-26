<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    CodeBehind="Artists.aspx.cs" Inherits="Mvc.Views.Music.Artists" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <asp:Panel ID="Menu" runat="server">
    </asp:Panel>
    <asp:ListView ID="ArtistList" runat="server">
        <LayoutTemplate>
            <ul>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <li>
                <%# Html.RouteLink((string)Eval("name"), new RouteValueDictionary(new { controller = "Artist", action = "AlbumsByArtistId", id = Eval("id") }))%>
            </li>
        </ItemTemplate>
        <EmptyDataTemplate>
            No artist currently available...
        </EmptyDataTemplate>
    </asp:ListView>
</asp:Content>
