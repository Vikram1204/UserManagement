using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UserWs.code
{
    public class dbOperation
    {
        private string ConnSrt = ConfigurationManager.ConnectionStrings["ConnUser"].ToString();           

        public bool ExecSelect(string qStr, ref DataSet dataSet, ref string errorStr)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(ConnSrt))
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlDataAdapter adapter ;

                    cmd.CommandText = qStr;
                    cmd.Connection = conn; 
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataSet);
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