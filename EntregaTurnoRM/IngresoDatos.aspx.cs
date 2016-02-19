using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EntregaTurnoRM
{
    public partial class IngresoDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string results = "";
            if (Request.QueryString["Id"] != null)
            {
                results = Request.QueryString["Id"].ToString();
                Label1.Text = results;
            }
            else{
                Label1.Text = "There is no results in QueryString";
            }
            /*Label1.Text = rut;
            Label1.Visible = true;

            Response.Write("Rut: " + rut);*/
            
        }
    }
}