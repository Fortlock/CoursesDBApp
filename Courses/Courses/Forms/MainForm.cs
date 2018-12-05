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
            switch (name)
            {
                case "TeachersPage": TeachersGridView.DataSource = CoursesRequests.GetTeachers(); break;
                case "SchoolsPage": SchoolsGridView.DataSource = CoursesRequests.GetSchools(); break;
                case "SubjectsPage": SubjectsGridView.DataSource = CoursesRequests.GetSubjects(); break;
                case "StudentsPage": StudentsGridView.DataSource = CoursesRequests.GetStudentViews(); break;
                default: break;
            }
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
                        AddSubjectForm addSubjectForm = new AddSubjectForm(this);
                        addSubjectForm.Show();
                        break;
                    }
                case "CallNStudentForm":
                    {
                        AddStudentForm addStudentForm = new AddStudentForm(this);
                        addStudentForm.Show();
                        break;
                    }
            }
            Enabled = false;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e) => RefreshTab(tabControl.SelectedTab.Name);

        private void MainForm_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
                RefreshTab(tabControl.SelectedTab.Name);
        }
    }
}
