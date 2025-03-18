using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Database_Layer
{
    public class MyDB
    {
        private readonly string _connection_string = ConfigurationManager.ConnectionStrings["ProjectDB"].ConnectionString;

        public DataTable GetAllProjects()
        {
            DataTable projectsTable = new DataTable();

            SqlConnection conn = new SqlConnection(_connection_string);
            conn.Open();
            
            string query = "select * from projects";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(projectsTable);
            
            conn.Close();
            
            return projectsTable;
        }
    }
}
