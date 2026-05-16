using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace sistema_De_estoque2
{
    public partial class _Default : Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                await CarregarProdutos();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("estoque.aspx");
        }

        private async Task CarregarProdutos()
        {
            
            }
        }
    }

    
    