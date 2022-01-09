using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using UserManagement.Models;

namespace UserManagement
{
    public partial class Login : System.Web.UI.Page
    {
        LoginAuthentication.LoginAuthentication checkAuth = new LoginAuthentication.LoginAuthentication();
        DataSet dsUser = new DataSet();
        string errorStr = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {       

            lblError.Text = string.Empty;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkAuth.Login(txtUsername.Text.ToString(), txtPassword.Text.ToString(), ref dsUser, ref errorStr))
                {
                    throw new Exception(errorStr);
                }
                
                Session[CommonClass.UserId] = dsUser.Tables[0].Rows[0]["nUserId"];
                Session[CommonClass.UserFullName] = dsUser.Tables[0].Rows[0]["vFirstName"] + " " + dsUser.Tables[0].Rows[0]["vLastName"];

                Response.Redirect("Home.aspx");
            }
            catch(Exception ex)
            {
               lblError.Text = ex.Message;                
            }         
            
        }
    }
}