<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="group04_FinalProject._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f5f5f5;
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
        }

        #form1 {
            margin-top: 20px;
        }

        #ddlLeetCode {
            padding: 10px;
            font-size: 16px;
            border-radius: 5px;
            margin-right: 10px;
        }

        #btnSolve {
            padding: 10px 20px;
            font-size: 16px;
            border-radius: 5px;
            background-color: #4CAF50;
            color: white;
            border: none;
            cursor: pointer;
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
        }
    </style>

     
</head>
<body>
   
        <div>
        
        <form id="form1" runat="server">
            <asp:DropDownList ID="ddlLeetCode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLeetCode_SelectedIndexChanged">
                <asp:ListItem Text="Select a Problem" Disabled="false" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Integer to Roman Problem" Value="Integer to Roman"></asp:ListItem>
                <asp:ListItem Text="Basic Calculator Problem" Value="Basic Calculator"></asp:ListItem>
                <asp:ListItem Text="Climibing Staris Problem" Value="Climibing Staris"></asp:ListItem>
            

            </asp:DropDownList>

            <asp:Button ID="btnSolve" runat="server" Text="Solve" OnClick="btnSolve_Click" />

            <div id="ProblemDescription" runat="server"></div>
            <div id="testCase" runat="server"></div>
            <div id="solution" runat="server"></div>
        </form>
    </div>
</body>
</html>
