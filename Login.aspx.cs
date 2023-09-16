using BusinessLogicLayer;
using System;
using System.Data.SqlClient;

namespace _3tier_regform
{
    public partial class Login : System.Web.UI.Page
    {
        BLL obj = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["username"] = TextBox1.Text;
            Session["password"] = TextBox2.Text;

            SqlDataReader rdr = obj.sid(TextBox1.Text, TextBox2.Text);
            if (rdr.Read())
            {
                Response.Redirect("LoginWelcome.aspx");
            }
        }
    }
}