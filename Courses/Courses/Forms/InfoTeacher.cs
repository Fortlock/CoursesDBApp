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
            CoursesGridView.DataSource = CoursesRequests.GetCourseTeachersViews(TeacherId);
            //if (TeachersGridView.RowCount == 0) CallDBTeacherForm.Enabled = false; else CallDBTeacherForm.Enabled = true;
        }

        private void InfoTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }


    }
}
