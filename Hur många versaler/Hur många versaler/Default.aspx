<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hur_många_versaler.Default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>
    <form id="myForm" runat="server">
        <div>
            <%-- Textruta där användaren skriver in sin textsträng. --%>
            <asp:TextBox ID="MyTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <%-- Fält som kommer innehålla värdet av versalantalet. --%>
            <asp:Label ID="Counter" runat="server"></asp:Label>
            <br />
            <%-- Knappar som startar uträkningen & återställer formuläret till dess ursprungliga skick. --%>
            <asp:Button ID="MyButton" runat="server" Text="Bestäm antalet versaler" OnClick="MyButton_Click" />
            <asp:Button ID="ResetButton" runat="server" Text="Rensa" Visible="false" />
        </div>
    </form>
</body>
</html>
