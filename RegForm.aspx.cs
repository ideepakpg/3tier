using BusinessLogicLayer;
using System;

namespace _3tier_regform
{
    public partial class RegForm : System.Web.UI.Page
    {

        BLL obj = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = obj.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, FileUpload1.FileName, TextBox4.Text, TextBox5.Text);
            if (i != 0)
            {
                Label5.Text = "Registration Success";
            }
            else
            {
                Label5.Text = "Registration Failed";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}