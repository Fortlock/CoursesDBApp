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
    public partial class EditSubjectForm : Form
    {
        Form parentForm = null;
        int EditId;
        public EditSubjectForm(Form pparentForm, int editId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            EditId = editId;
        }

        private void AddSchoolForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (CoursesRequests.EditSubject(EditId, nameBox.Text) == null)
                MessageBox.Show("Предмет не изменен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();
        }

        private void EditSubjectForm_Load(object sender, EventArgs e)
        {
            Subject t = CoursesRequests.GetSubject(EditId);
            if (t == null)
                Close();
            else
            {
                nameBox.Text = t.Name;
            }
        }
    }
}
