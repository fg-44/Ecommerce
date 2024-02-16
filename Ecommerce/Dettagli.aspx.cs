using System;
using System.Collections.Generic;
using static Ecommerce.Welcome_01;

namespace Ecommerce
{
    public partial class Dettagli : System.Web.UI.Page
    {

        private int _productId;
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        protected void Page_Load(object sender, EventArgs e)

        {

            if (!IsPostBack)
            {
                // Inizializza la variabile di sessione con l'ID del prodotto
                Session["ProductId"] = Request.QueryString["productId"];
            }

        }
       }
    }
