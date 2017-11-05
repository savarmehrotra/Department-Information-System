<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InventoryD.aspx.cs" Inherits="InventoryD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="form1" runat="server">
        <p style="height: 396px">
            Select Department Name:&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack-="true">
                <asp:ListItem>CSE</asp:ListItem>
                <asp:ListItem>Electrical</asp:ListItem>
                <asp:ListItem>Civil</asp:ListItem>
                <asp:ListItem>Mechanical</asp:ListItem>
            </asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:BoundField DataField="total" HeaderText="total" SortExpression="total" />
                    <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ConnectionStrings:StudentConnectionString%>" SelectCommand="SELECT [Name], [Quantity], [total], [Department] FROM [Inventory] WHERE ([Department] LIKE '%' + @Department + '%') ORDER BY [Id] DESC">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="Department" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        </p>
    </form>

</asp:Content>

