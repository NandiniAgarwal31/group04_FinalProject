<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="group04_FinalProject._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <!-- Test -->
        <div>
        
        <form id="form1" runat="server">
            <asp:DropDownList ID="ddlLeetCode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLeetCode_SelectedIndexChanged">
                <asp:ListItem Text="Select a Problem" Disabled="false" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Integer to Roman Problem" Value="Integer to Roman"></asp:ListItem>
                <asp:ListItem Text="Basic Calculator Problem" Value="Basic Calculator"></asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="btnSolve" runat="server" Text="Solve" OnClick="btnSolve_Click" />
            <div id="ProblemDescription" runat="server"></div>
            <div id="testCase" runat="server"></div>
            <div id="solution" runat="server"></div>
        </form>
    </div>
</body>
</html>
