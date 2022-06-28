using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace DB_conn.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Student(string Name)
        {
            string serverLocation = "Data Source = XCOGITBOOK\\MSSQLSERVER1; uid = sa; pwd = sql; Initial catalog = test";
            SqlConnection con = new SqlConnection(serverLocation);
            string sql = "delete from tblStudent where Name=@Name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", Name);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return View();
        }

    }
}
