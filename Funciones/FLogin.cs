using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Funciones
{
    public class FLogin
    {
        public string usuario;

        public bool buscaRut(string clave)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsicbo"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from per_fil where clave=@clave", con);
                cmd.Parameters.AddWithValue("clave", clave);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    usuario = Convert.ToString(dr["rut_num"]);
                    return true;
                }
                else
                {
                    return false;
                }

                cmd.Dispose();
                con.Close();
            }
        }
    }
}
