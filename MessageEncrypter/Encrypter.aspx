<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Encrypter.aspx.cs" Inherits="MessageEncrypter.Encrypter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtMessage" runat="server" OnTextChanged="txtMessage_TextChanged"></asp:TextBox>
        <asp:Button ID="btnEncrypt" runat="server" OnClick="Button1_Click" Text="Encrypt Message" />
    
    </div>
    </form>
</body>
</html>
