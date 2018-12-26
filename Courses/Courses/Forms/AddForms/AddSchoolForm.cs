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
    public partial class AddSchoolForm : Form
    {
        Form parentForm = null;
        public AddSchoolForm(Form pparentForm)
        {
            InitializeComponent();
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
            if (Validator.Name(nameBox.Text))
            {
                if (CoursesRequests.AddSchool(nameBox.Text) == null)
                    MessageBox.Show("Школа не добавлена", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    Close();
            }
            else
                MessageBox.Show("Неверный формат данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
