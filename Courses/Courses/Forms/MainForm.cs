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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CoursesEntities courses = new CoursesEntities();
            TeachersGridView.DataSource = courses.Teachers.ToList();
        }

        private void CallNTeacherForm_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm(this);
            addTeacherForm.Show();
            Enabled = false;
        }
    }
}
