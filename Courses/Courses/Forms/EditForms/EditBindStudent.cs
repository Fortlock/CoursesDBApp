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
    public partial class EditBindStudent : Form
    {
        Form parentForm = null;
        int EditId;

        public EditBindStudent(Form pparentForm, int editId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            EditId = editId;
        }

        private void EditBindStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditBindStudent_Load(object sender, EventArgs e)
        {
            CourseStudent t = CoursesRequests.GetCourseStudent(EditId);
            if (t == null)
                Close();
            else
            {
                paidBox.Checked = t.IsPaid;
                sertBox.Text = t.SertificateNumber.ToString();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int? sert = null;
            int ser = 0;
            if (!Validator.SertificateNumber(sertBox.Text))
                MessageBox.Show("Неверный формат данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (int.TryParse(sertBox.Text, out ser))
                    sert = ser;
                try
                {
                    if (CoursesRequests.EditBindStudentToCourse(EditId, paidBox.Checked, sert) == null)
                        MessageBox.Show("Ошибка изменения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Шото сломалось", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
