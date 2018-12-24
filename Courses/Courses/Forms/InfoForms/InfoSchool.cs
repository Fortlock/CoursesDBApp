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
    public partial class InfoSchool : Form
    {
        Form parentForm = null;
        School School;


        public InfoSchool(Form pparentForm, int schoolId)
        {
            InitializeComponent();
            parentForm = pparentForm;
            School = CoursesRequests.GetSchool(schoolId);
        }

        private void RefreshTab()
        {
            CoursesGridView.DataSource = School.Students;
            //if (TeachersGridView.RowCount == 0) CallDBTeacherForm.Enabled = false; else CallDBTeacherForm.Enabled = true;
        }

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            if (School == null)
                Close();
            else
            {
                nameLabel.Text = School.Name;
                RefreshTab();
            }
        }

        private void InfoSchool_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
                RefreshTab();
        }

        private void CoursesGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Enabled = false;
            InfoStudent infoStudent = new InfoStudent(this, (int)CoursesGridView.SelectedRows[0].Cells[0].Value);
            infoStudent.Show();
        }
    }
}
