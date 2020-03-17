using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Population
{
    public partial class UserSearch : System.Web.UI.Page
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            // Bind();
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Bind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Bind()
        {
            string s=null;
         
           
            Con.Open();
            s = "select * from tbl_Population ";
            if (txtFname.Text.Length != 0)
            {
                s = s + "where Firstname=" + "\'" + txtFname.Text + "\'";
                txtFname.Text = "";
            }
            else if (txtAppId.Text.Length != 0)
            {
                s = s + "where ApplicationId=" + "\'" + int.Parse(txtAppId.Text) + "\'";
                txtAppId.Text = "";
            }
            else if (TextBox2.Text.Length != 0)
            {
                s = s + "where Lastname=" + "\'" + TextBox2.Text + "\'";
                TextBox2.Text = "";
            }
            else if (TextBox3.Text.Length != 0)
            {
                s = s + "where Dob=" + "\'" + DateTime.Parse(TextBox3.Text) + "\'";
                TextBox3.Text = "";
            }
            //else if(txtAppId.Text.Length==0 && txtFname.Text.Length==0&&TextBox2.Text.Length==0&&TextBox3.Text.Length==0)
            //{

            //}
            //Cmd = new SqlCommand(s, Con);
            //Cmd = new SqlCommand("select * from tbl_Population where ApplicationId=@Aid or Firstname=@Fn or Lastname=@Ln or Dob=@D", Con);
            //Cmd.Parameters.AddWithValue("@Aid", txtAppId.Text);
            //Cmd.Parameters.AddWithValue("@Fn", txtFname.Text);
            //Cmd.Parameters.AddWithValue("@Ln", TextBox2.Text);
            //Cmd.Parameters.AddWithValue("@D", TextBox3.Text);
            SqlDataReader R = Cmd.ExecuteReader();
            DataSet Ds = new DataSet();
            Ds.Tables.Add("New");
            Ds.Tables["New"].Load(R);
            GridView1.DataSource = Ds.Tables["New"];
            GridView1.DataBind();
            Con.Close();
        }

        protected void GridView1_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Bind();
        }
    }
}