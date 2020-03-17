using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Population
{
    public partial class Population2 : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlDataAdapter Adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public void Add()
        {
            List<Population> L = new List<Population>();
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            Adp = new SqlDataAdapter("sp_Population", Con);
            Adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adp.SelectCommand.Parameters.AddWithValue("@Pop_cen", Con);
            Population P = new Population();
            int Applicationid = getApplicationId();
            Adp.SelectCommand.Parameters.AddWithValue("@Aid", Applicationid);
            L.Add(P);
            Session["L"] = L;
            if (Session["L"]==null)
            {

            }

        }
        public int getApplicationId()
        {
            Adp = new SqlDataAdapter("select max(ApplicationId) from tbl_Population", Con);
            DataSet DS = new DataSet();
            Adp.Fill(DS, "P");
            int appId = int.Parse(DS.Tables["P"].Rows[0][0].ToString());
            return appId;
        }
    }
}