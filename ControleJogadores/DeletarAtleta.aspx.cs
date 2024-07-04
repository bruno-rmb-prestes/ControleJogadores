using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleJogadores
{
    public partial class DeletarAtleta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int atletaId = Convert.ToInt32(Request.QueryString["AtletaID"]);
            using (var context = new AtletasContext())
            {
                var atleta = context.Atletas.FirstOrDefault(a => a.AtletaID == atletaId);
                if (atleta != null)
                {
                    context.Atletas.Remove(atleta);
                    context.SaveChanges();
                }
            }

            Response.Redirect("ListarAtletas.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarAtletas.aspx");
        }
    }
}