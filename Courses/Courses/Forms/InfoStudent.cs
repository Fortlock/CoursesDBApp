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
            //if (TeachersGridView.RowCount == 0) CallDBTeacherForm.Enabled = false; else CallDBTeacherForm.Enabled = true;
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
    }
}
