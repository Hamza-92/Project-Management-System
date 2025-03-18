using Database_Layer;
using System.Data;

namespace Business_Logic_Layer
{
    public class ProjectManagement
    {
        private readonly MyDB my_db = new MyDB();

        public DataTable GetProjects()
        {
            return my_db.GetAllProjects();
        }
    }
}
