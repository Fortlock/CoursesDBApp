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
                case "TeachersPage":
                    {
                        TeachersGridView.DataSource = CoursesRequests.GetTeachers();
                        if (TeachersGridView.RowCount == 0) CallDTeacherForm.Enabled = false; else CallDTeacherForm.Enabled = true; break;
                    }
                case "SchoolsPage":
                    {
                        SchoolsGridView.DataSource = CoursesRequests.GetSchools();
                        if (SchoolsGridView.RowCount == 0) CallDSchoolForm.Enabled = false; else CallDSchoolForm.Enabled = true; break;
                    }
                case "SubjectsPage":
                    {
                        SubjectsGridView.DataSource = CoursesRequests.GetSubjects();
                        if (SubjectsGridView.RowCount == 0) CallDSubjectForm.Enabled = false; else CallDSubjectForm.Enabled = true; break;
                    }
                case "StudentsPage":
                    {
                        StudentsGridView.DataSource = CoursesRequests.GetStudentViews();
                        if (StudentsGridView.RowCount == 0) CallDStudentForm.Enabled = false; else CallDStudentForm.Enabled = true; break;
                    }
                case "CoursesPage":
                    {
                        CoursesGridView.DataSource = CoursesRequests.GetCourseViews();
                        if (CoursesGridView.RowCount == 0) CallDCourseForm.Enabled = false; else CallDCourseForm.Enabled = true; break;
                    }
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
                case "CallNCourseForm":
                    {
                        AddCourseForm addCourseForm = new AddCourseForm(this);
                        addCourseForm.Show();
                        break;
                    }
            }
            Enabled = false;
        }

        private void CallDelForm_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            DialogResult res;
            Enabled = false;
            switch (name)
            {
                case "CallDTeacherForm":
                    {
                        res = MessageBox.Show(
                            "Are you sure?", 
                            "Delete teacher",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                            CoursesRequests.DelTeacher((int)(TeachersGridView.SelectedRows[0].Cells[0].Value));
                        break;
                    }
                case "CallDSchoolForm":
                    {
                        res = MessageBox.Show(
                            "Are you sure?", 
                            "Delete school",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                            CoursesRequests.DelSchool((int)(SchoolsGridView.SelectedRows[0].Cells[0].Value));
                        break;
                    }
                case "CallDSubjectForm":
                    {
                        res = MessageBox.Show(
                            "Are you sure?", 
                            "Delete subject",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                            CoursesRequests.DelSubject((int)(SubjectsGridView.SelectedRows[0].Cells[0].Value));
                        break;
                    }
                case "CallDStudentForm":
                    {
                        res = MessageBox.Show(
                            "Are you sure?", 
                            "Delete student",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                            CoursesRequests.DelStudent((int)(StudentsGridView.SelectedRows[0].Cells[0].Value));
                        break;
                    }
                case "CallDCourseForm":
                    {
                        res = MessageBox.Show(
                            "Are you sure?", 
                            "Delete course",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                            CoursesRequests.DelCourse((int)(CoursesGridView.SelectedRows[0].Cells[0].Value));
                        break;
                    }
            }
            Enabled = true;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e) => RefreshTab(tabControl.SelectedTab.Name);

        private void MainForm_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
                RefreshTab(tabControl.SelectedTab.Name);
        }

        private void CoursesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoCourseForm infoCourseForm = new InfoCourseForm(this,(int)CoursesGridView.SelectedRows[0].Cells[0].Value);
            infoCourseForm.Show();
            Enabled = false;
        }

        
    }
}
