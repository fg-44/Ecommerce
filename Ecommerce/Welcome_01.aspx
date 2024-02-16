<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome_01.aspx.cs" Inherits="Ecommerce.Welcome_01" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Esempio di e-commerce</title>

       <style>           
           .container
           {
               width: 18rem;
           }

       </style> 

</head>
<body>
    <div class="container">
        <%
            List<Vestiti> VestitiDisponibili = LoadProducts();
        %>
        <% foreach (var vestito in VestitiDisponibili) { %>

            <div id="product-item" class="product-item card">

            <img class="card-img-top" src="<%=HttpUtility.HtmlEncode(vestito.ImmagineUrl)%>" alt="<%=HttpUtility.HtmlEncode(vestito.Nome)%>"/>
            
            <div class="card-body">
            <h2 class="card-title"><%=HttpUtility.HtmlEncode(vestito.Nome)%></h2>
            <span><%=HttpUtility.HtmlEncode(vestito.Prezzo.ToString("C"))%></span>
            <p class="card-text"><%=HttpUtility.HtmlEncode(vestito.Descrizione)%></p>

              <a href="dettagli.aspx?productId=<%= Request.QueryString["id"]%>">Dettagli</a> <!-- LINK DETTAGLI PAGE -->

            </div>

        </div>
        <% } %>
    </div>
</body>
</html>