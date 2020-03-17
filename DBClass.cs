using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Population
{
    public class DBClass
    {
        SqlConnection Con = null;
        //SqlDataAdapter Adp = null;
        SqlCommand CMD = null;
        public int getApplicationId()
        {
            int C = 0;
            try
            {
                Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                Con.Open();
                CMD = new SqlCommand("select max(ApplicationId) from tbl_Population", Con);
                string S = CMD.ExecuteScalar().ToString();
                if (S == "")
                    C++;
                else
                    C = int.Parse(S) + 1;
            }
            catch(SqlException E)
            {

            }
            finally
            {
                Con.Close();
            }
            return C;
        }
        public string SaveMembers(List<Population> L)
        {
            string str = null;
            try 
            {
                Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                Con.Open();
                CMD = new SqlCommand("sp_Population", Con);
                CMD.CommandType = CommandType.StoredProcedure;
                DataTable Db = new DataTable();
                Db.Columns.Add("ApplicationId", typeof(Int32));
                Db.Columns.Add("MemberId", typeof(Int32));
                Db.Columns.Add("Firstname", typeof(string));
                Db.Columns.Add("Middlename", typeof(string));
                Db.Columns.Add("Lastname", typeof(string));
                Db.Columns.Add("Suffix", typeof(string));
                Db.Columns.Add("Dob", typeof(DateTime));
                Db.Columns.Add("Gender", typeof(string));
                for (int i = 0; i < L.Count; i++)
                {
                    Db.Rows.Add(L[i].ApplicationId, L[i].MemberId, L[i].Firstname, L[i].Middlename, L[i].Lastname, L[i].Suffix, L[i].Date, L[i].Gender);
                }
                SqlParameter P = new SqlParameter("@Pop_cen",Db);
                P.SqlDbType = SqlDbType.Structured;
                CMD.Parameters.Add(P);
                CMD.ExecuteNonQuery();
                str = "Application submitted with" + L.Count + "Member details. Your ApplicationId is" + L[0].ApplicationId;
            }
            catch(SqlException E)
            {

            }
            finally
            {
                Con.Close();
            }
            return str;
        }
    }
}