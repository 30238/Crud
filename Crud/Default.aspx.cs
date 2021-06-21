using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Crud
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["conndb"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText ="Datos";
                cmd.Connection = conn;
                conn.Open();
                gvdDatos.DataSource = cmd.ExecuteReader();
                gvdDatos.DataBind();
                  
            }
                    }
    }
}