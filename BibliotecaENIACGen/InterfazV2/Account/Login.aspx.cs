using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;
using InterfazV2;


namespace InterfazV2.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }
        protected void boton_registro(object sender, EventArgs e)
        {
            
        }
        
    }
}
