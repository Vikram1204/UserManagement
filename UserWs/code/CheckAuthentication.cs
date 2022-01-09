using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace UserWs.code
{
    public class CheckAuthentication
    {
        dbOperation dbo = new dbOperation();
        public bool login(string username, string password, ref DataSet dsUser, ref string errorStr)
        {
            string qStr = string.Empty;
            try
            {
                qStr = " Select nUserId, vUserName, vPassword, vFirstName, vLastName, vEmailId, vContactNo \n"+
                       " From UserMst where vUsername = " + username.ToString()+" And vPassword = " + password.ToString();
                dbo.ExecSelect(qStr, ref dsUser, ref errorStr);
                return true;
            }
            catch (Exception ex)
            {
                errorStr = errorStr + "\n" + ex.Message;
                return false;
            }
        }
    }
}