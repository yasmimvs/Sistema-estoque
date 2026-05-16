using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sistema_De_estoque2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
     
        List<Produto> lista = new List<Produto>();
        public class Produto
        {
            
                public string Id { get; set; }
                public string Nome { get; set; }
                public int Quantidade { get; set; }
            
        }
        string projectId = "papelariaestoque-8eb56";

        protected async void btnAdd_Click(object sender, EventArgs e)
        {
            await SalvarNoFirebase();

            lista.Clear();

            await CarregarProdutos();

            txtNome.Text = "";
            txtQtd.Text = "";
        }
        private async Task SalvarNoFirebase()
        {
            string nome = txtNome.Text;
            string qtd = txtQtd.Text;

            string json = @"{
        ""fields"": {
            ""nome"": { ""stringValue"": """ + nome + @""" },
            ""quantidade"": { ""integerValue"": """ + qtd + @""" }
        }
    }";

            string url =

$"https://firestore.googleapis.com/v1/projects/{projectId}/databases/(default)/documents/produtos";
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);

                string resultado = await response.Content.ReadAsStringAsync();

                Response.Write("Produto adicionado com sucesso!");
            }
        }

        // ✔ AQUI agora o GET fica dentro de um método
        private async Task CarregarProdutos()
        {
            string url =
            $"https://firestore.googleapis.com/v1/projects/{projectId}/databases/(default)/documents/produtos";

            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync(url);

                var doc = Newtonsoft.Json.Linq.JObject.Parse(json);

                lista.Clear();

                foreach (var item in doc["documents"])
                {
                    string id = item["name"].ToString().Split('/').Last();

                    lista.Add(new Produto
                    {
                        Id = id,
                        Nome = item["fields"]["nome"]["stringValue"].ToString(),
                        Quantidade = int.Parse(item["fields"]["quantidade"]["integerValue"].ToString())
                    });
                }

                GridView1.DataSource = lista;
                GridView1.DataBind();

            }
        }

        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                await CarregarProdutos();
            }
        }
        private async Task ExcluirProduto(string id)
        {
            string url =
            $"https://firestore.googleapis.com/v1/projects/{projectId}/databases/(default)/documents/produtos/{id}";

            using (HttpClient client = new HttpClient())
            {
                await client.DeleteAsync(url);
            }
        }

        protected async void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                string id = e.CommandArgument.ToString();

                await ExcluirProduto(id);

                await CarregarProdutos();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
         
        
            Response.Redirect("Default.aspx");
        
    }
    }
    }
    
    
    

        
    