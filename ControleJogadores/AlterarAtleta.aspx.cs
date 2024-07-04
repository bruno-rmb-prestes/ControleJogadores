using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ControleJogadores
{
    public partial class AlterarAtleta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int atletaId = Convert.ToInt32(Request.QueryString["AtletaID"]);
                using (var context = new AtletasContext())
                {
                    var atleta = context.Atletas.FirstOrDefault(a => a.AtletaID == atletaId);
                    if (atleta != null)
                    {
                        txtNome.Text = atleta.Nome;
                        txtApelido.Text = atleta.Apelido;
                        txtNasc.Text = atleta.DataNascimento.ToString("yyyy-MM-dd");
                        txtAltura.Text = atleta.Altura.ToString();
                        txtPeso.Text = atleta.Peso.ToString();
                        txtPosicao.Text = atleta.Posicao;
                        txtCamisa.Text = atleta.CamisaNro;
                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            int atletaId = Convert.ToInt32(Request.QueryString["AtletaID"]);
            using (var context = new AtletasContext())
            {
                var atleta = context.Atletas.FirstOrDefault(a => a.AtletaID == atletaId);
                if (atleta != null)
                {

                    atleta.Nome = txtNome.Text;
                    atleta.Apelido = txtApelido.Text;
                    atleta.DataNascimento = DateTime.Parse(txtNasc.Text);
                    atleta.Altura = double.Parse(txtAltura.Text);
                    atleta.Peso = double.Parse(txtPeso.Text);
                    atleta.Posicao = txtPosicao.Text;
                    atleta.CamisaNro = txtCamisa.Text;
                    context.SaveChanges();
                }
            }

           
            Response.Redirect("ListarAtletas.aspx");
        }
    }
}