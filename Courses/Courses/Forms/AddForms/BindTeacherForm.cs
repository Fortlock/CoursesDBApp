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
    public partial class BindTeacherForm : Form
    {
        Form parentForm = null;
        int CourseId;
        public BindTeacherForm(Form pparentForm, int courseId)
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
                if (CoursesRequests.BindTeacherToCourse((int)teacherBox.SelectedValue, CourseId) == null)
                    MessageBox.Show("Учитель уже ведет курс", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран элемент!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindTeacherForm_Load(object sender, EventArgs e)
        {
            teacherBox.DisplayMember = "Name";
            teacherBox.ValueMember = "Id";
            teacherBox.DataSource = CoursesRequests.GetTeachers();
        }
    }
}
