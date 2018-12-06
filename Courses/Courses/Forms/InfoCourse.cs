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
    public partial class InfoCourseForm : Form
    {
        Form parentForm = null;
        Course course;
        public InfoCourseForm(Form pparentForm,int courseId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            course = CoursesRequests.GetCourse(courseId);
        }

        private void InfoCourse_Load(object sender, EventArgs e)
        {
            subjectlabel.Text = course.Subject.Name;
            durationlabel.Text = course.Duration.ToString();
            costlabel.Text = course.Cost.ToString();
            RefreshTab("TopicsPage");
        }

        private void RefreshTab(string name)
        {
            switch (name)
            {
                case "TeachersPage": TeachersGridView.DataSource = CoursesRequests.GetTeachers(course.CoursesTeachers.ToList()); break;
                case "TopicsPage": TopicsGridView.DataSource = CoursesRequests.GetTopics(course.Id); break;
                case "StudentsPage": StudentsGridView.DataSource = CoursesRequests.GetCourseStudentViews(course.CoursesStudents.ToList()); break;
                default: break;
            }
        }

        private void InfoCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e) => RefreshTab(tabControl.SelectedTab.Name);
    }
}
