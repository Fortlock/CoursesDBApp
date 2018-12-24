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
    public partial class AddCourseForm : Form
    {
        Form parentForm = null;
        public AddCourseForm(Form pparentForm)
        {
            InitializeComponent();
            parentForm = pparentForm;
        }

        private void AddCourseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int duration = 0;
            decimal cost = 0;
            if (!Validator.Cost(costBox.Text) || !Validator.Duration(durationBox.Text) || 
                !int.TryParse(durationBox.Text, out duration) || !decimal.TryParse(costBox.Text, out cost))
                MessageBox.Show("Неверный формат данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (CoursesRequests.AddCourse((int)subjectBox.SelectedValue, duration, cost)==null)
                        MessageBox.Show("Такой курс уже есть", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Шото сломалось", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            subjectBox.DisplayMember = "Name";
            subjectBox.ValueMember = "Id";
            subjectBox.DataSource = CoursesRequests.GetSubjects();
        }
    }
}
