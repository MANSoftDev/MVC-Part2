<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    CodeBehind="Songs.aspx.cs" Inherits="Mvc.Views.Music.Songs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <asp:Panel ID="Menu" runat="server"></asp:Panel><br />
    <%= Html.ActionLink(ViewData.Model[0].Album.Artist.name, "AlbumsByArtistId", "Artist", new { id = ViewData.Model[0].Album.artist_id })%> 
    -> <asp:Label runat="server" ID="AlbumName"></asp:Label>
    
    <asp:ListView ID="SongList" runat="server">
        <LayoutTemplate>
            <ul>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <%# Eval("name") %><br />
        </ItemTemplate>
        <EmptyDataTemplate>
            No songs currently available...
        </EmptyDataTemplate>
    </asp:ListView>
</asp:Content>
