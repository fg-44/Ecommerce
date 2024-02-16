<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="Ecommerce.Dettagli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Content ID="Content1" ContentPlaceHolderID="head"">
               
                <script type="text/javascript">

                    function showDetails(product)
                    {
                        var url = location.href + "#" + product.id;
                        showProduct(url);
                    }

                </script>
                
                <div>
                    <p> PROVA <%= Session["ProductId"].ToString() %></p>

                </div>

            </asp:Content>



        </div>
    </form>
</body>
</html>
