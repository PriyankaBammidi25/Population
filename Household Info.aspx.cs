using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Population
{
    public partial class Household_Info : System.Web.UI.Page
    {
        List<Population> L = new List<Population>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["P"] != null)
                L = (List<Population>)Session["P"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DBClass D = new DBClass();
            int a=0;
            Population P = new Population();
            //if (L.Count == 0)
            P.ApplicationId = D.getApplicationId();
            //P.ApplicationId = a;
            P.MemberId = L.Count + 1;
            P.Firstname = txtfname.Text;
            P.Middlename = txtmname.Text;
            P.Lastname = txtlname.Text;
            P.Suffix = DDList.SelectedValue;
            0P.Date = DateTime.Parse(txtDate.Text);
            if(RadioButton1.Checked)
            {
                P.Gender = "Male";
            }
            else
                P.Gender = "Female";
            L.Add(P);
            Session["P"] = L;
            GridView1.DataSource = L;
            GridView1.DataBind();
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            if (RadioButton1.Checked)
                RadioButton1.Checked = false;
            else if (RadioButton2.Checked)
                RadioButton2.Checked = true;
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DBClass D = new DBClass();
            string s=D.SaveMembers(L);
            Session.Remove("P");
            Response.Redirect("Message.aspx?s="+s);
        }
    }
}