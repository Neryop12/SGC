using System;
using Controladores;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SistemaGdC
{
    
    public partial class SiteMaster : MasterPage
    {
        cMenu obMenu;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Session["Usuario"].ToString().ToLower();
           
            llenarMenu();
        }

        public void llenarMenu()
        {
            DataTable dtMenuItems = new DataTable();
            obMenu = new cMenu();
            dtMenuItems = obMenu.LlenarDoctosUsuarios(lblUsuario.Text);

            foreach (DataRow drMenuItem in dtMenuItems.Rows)
            {

                if (drMenuItem["id_menu"].Equals(drMenuItem["PadreId"]))
                {

                    MenuItem mnuMenuItem = new MenuItem();

                    mnuMenuItem.Value = drMenuItem["id_menu"].ToString();
                    mnuMenuItem.Text = drMenuItem["descripcion"].ToString();
                    
                    mnuMenuItem.NavigateUrl = drMenuItem["Url"].ToString();

                    MenuP.Items.Add(mnuMenuItem);


                }
            }
        }
    }
}