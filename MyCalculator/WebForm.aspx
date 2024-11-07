<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="MyCalculator.WebForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator Web App</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculator Web App</h2>
            <p>
                Number 1: <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox><br />
                Number 2: <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox><br /><br />

                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnSubtract" runat="server" Text="Subtract" OnClick="btnSubtract_Click" />
                <asp:Button ID="btnMultiply" runat="server" Text="Multiply" OnClick="btnMultiply_Click" />
                <asp:Button ID="btnDivide" runat="server" Text="Divide" OnClick="btnDivide_Click" /><br /><br />

                <asp:Label ID="lblAddResult" runat="server" Text="Addition Result: " /><br />
                <asp:Label ID="lblSubtractResult" runat="server" Text="Subtraction Result: " /><br />
                <asp:Label ID="lblMultiplyResult" runat="server" Text="Multiplication Result: " /><br />
                <asp:Label ID="lblDivideResult" runat="server" Text="Division Result: " /><br />
            </p>
        </div>
    </form>
</body>
</html>