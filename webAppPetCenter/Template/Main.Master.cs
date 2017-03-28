using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetCenterBL;
using PetCenterDL.Persistencia;
using System.Text;

namespace webAppPetCenter.Template
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarMenu();
            }
        }

        private void ListarMenu()
        {
            AplicacionBL aplicacion = AplicacionBL.Instance;
            var x = aplicacion.ObtenerMenu();
            StringBuilder cadena = new StringBuilder();

            cadena.Append("<li class='dropdown'>");
            cadena.Append("<a class='dropdown-toggle' data-toggle='dropdown' href='#'>Mantenimiento</a>");
            cadena.Append("<ul class='dropdown-menu'>");
            foreach (var item in x)
            {                
                cadena.AppendFormat("<li><a href='{1}'  >{0}</a></li>", item.Nombre, item.Controlador);                 
            }
            cadena.Append("</ul>");

            MenuPrincipal.Text = cadena.ToString();
        }
    }
}