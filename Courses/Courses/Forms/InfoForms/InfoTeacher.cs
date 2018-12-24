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
    public partial class InfoTeacher : Form
    {
        Form parentForm = null;
        int TeacherId;


        public InfoTeacher(Form pparentForm, int teacherId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            TeacherId = teacherId;
        }

        private void InfoTeacher_Load(object sender, EventArgs e)
        {
            Teacher teacher = CoursesRequests.GetTeacher(TeacherId);
            if (teacher == null)
                Close();
            else
            {
                nameLabel.Text = CoursesRequests.GetTeacher(TeacherId).Name;
                RefreshTab();
            }
        }

        private void RefreshTab()
        {
            CoursesGridView.Columns[7].DefaultCellStyle.Format = "C";
            CoursesGridView.DataSource = CoursesRequests.GetCourseTeachersViews(TeacherId);
            if (CoursesGridView.RowCount == 0) CallDBTeacherForm.Enabled = false; else CallDBTeacherForm.Enabled = true;
        }

        private void InfoTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void InfoTeacher_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
                RefreshTab();
        }

        private void CoursesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabled = false;
            InfoCourseForm infoCourseForm = new InfoCourseForm(this, (int)CoursesGridView.SelectedRows[0].Cells[3].Value);
            infoCourseForm.Show();
        }

        private void CallDBTeacherForm_Click(object sender, EventArgs e)
        {
            DialogResult res;
            Enabled = false;
            res = MessageBox.Show(
                            "Are you sure?",
                            "Delete bind course",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                CoursesRequests.DelBindTeacherToCourse((int)(CoursesGridView.SelectedRows[0].Cells[0].Value));
            Enabled = true;
        }
    }
}
