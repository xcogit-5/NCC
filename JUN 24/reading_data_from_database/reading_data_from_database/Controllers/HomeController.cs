using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace reading_data_from_database.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            {
                string ServerLocation = "Data Source =XCOGITBOOK\\MSSQLSERVER1; uid = sa; pwd = sql; Initial catalog = test";
                SqlConnection con = new SqlConnection(ServerLocation);
                string sql = "Select * from tblStudent";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ViewBag.Result = dt;
                //if (dt.Rows.Count > 0)
                //{
                //    Response.Redirect("https://www.gmail.com");
                //}
               
                    return View("Get");

                //ViewBag.result = dt;
                //return View();
            }
        }

    }
}
