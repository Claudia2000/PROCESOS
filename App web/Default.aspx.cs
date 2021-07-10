using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Visual
{
    public partial class _Default : Page
    {
        Visual.ServiceReference3.WebService1SoapClient obj = new Visual.ServiceReference3.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void validar_Click(object sender, EventArgs e)
        {
            string usu = v_usuario.Text;
            string contra = v_contra.Text;

            int num = obj.Login(usu, contra);
            if (num == 1)
            {
                Response.Redirect("About.aspx");
            }
            else
            {
                Response.Write("<script>alert('Contraseña o usuario incorrecto')</script>");
            }
        }
    }
}