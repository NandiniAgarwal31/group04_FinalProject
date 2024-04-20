<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="group04_FinalProject._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <div class="container">
        <h1>Welcome to LeetCode Problem Solver</h1>
        <form id="form1" runat="server">
            <asp:DropDownList ID="ddlLeetCode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLeetCode_SelectedIndexChanged">
                <asp:ListItem Text="Select a Problem" Disabled="false" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Intger to roman Problem" Value="Intger to roman"></asp:ListItem>
                <asp:ListItem Text="Basic Calutator Problem" Value="Basic Calutator"></asp:ListItem>
                <!--<asp:ListItem Text="Divide Two Integers" Value="Divide"></asp:ListItem>-->
             
            </asp:DropDownList>
            <asp:Button ID="btnSolve" runat="server" Text="Solve" OnClick="btnSolve_Click" />
            <div id="ProblemDescription" runat="server"></div>
            <div id="testCase" runat="server"></div>
            <div id="solution" runat="server"></div>
        </form>
    </div>
</body>
</html>
