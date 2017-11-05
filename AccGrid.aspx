<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccGrid.aspx.cs"  MasterPageFile="~/MasterPage.master"  Inherits="AccGrid" %>

<asp:Content ID="con3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id ="form1" runat="server" style="height: 324px">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                    <asp:BoundField DataField="origin" HeaderText="origin" SortExpression="origin" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ConnectionStrings:StudentConnectionString%>" SelectCommand="SELECT * FROM [Account] ORDER BY [Id] DESC"></asp:SqlDataSource>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />

        </div>
    </form>

</asp:Content>