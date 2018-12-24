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
    public partial class EditTopicForm : Form
    {
        Form parentForm = null;
        int EditId;

        int CourseId;
        public EditTopicForm(Form pparentForm, int courseId, int editId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            CourseId = courseId;
            EditId = editId;
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
            if (CoursesRequests.EditTopic(EditId, nameBox.Text, CourseId) == null)
                MessageBox.Show("Тема не добавлена", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();
        }

        private void EditTopicForm_Load(object sender, EventArgs e)
        {
            Topic t = CoursesRequests.GetTopic(EditId);
            if (t == null)
                Close();
            else
            {
                nameBox.Text = t.Name;
            }
        }
    }
}
