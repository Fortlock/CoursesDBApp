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
    public partial class InfoSubject : Form
    {
        Form parentForm = null;
        Subject subject;


        public InfoSubject(Form pparentForm, int subjectId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            subject = CoursesRequests.GetSubject(subjectId);
        }

        private void RefreshTab()
        {
            CoursesGridView.DataSource = subject.Courses;
            //if (TeachersGridView.RowCount == 0) CallDBTeacherForm.Enabled = false; else CallDBTeacherForm.Enabled = true;
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            if (subject == null)
                Close();
            else
            {
                nameLabel.Text = subject.Name;
                RefreshTab();
            }
        }

        private void InfoSubject_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
                RefreshTab();
        }

        private void CoursesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabled = false;
            InfoCourseForm infoCourseForm = new InfoCourseForm(this, (int)CoursesGridView.SelectedRows[0].Cells[0].Value);
            infoCourseForm.Show();
        }
    }
}
