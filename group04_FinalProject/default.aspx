<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="group04_FinalProject._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            < <h1>Welcome to LeetCode Problem Solver</h1>
            <asp:DropDownList ID="ddlLeetCode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLeetCode_SelectedIndexChanged">
                <asp:ListItem Text="Select a Problem" Disabled="True" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Climbing Stairs" Value="Stairs"></asp:ListItem>
                <asp:ListItem Text="Integer to Roman" Value="Integer"></asp:ListItem>
                <asp:ListItem Text="Basic Calculator" Value="Calc"></asp:ListItem>
        
            </asp:DropDownList>
            <asp:Button ID="btnSolve" runat="server" Text="Solve" OnClick="btnSolve_Click" />
            <div id="ProblemDescription" runat="server"></div>
            <div id="testCase" runat="server"></div>
            <div id="solution" runat="server"></div>
        </div>
   </form>
</body>
</html>
