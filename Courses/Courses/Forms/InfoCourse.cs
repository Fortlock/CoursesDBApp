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

        private void CallDelForm_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            DialogResult res;
            Enabled = false;
            switch (name)
            {
                case "CallDTopicForm":
                    {
                        res = MessageBox.Show(
                            "Are you sure?",
                            "Delete topic",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                            CoursesRequests.DelTopic((int)(TopicsGridView.SelectedRows[0].Cells[0].Value));
                        break;
                    }
                case "CallDBTeacherForm":
                    {
                        res = MessageBox.Show(
                            "Are you sure?",
                            "Delete bind teacher",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                            CoursesRequests.DelBindTeacherToCourse((int)(TeachersGridView.SelectedRows[0].Cells[0].Value));
                        break;
                    }
                case "CallDBStudentForm":
                    {
                        res = MessageBox.Show(
                            "Are you sure?",
                            "Delete student",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                            CoursesRequests.DelBindStudentToCourse((int)(StudentsGridView.SelectedRows[0].Cells[0].Value));
                        break;
                    }
            }
            Enabled = true;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e) => RefreshTab(tabControl.SelectedTab.Name);

        private void CallNForm_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            switch (name)
            {
                case "CallNTopicForm":
                    {
                        AddTopicForm addTopicForm = new AddTopicForm(this, course.Id);
                        addTopicForm.Show();
                        break;
                    }
                case "CallBTeacherForm":
                    {
                        BindTeacherForm bindTeacherForm = new BindTeacherForm(this, course.Id);
                        bindTeacherForm.Show();
                        break;
                    }
                case "CallBStudentForm":
                    {
                        BindStudentForm bindStudentForm = new BindStudentForm(this, course.Id);
                        bindStudentForm.Show();
                        break;
                    }
            }
            Enabled = false;
        }

        private void InfoCourseForm_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                course = CoursesRequests.GetCourse(course.Id);
                RefreshTab(tabControl.SelectedTab.Name);
            }
        }
    }
}
