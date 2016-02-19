using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Funciones;

namespace EntregaTurnoRM
{
    public partial class Historial : System.Web.UI.Page
    {
        FLista func = new FLista();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntok_Click(object sender, EventArgs e)
        {
            dghistorial.DataSource = func.historial(Convert.ToDateTime(txtfecha.Text));
            dghistorial.DataBind();
        }
    }
}