<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnAddress.aspx.cs" Inherits="AnAddress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 71px;
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
           <asp:Label ID="lblHouseNo" runat="server" Text="Label1">House No</asp:Label> 
                <asp:TextBox ID="txtHouseNo" runat="server"></asp:TextBox>
           <asp:Label ID="lblStreet" runat="server" Text="Label2">Street</asp:Label>
                <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
           <asp:Label ID="lblTown" runat="server" Text="Label3">Town</asp:Label> 
                <asp:TextBox ID="txtTown" runat="server"></asp:TextBox>
           <asp:Label ID="lblPostCode" runat="server" Text="Label4">Post Code</asp:Label> <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
           <asp:Label ID="lblCounty" runat="server" Text="Label5">County</asp:Label> <asp:TextBox ID="txtCounty" runat="server"></asp:TextBox>
           <asp:Label ID="lblDateAdded" runat="server" Text="Label5">Date Added</asp:Label> <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
           <asp:Label ID="lblactiveBox" runat="server" Text="Label5">Active</asp:Label> <asp:CheckBox ID="CheckBox1" runat="server" />
           <asp:Label ID="lblError" runat="server" Text="lblError">lblError</asp:Label> 
           <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" /><asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>

</body>
</html>
