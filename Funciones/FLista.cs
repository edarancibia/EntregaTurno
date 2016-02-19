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
    public class FLista
    {
        public DataTable listaPac()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT DISTINCT B.RUT_NUM RUT,A.FECHAINGRESO INGRESO,LTRIM(RTRIM(D.A_PAT))+' '+ LTRIM(RTRIM(D.A_MAT))+' '+ LTRIM(RTRIM(D.NOMBRE))PACIENTE ,A.NRO_FI FICHA,CAST(a.MOTIVOCONSULTA as Varchar)MOTIVO,C.DESCRIP TRIAGE,E.NOMBRE PREVISION,a.rut_med
                                                    FROM HCA_FICHAPACIENTE A,HCA_FICHARUT B, HCA_CLASIFICACIONPACIENTE C,PACIENTE D,PREVIS E
                                                    WHERE ((A.ESTADO=5) AND A.RUT_MED='15275069' AND A.NRO_FI=B.NRO_FI AND YEAR(A.FECHAINGRESO)=YEAR(CONVERT(char(10), getdate(), 103)) AND MONTH(A.FECHAINGRESO)=MONTH(CONVERT(char(10), getdate(), 103))
                                                    AND DAY(A.FECHAINGRESO)=DAY(CONVERT(char(10), getdate(), 103))) AND (A.ID_CLASIFICACION*=C.ID_CLASIFICACION) 
                                                    AND B.rut_num=D.RUT_NUM AND A.RUT_PRE=E.RUT_NUM
                                                    ORDER BY A.FECHAINGRESO DESC", ConfigurationManager.ConnectionStrings["cnsicbo"].ConnectionString);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable historial(DateTime fecha)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsicbo"].ConnectionString);
            SqlCommand cmd = new SqlCommand(@"SELECT DISTINCT A.nro_fi FICHA,LTRIM(RTRIM(C.A_PAT))+' '+LTRIM(RTRIM(C.A_MAT))+' '+LTRIM(RTRIM(C.NOMBRE)) PACIENTE,CAST(a.comentarios as Varchar)COMENTARIOS,LTRIM(RTRIM(D.NOMBRE))MEDICO
                                                    FROM HCA_ENTREGATURNO A,HCA_FICHARUT B,PACIENTE C,MEDICO D 
                                                    WHERE fecha=@fecha AND A.nro_fi=B.NRO_FI AND B.rut_num=C.RUT_NUM AND A.rut_med=D.RUT_NUM",con);
            cmd.Parameters.AddWithValue("fecha",fecha);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
