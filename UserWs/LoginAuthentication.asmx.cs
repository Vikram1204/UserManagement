using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UserWs
{
    /// <summary>
    /// Summary description for LoginAuthentication
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginAuthentication : System.Web.Services.WebService
    {

        [WebMethod]
        public bool Login(string Username, string Password, ref DataSet dsUser, ref string errorStr)
        {            
            try
            {
                code.CheckAuthentication checkAuth = new code.CheckAuthentication();
                if (!checkAuth.login(Username, Password, ref dsUser, ref errorStr))
                {
                    throw new Exception(errorStr);
                }
                return true;
            }
            catch (Exception ex)
            {
                errorStr =  ex.Message;
                return false;
            }
        }
    }
}
