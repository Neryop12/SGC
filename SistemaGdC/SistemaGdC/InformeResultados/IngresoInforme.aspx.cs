using Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaGdC.Informe
{
    public partial class IngresoInforme : System.Web.UI.Page
    {
        cInformeResultados cResultados;
        cGeneral cGen;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtanio.Text = "2017";
                cResultados = new cInformeResultados();
                ddlAccionGenerada.ClearSelection();
                ddlAccionGenerada.Items.Clear();
                ddlAccionGenerada.AppendDataBoundItems = true;
                ddlAccionGenerada.Items.Add("<< Elija Accion >>");
                ddlAccionGenerada.Items[0].Value = "0";

                ddlAccionGenerada.DataSource = cResultados.dropAcciones();
                ddlAccionGenerada.DataTextField = "Accion";
                ddlAccionGenerada.DataValueField = "id_acciones";
                ddlAccionGenerada.DataBind();
                cResultados.dropProceso(ddlProceso);
                cResultados.dropUnidad(ddlUnidad);
                cResultados.dropTipoAccion(dllTipoAccion);
                cGen = new cGeneral();
                ddlResponsable.ClearSelection();
                ddlResponsable.Items.Clear();
                ddlResponsable.AppendDataBoundItems = true;
                ddlResponsable.Items.Add("<< Elija Empleado >>");
                ddlResponsable.Items[0].Value = "0";
                ddlResponsable.DataSource = cGen.dropEmpleados();
                ddlResponsable.DataTextField = "texto";
                ddlResponsable.DataValueField = "id";
                ddlResponsable.DataBind();

                ddlAnalista.ClearSelection();
                ddlAnalista.Items.Clear();
                ddlAnalista.AppendDataBoundItems = true;
                ddlAnalista.Items.Add("<< Elija Empleado >>");
                ddlAnalista.Items[0].Value = "0";
                ddlAnalista.DataSource = cGen.dropEmpleados();
                ddlAnalista.DataTextField = "texto";
                ddlAnalista.DataValueField = "id";
                ddlAnalista.DataBind();

            }
           


        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            cResultados = new cInformeResultados();
            if (cResultados.IngresarInforme(txtanio.Text,txtInforme.Text,txtFechaInforme.Text,int.Parse(ddlAccionGenerada.SelectedValue),txtNoPlanAccion.Text,txtPuntoNorma.Text,ddlUnidad.SelectedValue,ddlUnidad.SelectedValue,
                txtDescripcion.Text,ddlResponsable.SelectedValue,ddlAnalista.SelectedValue,txtFechaSolicitud.Text,int.Parse(dllTipoAccion.SelectedValue),txtFechaRecepcion.Text,4,2))
            {
                ScriptManager.RegisterStartupScript(this, typeof(string), "Mensaje", "alert('ALMACENADO/MODIFICADO exitosamente!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(string), "Mensaje", "alert('Error al ingresar');", true);
            }
        }
    }
}