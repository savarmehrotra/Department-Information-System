<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inventory1.aspx.cs" Inherits="Default2"  MasterPageFile="~/MasterPage.master"%>

<asp:Content ID="con2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <form id="form1" runat="server" style="height: 312px">
          <br />
          <br />
&nbsp;&nbsp;&nbsp; Name of the Item :
          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          <br />
          <br />
&nbsp;&nbsp;&nbsp; Quantity :
          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
          <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp; Total Cost :
          <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
          <br />
          <br />
&nbsp;&nbsp;&nbsp; Department:
          <asp:DropDownList ID="DropDownList1" runat="server">
              <asp:ListItem Selected="True">CSE</asp:ListItem>
              <asp:ListItem >Electrical</asp:ListItem>
              <asp:ListItem >Civil</asp:ListItem>
              <asp:ListItem Value="Mechanical"></asp:ListItem>
          </asp:DropDownList>
          <div style="margin-left: 240px">
              <br />
          </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
          &nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button2" runat="server" Text="Check Inventory" OnClick="Button2_Click" />
          <br />
          <br />
          <asp:Label ID="lbl" runat="server"> </asp:Label>
    </form>

</asp:Content>
  