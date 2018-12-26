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
            DisableButtons();
        }

        private void DisableButtons()
        {
            System.Security.Principal.IdentityReferenceCollection t = System.Security.Principal.WindowsIdentity.GetCurrent().Groups;
            if (System.Security.Principal.WindowsIdentity.GetCurrent().Groups.Where(p => p.Value == "S-1-5-21-394331043-2906864525-1991675871-1006").Count() != 0)
            {
                WhoLabel.Text += "админ.";
                return;
            }
            CallDTeacherForm.Enabled = CallETeacherForm.Enabled = CallNTeacherForm.Enabled = false;
            CallDSchoolForm.Enabled = false;
            CallDSubjectForm.Enabled = false;
            CallEStudentForm.Enabled = CallDStudentForm.Enabled = false;
            CallNCourseForm.Enabled = CallECourseForm.Enabled = CallDCourseForm.Enabled = false;
            if (System.Security.Principal.WindowsIdentity.GetCurrent().Groups.Where(p => p.Value == "S-1-5-21-394331043-2906864525-1991675871-1005").Count() != 0)
            {
                WhoLabel.Text += "учитель.";
                return;
            }
                
            CallESchoolForm.Enabled = CallNSchoolForm.Enabled = false;
            CallESubjectForm.Enabled = CallNSubjectForm.Enabled = false;
            CallNStudentForm.Enabled = false;
            if (System.Security.Principal.WindowsIdentity.GetCurrent().Groups.Where(p => p.Value == "S-1-5-21-394331043-2906864525-1991675871-1007").Count() != 0)
            {
                WhoLabel.Text += "ученик.";
                return;
            }
            Close();

        }

        private void RefreshTab(string name)
        {
            switch (name)
            {
                case "TeachersPage":
                    {
                        TeachersGridView.DataSource = CoursesRequests.GetTeachers().Where(p => p.Name.Contains(findTeacherBox.Text)).ToList();
                        if (TeachersGridView.RowCount == 0) CallDTeacherForm.Enabled = CallETeacherForm.Enabled = false; else CallDTeacherForm.Enabled = CallETeacherForm.Enabled = true; break;
                    }
                case "SchoolsPage":
                    {
                        SchoolsGridView.DataSource = CoursesRequests.GetSchools().Where(p => p.Name.Contains(findSchoolBox.Text)).ToList();
                        if (SchoolsGridView.RowCount == 0) CallDSchoolForm.Enabled = CallESchoolForm.Enabled = false; else CallDSchoolForm.Enabled = CallESchoolForm.Enabled = true; break;
                    }
                case "SubjectsPage":
                    {
                        SubjectsGridView.DataSource = CoursesRequests.GetSubjects().Where(p => p.Name.Contains(findSubjectBox.Text)).ToList();
                        if (SubjectsGridView.RowCount == 0) CallDSubjectForm.Enabled = CallESubjectForm.Enabled = false; else CallDSubjectForm.Enabled = CallESubjectForm.Enabled = true; break;
                    }
                case "StudentsPage":
                    {
                        StudentsGridView.DataSource = CoursesRequests.GetStudentViews().Where(p => p.Name.Contains(findStudentBox.Text)).ToList();
                        if (StudentsGridView.RowCount == 0) CallDStudentForm.Enabled = CallEStudentForm.Enabled = false; else CallDStudentForm.Enabled = CallEStudentForm.Enabled = true; break;
                    }
                case "CoursesPage":
                    {
                        CoursesGridView.Columns[3].DefaultCellStyle.Format = "C";
                        CoursesGridView.DataSource = CoursesRequests.GetCourseViews();
                        if (CoursesGridView.RowCount == 0) CallDCourseForm.Enabled = CallECourseForm.Enabled = false; else CallDCourseForm.Enabled = CallECourseForm.Enabled = true; break;
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

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = ((DataGridView)sender).Name;
            
            switch (name)
            {
                case "TeachersGridView":
                    {
                        InfoTeacher infoTeacher = new InfoTeacher(this, (int)TeachersGridView.SelectedRows[0].Cells[0].Value);
                        infoTeacher.Show();
                        break;
                    }
                case "CoursesGridView":
                    {
                        InfoCourseForm infoCourseForm = new InfoCourseForm(this, (int)CoursesGridView.SelectedRows[0].Cells[0].Value);
                        infoCourseForm.Show();
                        break;
                    }
                case "SchoolsGridView":
                    {
                        InfoSchool infoSchool = new InfoSchool(this, (int)SchoolsGridView.SelectedRows[0].Cells[0].Value);
                        infoSchool.Show();
                        break;
                    }
                case "SubjectsGridView":
                    {
                        InfoSubject infoSubject = new InfoSubject(this, (int)SubjectsGridView.SelectedRows[0].Cells[0].Value);
                        infoSubject.Show();
                        break;
                    }
                case "StudentsGridView":
                    {
                        InfoStudent infoStudent = new InfoStudent(this, (int)StudentsGridView.SelectedRows[0].Cells[0].Value);
                        infoStudent.Show();
                        break;
                    }
            }
            Enabled = false;
        }

        private void CallEditForm_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            Enabled = false;
            switch (name)
            {
                case "CallETeacherForm":
                    {
                        EditTeacherForm editTeacherForm = new EditTeacherForm(this, (int)TeachersGridView.SelectedRows[0].Cells[0].Value);
                        editTeacherForm.Show();
                        break;
                    }
                case "CallESchoolForm":
                    {
                        EditSchoolForm editSchoolForm = new EditSchoolForm(this, (int)SchoolsGridView.SelectedRows[0].Cells[0].Value);
                        editSchoolForm.Show();
                        break;
                    }
                case "CallESubjectForm":
                    {
                        EditSubjectForm editSubjectForm = new EditSubjectForm(this, (int)SubjectsGridView.SelectedRows[0].Cells[0].Value);
                        editSubjectForm.Show();
                        break;
                    }
                case "CallEStudentForm":
                    {
                        EditStudentForm editStudentForm = new EditStudentForm(this, (int)StudentsGridView.SelectedRows[0].Cells[0].Value);
                        editStudentForm.Show();
                        break;
                    }
                case "CallECourseForm":
                    {
                        EditCourseForm editCourseForm = new EditCourseForm(this, (int)CoursesGridView.SelectedRows[0].Cells[0].Value);
                        editCourseForm.Show();
                        break;
                    }
            }
        }

        private void findBox_TextChanged(object sender, EventArgs e)
        {
            string name = ((TextBox)sender).Name;

            switch (name)
            {
                case "findTeacherBox": RefreshTab("TeachersPage"); break;
                case "findSchoolBox": RefreshTab("SchoolsPage"); break;
                case "findSubjectBox": RefreshTab("SubjectsPage"); break;
                case "findStudentBox": RefreshTab("StudentsPage"); break;
            }
        }
    }
}
