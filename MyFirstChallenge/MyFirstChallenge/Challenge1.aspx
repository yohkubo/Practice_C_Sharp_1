<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Challenge1.aspx.cs" Inherits="MyFirstChallenge.Challenge1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="result">
    <form id="form1" runat="server">
        <div>

            Where do you live?&nbsp;
            <asp:TextBox ID="place1TextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Which country or state do you want to go from your place?&nbsp; <asp:TextBox ID="place2TextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Click" runat="server" OnClick="Click_Click" Text="Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
