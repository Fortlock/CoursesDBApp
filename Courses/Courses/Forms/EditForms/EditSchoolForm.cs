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
    public partial class EditSchoolForm : Form
    {
        Form parentForm = null;
        int EditId;

        public EditSchoolForm(Form pparentForm, int editId)
        {
            InitializeComponent();
            EditId = editId;
            parentForm = pparentForm;
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
            if (CoursesRequests.EditSchool(EditId, nameBox.Text) == null)
                MessageBox.Show("Школа не изменена", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Close();
        }

        private void EditSchoolForm_Load(object sender, EventArgs e)
        {
            School t = CoursesRequests.GetSchool(EditId);
            if (t == null)
                Close();
            else
            {
                nameBox.Text = t.Name;
            }
        }
    }
}
