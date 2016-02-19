using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Funciones;

namespace EntregaTurnoRM
{
    public partial class Lista : System.Web.UI.Page
    {
        FLista func = new FLista();
        public string idRecogido;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = func.listaPac();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            // Se obtiene la fila seleccionada del gridview
            //
            GridViewRow row = GridView1.SelectedRow;

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Person
            //
            int id = Convert.ToInt32(GridView1.DataKeys[row.RowIndex].Value);
            Response.Redirect("~/historial.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                //
                // Se obtiene indice de la row seleccionada
                //
                int index = Convert.ToInt32(e.CommandArgument);

                //
                // Obtengo el id de la entidad que se esta editando
                // en este caso de la entidad Person
                //
                int id = Convert.ToInt32(GridView1.DataKeys[index].Value);

            }
        }

        protected void ClickLupa (object sender, EventArgs e)
        {
        
            ImageButton imageButton = (ImageButton)sender;
            TableCell tableCell = (TableCell)imageButton.Parent;
            GridViewRow row = (GridViewRow)tableCell.Parent;
            GridView1.SelectedIndex = row.RowIndex;
            int fila = row.RowIndex;

            idRecogido = ((Label)row.Cells[fila].FindControl("LblRut")).Text;
            Response.Redirect("IngresoDatos.aspx?id=" + idRecogido);
        }
    }
}