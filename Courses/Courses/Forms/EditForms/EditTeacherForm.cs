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
    public partial class EditTeacherForm : Form
    {
        Form parentForm = null;
        int EditId;

        public EditTeacherForm(Form pparentForm, int editId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            EditId = editId;
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
            if (CoursesRequests.EditTeacher(EditId, nameBox.Text)==null)
                MessageBox.Show("Учитель не изменен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();
        }

        private void EditTeacherForm_Load(object sender, EventArgs e)
        {
            Teacher t = CoursesRequests.GetTeacher(EditId);
            if (t == null)
                Close();
            else
            {
                nameBox.Text = t.Name;
            }
        }
    }
}
