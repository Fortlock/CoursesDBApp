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
    public partial class EditStudentForm : Form
    {
        Form parentForm = null;
        int EditId;

        public EditStudentForm(Form pparentForm, int editId)
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
            string name = nameBox.Text;
            int group = 0;
            if (!Validator.Group(groupBox.Text) || !int.TryParse(groupBox.Text, out group))
            {
                MessageBox.Show("Неверный формат данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (CoursesRequests.EditStudent(EditId, nameBox.Text, group, (int)schoolBox.SelectedValue) == null)
                        MessageBox.Show("Cтудент не изменен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Шото сломалось", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            Student t = CoursesRequests.GetStudent(EditId);
            if (t == null)
                Close();
            else
            {
                nameBox.Text = t.Name;
                groupBox.Text = t.GroupN.ToString();
                schoolBox.DisplayMember = "Name";
                schoolBox.ValueMember = "Id";
                schoolBox.DataSource = CoursesRequests.GetSchools();
                if (t.SchoolId!=null)
                schoolBox.SelectedValue = t.SchoolId;
            }
            
        }
    }
}
