using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleJogadores
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AtletasContext())
            {
                var atleta = new Atleta
                {
                    Nome = txtNome.Text,
                    Apelido = txtApelido.Text,
                    DataNascimento = DateTime.Parse(txtNasc.Text),
                    Altura = double.Parse(txtAltura.Text),
                    Peso = double.Parse(txtPeso.Text),
                    Posicao = txtPosicao.Text,
                    CamisaNro = txtCamisa.Text,
                };
                context.Atletas.Add(atleta);
                context.SaveChanges();
            }
            Response.Redirect("ListarAtletas.aspx");
        }
    }
}