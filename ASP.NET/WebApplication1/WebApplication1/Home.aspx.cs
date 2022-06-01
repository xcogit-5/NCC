using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = count + "";
                DropDownList1.Items.Add("Select Countries");
                DropDownList1.Items.Add("Nepal");
                DropDownList1.Items.Add("Sri Lanka");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count++;
            TextBox1.Text = count.ToString();
        }
    }
}