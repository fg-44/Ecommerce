using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Ecommerce.Welcome_01;

namespace Ecommerce
{
    public partial class Welcome_01 : System.Web.UI.Page
    {
        // STOCK NEGOZIO VESTITI => 
        public class Vestiti
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descrizione { get; set; }
            public decimal Prezzo { get; set; }
            public string ImmagineUrl { get; set; }
        }

        private List<Vestiti> VestitiDisponibili = new List<Vestiti>
        {
            new Vestiti { Id = 01, Nome = "Maglietta",  Descrizione = "Descrizione molto base del prodotto Maglietta", Prezzo = 35.50M, ImmagineUrl = "Content/Img/Maglietta.jpg" },
            new Vestiti { Id = 02, Nome = "Pantaloni",  Descrizione = "Descrizione molto base del prodotto Pantaloni", Prezzo = 67.20M, ImmagineUrl = "Content/Img/Pantaloni.jpg" },
            new Vestiti { Id = 03, Nome = "Gonna",      Descrizione = "Descrizione molto base del prodotto Gonna",     Prezzo = 46.35M, ImmagineUrl = "Content/Img/Gonna.jpg" },
            new Vestiti { Id = 04, Nome = "Sciarpa",    Descrizione = "Descrizione molto base del prodotto Sciarpa",   Prezzo = 20.00M, ImmagineUrl = "Content/Img/Sciarpa.jpg" },
            new Vestiti { Id = 05, Nome = "Calzini",    Descrizione = "Descrizione molto base del prodotto Calzini",   Prezzo = 9.40M,  ImmagineUrl = "Content/Img/Calzini.jpg" },
        };

        protected void Page_Load(object sender, EventArgs e)
        {

            foreach (Vestiti vestito in VestitiDisponibili) 
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<a href='#' onclick='showDetails(" + vestito.Id + ")'>" +
                vestito.Descrizione + "</a>");

                if (!IsPostBack)
                {
                   
                }

                LoadProducts();

            }
            
            
        }

        public List<Vestiti> LoadProducts()
        {
            List<Vestiti> products = new List<Vestiti>();

            foreach (var item in VestitiDisponibili)
            {
                products.Add(item);
            }

            return products;
        }

        private string FormatUrl(string name, string queryString)
        {
            // Creare una catena di URL sicura
            NameValueCollection input = HttpUtility.ParseQueryString(string.Empty);
            input["name"] = name;
            input.Add(queryString, "{0}");
            return HttpUtility.UrlEncode(HttpUtility.UrlEncode(input.ToString()).Replace("name=", ""));
        }


    }
}
