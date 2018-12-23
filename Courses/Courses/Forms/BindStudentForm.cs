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
    public partial class BindStudentForm : Form
    {
        Form parentForm = null;
        int CourseId;
        public BindStudentForm(Form pparentForm, int courseId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            CourseId = courseId;
        }

        private void AddTopicForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                CoursesRequests.BindStudentToCourse((int)studentBox.SelectedValue, CourseId);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран элемент!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindTeacherForm_Load(object sender, EventArgs e)
        {
            studentBox.DisplayMember = "Name";
            studentBox.ValueMember = "Id";
            studentBox.DataSource = CoursesRequests.GetStudents();
        }
    }
}
