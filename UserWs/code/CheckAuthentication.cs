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
                if(!dbo.isUserExist(username, ref errorStr))
                {
                    throw new Exception(errorStr);
                }

                qStr = " Select nUserId, vUserName, vPassword, vFirstName, vLastName, vEmailId, vContactNo \n"+
                       " From UserMst where vUsername = '" + username.ToString()+"' And vPassword = '" + password.ToString()+"'";

                if(!dbo.ExecSelect(qStr, ref dsUser, ref errorStr))
                {
                    throw new Exception(errorStr);
                }

                if(dsUser.Tables[0].Rows.Count <= 0)
                {
                    throw new Exception("Invalid Username or Password");
                }

                return true;
            }
            catch (Exception ex)
            {
                errorStr = ex.Message;
                return false;
            }
        }        
    }
}