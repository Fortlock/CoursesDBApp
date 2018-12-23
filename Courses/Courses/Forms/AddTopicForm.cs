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
    public partial class AddTopicForm : Form
    {
        Form parentForm = null;
        int CourseId;
        public AddTopicForm(Form pparentForm, int courseId)
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
            if (CoursesRequests.AddTopic(nameBox.Text, CourseId) == null)
                MessageBox.Show("Тема не добавлена", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();
        }
    }
}
