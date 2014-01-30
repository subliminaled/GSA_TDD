<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="AllrecipesSearchService.Admin"
    ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title>test</title>
    <link type="text/css" href="http://jqueryui.com/latest/themes/base/jquery.ui.all.css"
        rel="stylesheet" />

    <script type="text/javascript" src="http://jqueryui.com/latest/jquery-1.4.2.js"></script>

    <script type="text/javascript" src="http://jquery-ui.googlecode.com/svn/tags/1.8rc1/jquery-1.4.1.js"></script>

    <script type="text/javascript" src="http://jquery-ui.googlecode.com/svn/tags/1.8rc1/ui/jquery-ui.js"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $("#tabs").tabs();
        });
    </script>

</head>
<body style="font-size: 62.5%;">
    <form runat="server">
    <div id="tabs">
        <ul>
            <li><a href="#fragment-1"><span>Stats</span></a></li>
            <li><a href="#fragment-2"><span>Indexing</span></a></li>
            <li><a href="#fragment-3"><span>Querying</span></a></li>
        </ul>
        <div id="fragment-1">
            <p>
                First tab is active by default:</p>
            <pre><code>$('#example').tabs();</code></pre>
        </div>
        <div id="fragment-2">
            Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh
            euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Lorem ipsum dolor
            sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt
            ut laoreet dolore magna aliquam erat volutpat.
        </div>
        <div id="fragment-3">
            Query:
            <br />
            <asp:TextBox runat="server" ID="txtQuery" TextMode="MultiLine" Columns="100" Rows="10"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="btnPost" Text="Post" OnClick="btnPost_Click" />
        </div>
    </div>
    </form>
</body>
</html>
