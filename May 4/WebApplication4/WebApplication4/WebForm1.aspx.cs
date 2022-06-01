using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if(TextBox2.Text=="")
            {
                TextBox2.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                Literal1.Text = "Empty Name";
            }
            else
                Literal1.Text = "You're authorized";
        }
    }
}