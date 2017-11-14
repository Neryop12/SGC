using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Controladores
{
    public class cInformeResultados
    {
        DBConexion conectar;
        public DataTable dropAcciones()
        {
            conectar = new DBConexion();
            DataTable tabla = new DataTable();
            conectar.AbrirConexion();
            string query = "select * from dbcdagsgc.sgc_acciones_generadas;";
            MySqlDataAdapter consulta = new MySqlDataAdapter(query, conectar.conectar);
            consulta.Fill(tabla);
            conectar.CerrarConexion();
            return tabla;
        }

        public void dropProceso(DropDownList ddl)
        {
            conectar = new DBConexion();
            DataTable tabla = new DataTable();
            conectar.AbrirConexion();
            string query = "SELECT * FROM dbcdagsgc.sgc_proceso;";
            MySqlDataAdapter consulta = new MySqlDataAdapter(query, conectar.conectar);
            consulta.Fill(tabla);
            conectar.CerrarConexion();
            ddl.ClearSelection();
            ddl.Items.Clear();
            ddl.AppendDataBoundItems = true;
            ddl.Items.Add("<< Elija Proceso >>");
            ddl.Items[0].Value = "0";

            ddl.DataSource = tabla;
            ddl.DataTextField = "Proceso";
            ddl.DataValueField = "id_proceso";
            ddl.DataBind();
            
        }

        public void dropUnidad(DropDownList ddl)
        {
            conectar = new DBConexion();
            DataTable tabla = new DataTable();
            conectar.AbrirConexion();
            string query = "select id_unidad,Unidad from dbcdagsgc.sgc_unidad where id_unidad = id_padre;";
            MySqlDataAdapter consulta = new MySqlDataAdapter(query, conectar.conectar);
            consulta.Fill(tabla);
            conectar.CerrarConexion();
            ddl.ClearSelection();
            ddl.Items.Clear();
            ddl.AppendDataBoundItems = true;
            ddl.Items.Add("<< Elija Unidad >>");
            ddl.Items[0].Value = "0";

            ddl.DataSource = tabla;
            ddl.DataTextField = "Unidad";
            ddl.DataValueField = "id_unidad";
            ddl.DataBind();

        }

        public void dropTipoAccion(DropDownList ddl)
        {
            conectar = new DBConexion();
            DataTable tabla = new DataTable();
            conectar.AbrirConexion();
            string query = "select * from dbcdagsgc.sgc_tipo_accion;";
            MySqlDataAdapter consulta = new MySqlDataAdapter(query, conectar.conectar);
            consulta.Fill(tabla);
            conectar.CerrarConexion();
            ddl.ClearSelection();
            ddl.Items.Clear();
            ddl.AppendDataBoundItems = true;
            ddl.Items.Add("<< Elija Tipo Accion >>");
            ddl.Items[0].Value = "0";

            ddl.DataSource = tabla;
            ddl.DataTextField = "accion";
            ddl.DataValueField = "id_tipo_accion";
            ddl.DataBind();

        }


        public bool IngresarInforme(string anio,string no_informe, string fecha_informe,int id_accion,string correlativo,string norma,string unidad,string dependencia,string desc,string enlace,string analista, string fecha_accion,int id_tipo_accion,
            string fecha_recepcion,int cantidad,int accion_fin)
        {
            try
            {
                conectar = new DBConexion();

                conectar.AbrirConexion();
                string query = string.Format("INSERT INTO dbcdagsgc.sgc_informe_correcion (`anio_inicio`, `no_informe`, `fecha_informe`, `id_accion`, `no_correlativo_hallazgo`, `norma`, `id_unidad`, `id_dependencia`, `descripcion`, `id_enlace`, `id_analista`, `fecha_accion`, `id_tipo_accion`, `fecha_recepecion`, `cantidad_acciones`, `acciones_finalizadas`) " +
                    "VALUES ('{0}', '{1}', now(), {2}, '{3}', '{4}', {5}, {6}, '{7}', {8},{9},now(), {10},now(), {11},{12}); ", anio, no_informe, id_accion,correlativo,norma,unidad,dependencia,desc,enlace,analista,id_tipo_accion,cantidad,accion_fin);
                MySqlCommand cmd = new MySqlCommand(query, conectar.conectar);
                cmd.ExecuteNonQuery();
                conectar.CerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }


        }
    }
}
