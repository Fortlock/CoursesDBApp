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
            if (int.TryParse(durationBox.Text,out duration) && decimal.TryParse(costBox.Text, out cost) && duration>0 && duration<=500 && cost>=0)
            {
                try
                {
                    CoursesRequests.AddCourse((int)subjectBox.SelectedValue, duration, cost);
                }
                catch (Exception){}
            }
            Close();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            subjectBox.DisplayMember = "Name";
            subjectBox.ValueMember = "Id";
            subjectBox.DataSource = CoursesRequests.GetSubjects();
        }
    }
}
