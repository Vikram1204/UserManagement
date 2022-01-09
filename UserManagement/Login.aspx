<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UserManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <script src="Scripts/bootstrap.min.js"></script> 
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/General.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/General.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="container-fluid">           
               <div class="conLogin">
                   <h2>Login</h2>
                   <hr />
                   <div class="mb-3">
                       <asp:Label ID="lblUsername" Text="Username" runat="server" CssClass="form-label" />
                       <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
                   </div>
                   <div class="mb-3">
                       <asp:Label ID="lblPassword" Text="Password" runat="server" CssClass="form-label" />
                       <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="form-control" /> 
                   </div>
                   <div class="mb-3 text-center">
                       <asp:Button runat="server" CssClass="btn btn-primary" Text="Login" />
                   </div>
               </div>
           </div>       
    </form>
</body>
</html>
