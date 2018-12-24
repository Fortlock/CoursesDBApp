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
    public partial class InfoStudent : Form
    {
        Form parentForm = null;
        int StudentId;


        public InfoStudent(Form pparentForm, int studentId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            StudentId = studentId;
        }

        private void RefreshTab()
        {
            CoursesGridView.DataSource = CoursesRequests.GetCourseStudentViews(StudentId);
            if (CoursesGridView.RowCount == 0) CallDBStudentForm.Enabled = false; else CallDBStudentForm.Enabled = true;
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            Student student = CoursesRequests.GetStudent(StudentId);
            if (student == null)
                Close();
            else
            {
                nameLabel.Text = student.Name;
                RefreshTab();
            }
        }

        private void InfoStudent_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
                RefreshTab();
        }

        private void CoursesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabled = false;
            InfoCourseForm infoCourseForm = new InfoCourseForm(this, (int)CoursesGridView.SelectedRows[0].Cells[1].Value);
            infoCourseForm.Show();
        }

        private void CallDBStudentForm_Click(object sender, EventArgs e)
        {
            DialogResult res;
            Enabled = false;
            res = MessageBox.Show(
                            "Are you sure?",
                            "Delete bind course",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                CoursesRequests.DelBindStudentToCourse((int)(CoursesGridView.SelectedRows[0].Cells[0].Value));
            Enabled = true;
        }
    }
}
