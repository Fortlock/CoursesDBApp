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
    public partial class AddStudentForm : Form
    {
        Form parentForm = null;
        public AddStudentForm(Form pparentForm)
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
            string name = nameBox.Text;
            int group = 0;
            if (int.TryParse(groupBox.Text,out group) && group>0 && group<=12)
            {
                try
                {
                    CoursesRequests.AddStudent(nameBox.Text, group, (int)schoolBox.SelectedValue);
                }
                catch (Exception){}
            }
            Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            schoolBox.DisplayMember = "Name";
            schoolBox.ValueMember = "Id";
            schoolBox.DataSource = CoursesRequests.GetSchools();
        }
    }
}
