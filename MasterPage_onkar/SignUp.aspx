<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="MasterPage_onkar.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: "Segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            background: #f0f0f0;
            margin: 0;
            padding: 0;
        }

        /* Center the form on the page */
        form {
            width: 450px;
            margin: 80px auto;
            background: #ffffff;
            border-radius: 8px;
            padding: 30px;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

        /* Form Title */
        h1 {
            font-size: 1.4em;
            margin-bottom: 20px;
            color: #333;
            text-align: center;
            border-bottom: 2px solid #FF6F00;
            padding-bottom: 10px;
        }

        /* Grouped Fields (Labels + Input) */
        .field-group {
            margin-bottom: 20px;
        }

        label {
            display: block;
            font-weight: bold;
            color: #333;
            margin-bottom: 8px;
        }

        input[type="text"],
        input[type="password"],
        .textbox {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        /* Focus effect */
        input[type="text"]:focus,
        input[type="password"]:focus,
        .textbox:focus {
            border-color: #FF6F00;
            outline: none;
        }

        /* Button Styling */
        .btn {
            background: #FF6F00;
            color: #fff;
            border: none;
            border-radius: 4px;
            padding: 10px 20px;
            font-size: 1em;
            font-weight: bold;
            cursor: pointer;
            width: 100%;
            text-align: center;
            margin-top: 10px;
        }

        .btn:hover {
            background: #cc5800;
        }

        /* Responsive Design for smaller screens */
        @media(max-width: 500px) {
            form {
                width: 90%;
                margin: 40px auto;
            }

            h1 {
                font-size: 1.4em;
            }

            .field-group input[type="text"], 
            .field-group input[type="password"], 
            .field-group .textbox {
                font-size: 14px;
                padding: 10px;
            }

            .btn {
                font-size: 14px;
                padding: 10px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Password&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        </div>
    </form>

</body>
</html>
