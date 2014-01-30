<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckMe.aspx.cs" Inherits="AllrecipesSearchService.CheckMe"
    Title="Check Me" %>

<%@ Register Assembly="Allrecipes" Namespace="Allrecipes.Web.Monitoring.Controls"
    TagPrefix="AR" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        CheckMe.aspx
    </div>
    <div>
        <AR:ApplicationStatusDisplay ID="status" runat="server" />
    </div>
    </form>
</body>
</html>
