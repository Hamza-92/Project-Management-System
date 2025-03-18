using Business_Logic_Layer;

namespace Project_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProjectManagement projectManagement = new ProjectManagement();
            projectsTable.DataSource = projectManagement.GetProjects();
        }
    }
}
