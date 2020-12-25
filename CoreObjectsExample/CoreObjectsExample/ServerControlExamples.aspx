<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerControlExamples.aspx.cs" Inherits="CoreObjectsExample.ServerControlExamples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlCountries" runat="server" Height="27px" Width="219px" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="Label" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />
        </div>
    </form>
</body>
</html>
