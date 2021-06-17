<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo4._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>My first DataAdapter web application</h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
<br />
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" EnableSortingAndPagingCallbacks="True">
</asp:GridView>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
</asp:Content>
