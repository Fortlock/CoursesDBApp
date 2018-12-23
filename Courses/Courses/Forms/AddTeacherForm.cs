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
    public partial class AddTeacherForm : Form
    {
        Form parentForm = null;
        public AddTeacherForm(Form pparentForm)
        {
            InitializeComponent();
            parentForm = pparentForm;
        }

        private void AddTeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (CoursesRequests.AddTeacher(nameBox.Text)==null)
                MessageBox.Show("Учитель не добавлен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();
        }
    }
}
