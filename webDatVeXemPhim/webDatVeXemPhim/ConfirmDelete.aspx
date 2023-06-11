<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmDelete.aspx.cs" Inherits="webDatVeXemPhim.ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style/ConfirmDelete.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="confirmDelete" runat="server">
            <h1>Bạn có muốn xóa hay không?</h1>
            <div id="btn">
            <div runat="server" id="btnOK"></div>
            <div><a href="GioHang.aspx">Cancel</a></div> 
            </div>     
        </div>
    </form>
</body>
</html>
