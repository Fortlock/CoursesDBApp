using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courses.DataModel;

namespace Courses
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshTab("TeachersPage");
        }

        private void RefreshTab(string name)
        {
            CoursesEntities db = new CoursesEntities();
            switch (name)
            {
                case "TeachersPage": TeachersGridView.DataSource = db.Teachers.ToList();break;
                case "SchoolsPage": SchoolsGridView.DataSource = db.Schools.ToList(); break;
                case "SubjectsPage": SubjectsGridView.DataSource = db.Subjects.ToList(); break;
                default: break;
            }
            db.Dispose();
        }

        private void CallAddForm_Click(object sender, EventArgs e)
        {
            string name=((Button)sender).Name;
            switch (name)
            {
                case "CallNTeacherForm":
                    {
                        AddTeacherForm addTeacherForm = new AddTeacherForm(this);
                        addTeacherForm.Show();
                        break;
                    }
                case "CallNSchoolForm":
                    {
                        AddSchoolForm addSchoolForm = new AddSchoolForm(this);
                        addSchoolForm.Show();
                        break;
                    }
                case "CallNSubjectForm":
                    {
                        AddSchoolForm addSchoolForm = new AddSchoolForm(this);
                        addSchoolForm.Show();
                        break;
                    }
            }
            Enabled = false;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            RefreshTab(tabControl.SelectedTab.Name);
        }

        private void MainForm_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
                RefreshTab(tabControl.SelectedTab.Name);
        }
    }
}
