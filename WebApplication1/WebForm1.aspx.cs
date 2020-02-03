using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Database objDataBase = new SqlDatabase(System.Configuration.ConfigurationManager.ConnectionStrings["collbra10ConnectionString"].ConnectionString);
            // DataSet ds = new DataSet();
            // try

            // {
            //     ds = objDataBase.ExecuteDataSet("GetUsers");
            //     GridView2.DataSource = ds.Tables[0];
            //     GridView2.DataBind();
            // }
            //catch (Exception ex)
            // {
            //     throw ex;
            // }

            //Executer.LogMyMsgs();
            //Response.Write("Log entry is done");


            try

            {

                throw new Exception("This exception created by rashmi");

            }

            catch (Exception ex)

            {
                
                
                bool rethrow = ExceptionPolicy.HandleException(ex, "UI Policy");


                if (rethrow)

                {

                    throw;

                }

                Response.Write("Exception Occured");

            }

        }
    }
}