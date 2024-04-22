<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="group04_FinalProject._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LeetCode Problem Solver</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #ffe0e6;
        }

        .container {
            width: 80%;
            margin: 20px auto;
            text-align: center;
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        h1 {
            color: #333;
            margin-bottom: 20px;
            text-align: center; 
            padding: 10px; 
            border-radius: 5px; 
        }

        #form1 {
            margin-top: 20px;
        }

        #ddlLeetCode {
            padding: 10px;
            font-size: 16px;
            border-radius: 5px;
            margin-right: 10px;
            border: 1px solid #ccc;
        }

        #btnSolve {
            padding: 10px 20px;
            font-size: 16px;
            border-radius: 5px;
            background-color: #ff69b4; 
            color: white;
            border: none;
            cursor: pointer;
            margin-top: 10px; 
        }

        #ProblemDescription,
        #testCase,
        #solution {
            margin-top: 20px;
            font-size: 16px;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #fff;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }
    </style>
     
</head>
<body>
   <h1>LeetCode Problem Solver</h1> 
    <div class="container">
        
        <form id="form1" runat="server">
    <asp:DropDownList ID="ddlLeetCode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLeetCode_SelectedIndexChanged">
        <asp:ListItem Text="Select a Problem" Disabled="true" Selected="True"></asp:ListItem>
        <asp:ListItem Text="Integer to Roman Problem" Value="Integer to Roman"></asp:ListItem>
        <asp:ListItem Text="Basic Calculator Problem" Value="Basic Calculator"></asp:ListItem>
        <asp:ListItem Text="Climbing Stairs Problem" Value="Climbing Stairs"></asp:ListItem>
    </asp:DropDownList>

    
    <asp:Label ID="lblSteps" runat="server" Text="Enter number of steps:" AssociatedControlID="txtSteps" Visible="false"></asp:Label>
    <asp:TextBox ID="txtSteps" runat="server" Visible="false"></asp:TextBox>
<div>
    <asp:Button ID="btnSolve" runat="server" Text="Solve" OnClick="btnSolve_Click" />
    </div>
    <div id="ProblemDescription" runat="server"></div>
    <div id="testCase" runat="server"></div>
    <div id="solution" runat="server"></div>
            <asp:Image ID="Image1" runat="server" />
</form>
    </div>
</body>
</html>
