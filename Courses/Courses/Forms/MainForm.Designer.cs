namespace Courses
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TeachersPage = new System.Windows.Forms.TabPage();
            this.CallNTeacherForm = new System.Windows.Forms.Button();
            this.TeachersGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SchoolsPage = new System.Windows.Forms.TabPage();
            this.CallNSchoolForm = new System.Windows.Forms.Button();
            this.SchoolsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubjectsPage = new System.Windows.Forms.TabPage();
            this.CallNSubjectForm = new System.Windows.Forms.Button();
            this.SubjectsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.CallNStudentForm = new System.Windows.Forms.Button();
            this.StudentsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.CoursesPage = new System.Windows.Forms.TabPage();
            this.CallNCourseForm = new System.Windows.Forms.Button();
            this.CoursesGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.TeachersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SchoolsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            this.SubjectsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.StudentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewBindingSource2)).BeginInit();
            this.CoursesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TeachersPage);
            this.tabControl.Controls.Add(this.SchoolsPage);
            this.tabControl.Controls.Add(this.SubjectsPage);
            this.tabControl.Controls.Add(this.StudentsPage);
            this.tabControl.Controls.Add(this.CoursesPage);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 425);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // TeachersPage
            // 
            this.TeachersPage.Controls.Add(this.CallNTeacherForm);
            this.TeachersPage.Controls.Add(this.TeachersGridView);
            this.TeachersPage.Location = new System.Drawing.Point(4, 22);
            this.TeachersPage.Name = "TeachersPage";
            this.TeachersPage.Padding = new System.Windows.Forms.Padding(3);
            this.TeachersPage.Size = new System.Drawing.Size(767, 399);
            this.TeachersPage.TabIndex = 0;
            this.TeachersPage.Text = "Teachers";
            this.TeachersPage.UseVisualStyleBackColor = true;
            // 
            // CallNTeacherForm
            // 
            this.CallNTeacherForm.Location = new System.Drawing.Point(3, 373);
            this.CallNTeacherForm.Name = "CallNTeacherForm";
            this.CallNTeacherForm.Size = new System.Drawing.Size(121, 23);
            this.CallNTeacherForm.TabIndex = 1;
            this.CallNTeacherForm.Text = "New teacher";
            this.CallNTeacherForm.UseVisualStyleBackColor = true;
            this.CallNTeacherForm.Click += new System.EventHandler(this.CallAddForm_Click);
            // 
            // TeachersGridView
            // 
            this.TeachersGridView.AllowUserToAddRows = false;
            this.TeachersGridView.AllowUserToDeleteRows = false;
            this.TeachersGridView.AutoGenerateColumns = false;
            this.TeachersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.TeachersGridView.DataSource = this.teacherBindingSource;
            this.TeachersGridView.Location = new System.Drawing.Point(0, 0);
            this.TeachersGridView.MultiSelect = false;
            this.TeachersGridView.Name = "TeachersGridView";
            this.TeachersGridView.ReadOnly = true;
            this.TeachersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeachersGridView.Size = new System.Drawing.Size(767, 367);
            this.TeachersGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Courses.DataModel.Teacher);
            // 
            // SchoolsPage
            // 
            this.SchoolsPage.Controls.Add(this.CallNSchoolForm);
            this.SchoolsPage.Controls.Add(this.SchoolsGridView);
            this.SchoolsPage.Location = new System.Drawing.Point(4, 22);
            this.SchoolsPage.Name = "SchoolsPage";
            this.SchoolsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SchoolsPage.Size = new System.Drawing.Size(767, 399);
            this.SchoolsPage.TabIndex = 1;
            this.SchoolsPage.Text = "Schools";
            this.SchoolsPage.UseVisualStyleBackColor = true;
            // 
            // CallNSchoolForm
            // 
            this.CallNSchoolForm.Location = new System.Drawing.Point(3, 373);
            this.CallNSchoolForm.Name = "CallNSchoolForm";
            this.CallNSchoolForm.Size = new System.Drawing.Size(119, 23);
            this.CallNSchoolForm.TabIndex = 1;
            this.CallNSchoolForm.Text = "New school";
            this.CallNSchoolForm.UseVisualStyleBackColor = true;
            this.CallNSchoolForm.Click += new System.EventHandler(this.CallAddForm_Click);
            // 
            // SchoolsGridView
            // 
            this.SchoolsGridView.AllowUserToAddRows = false;
            this.SchoolsGridView.AllowUserToDeleteRows = false;
            this.SchoolsGridView.AutoGenerateColumns = false;
            this.SchoolsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.SchoolsGridView.DataSource = this.schoolBindingSource;
            this.SchoolsGridView.Location = new System.Drawing.Point(0, 0);
            this.SchoolsGridView.MultiSelect = false;
            this.SchoolsGridView.Name = "SchoolsGridView";
            this.SchoolsGridView.ReadOnly = true;
            this.SchoolsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SchoolsGridView.Size = new System.Drawing.Size(767, 367);
            this.SchoolsGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataSource = typeof(Courses.DataModel.School);
            // 
            // SubjectsPage
            // 
            this.SubjectsPage.Controls.Add(this.CallNSubjectForm);
            this.SubjectsPage.Controls.Add(this.SubjectsGridView);
            this.SubjectsPage.Location = new System.Drawing.Point(4, 22);
            this.SubjectsPage.Name = "SubjectsPage";
            this.SubjectsPage.Size = new System.Drawing.Size(767, 399);
            this.SubjectsPage.TabIndex = 2;
            this.SubjectsPage.Text = "Subjects";
            this.SubjectsPage.UseVisualStyleBackColor = true;
            // 
            // CallNSubjectForm
            // 
            this.CallNSubjectForm.Location = new System.Drawing.Point(3, 373);
            this.CallNSubjectForm.Name = "CallNSubjectForm";
            this.CallNSubjectForm.Size = new System.Drawing.Size(128, 23);
            this.CallNSubjectForm.TabIndex = 1;
            this.CallNSubjectForm.Text = "New subject";
            this.CallNSubjectForm.UseVisualStyleBackColor = true;
            this.CallNSubjectForm.Click += new System.EventHandler(this.CallAddForm_Click);
            // 
            // SubjectsGridView
            // 
            this.SubjectsGridView.AllowUserToAddRows = false;
            this.SubjectsGridView.AllowUserToDeleteRows = false;
            this.SubjectsGridView.AutoGenerateColumns = false;
            this.SubjectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2});
            this.SubjectsGridView.DataSource = this.subjectBindingSource;
            this.SubjectsGridView.Location = new System.Drawing.Point(0, 0);
            this.SubjectsGridView.MultiSelect = false;
            this.SubjectsGridView.Name = "SubjectsGridView";
            this.SubjectsGridView.ReadOnly = true;
            this.SubjectsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubjectsGridView.Size = new System.Drawing.Size(767, 367);
            this.SubjectsGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Courses.DataModel.Subject);
            // 
            // StudentsPage
            // 
            this.StudentsPage.Controls.Add(this.CallNStudentForm);
            this.StudentsPage.Controls.Add(this.StudentsGridView);
            this.StudentsPage.Location = new System.Drawing.Point(4, 22);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Size = new System.Drawing.Size(767, 399);
            this.StudentsPage.TabIndex = 3;
            this.StudentsPage.Text = "Students";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // CallNStudentForm
            // 
            this.CallNStudentForm.Location = new System.Drawing.Point(4, 373);
            this.CallNStudentForm.Name = "CallNStudentForm";
            this.CallNStudentForm.Size = new System.Drawing.Size(112, 23);
            this.CallNStudentForm.TabIndex = 1;
            this.CallNStudentForm.Text = "New student";
            this.CallNStudentForm.UseVisualStyleBackColor = true;
            this.CallNStudentForm.Click += new System.EventHandler(this.CallAddForm_Click);
            // 
            // StudentsGridView
            // 
            this.StudentsGridView.AllowUserToAddRows = false;
            this.StudentsGridView.AllowUserToDeleteRows = false;
            this.StudentsGridView.AutoGenerateColumns = false;
            this.StudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn3,
            this.groupNDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn});
            this.StudentsGridView.DataSource = this.studentViewBindingSource2;
            this.StudentsGridView.Location = new System.Drawing.Point(0, 0);
            this.StudentsGridView.MultiSelect = false;
            this.StudentsGridView.Name = "StudentsGridView";
            this.StudentsGridView.ReadOnly = true;
            this.StudentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsGridView.Size = new System.Drawing.Size(767, 367);
            this.StudentsGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupNDataGridViewTextBoxColumn
            // 
            this.groupNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupNDataGridViewTextBoxColumn.DataPropertyName = "GroupN";
            this.groupNDataGridViewTextBoxColumn.HeaderText = "GroupN";
            this.groupNDataGridViewTextBoxColumn.Name = "groupNDataGridViewTextBoxColumn";
            this.groupNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "School";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentViewBindingSource2
            // 
            this.studentViewBindingSource2.DataSource = typeof(Courses.DataModel.StudentView);
            // 
            // CoursesPage
            // 
            this.CoursesPage.Controls.Add(this.CallNCourseForm);
            this.CoursesPage.Controls.Add(this.CoursesGridView);
            this.CoursesPage.Location = new System.Drawing.Point(4, 22);
            this.CoursesPage.Name = "CoursesPage";
            this.CoursesPage.Size = new System.Drawing.Size(767, 399);
            this.CoursesPage.TabIndex = 4;
            this.CoursesPage.Text = "Courses";
            this.CoursesPage.UseVisualStyleBackColor = true;
            // 
            // CallNCourseForm
            // 
            this.CallNCourseForm.Location = new System.Drawing.Point(4, 373);
            this.CallNCourseForm.Name = "CallNCourseForm";
            this.CallNCourseForm.Size = new System.Drawing.Size(136, 23);
            this.CallNCourseForm.TabIndex = 1;
            this.CallNCourseForm.Text = "New course";
            this.CallNCourseForm.UseVisualStyleBackColor = true;
            this.CallNCourseForm.Click += new System.EventHandler(this.CallAddForm_Click);
            // 
            // CoursesGridView
            // 
            this.CoursesGridView.AllowUserToAddRows = false;
            this.CoursesGridView.AllowUserToDeleteRows = false;
            this.CoursesGridView.AutoGenerateColumns = false;
            this.CoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn4,
            this.durationDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.CoursesGridView.DataSource = this.coursesViewBindingSource;
            this.CoursesGridView.Location = new System.Drawing.Point(0, 0);
            this.CoursesGridView.MultiSelect = false;
            this.CoursesGridView.Name = "CoursesGridView";
            this.CoursesGridView.ReadOnly = true;
            this.CoursesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoursesGridView.Size = new System.Drawing.Size(767, 367);
            this.CoursesGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            this.nameDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesViewBindingSource
            // 
            this.coursesViewBindingSource.DataSource = typeof(Courses.DataModel.CourseView);
            // 
            // studentViewBindingSource
            // 
            this.studentViewBindingSource.DataSource = typeof(Courses.DataModel.StudentView);
            // 
            // studentViewBindingSource1
            // 
            this.studentViewBindingSource1.DataSource = typeof(Courses.DataModel.StudentView);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "CoursesEditor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnabledChanged += new System.EventHandler(this.MainForm_EnabledChanged);
            this.tabControl.ResumeLayout(false);
            this.TeachersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.SchoolsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            this.SubjectsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.StudentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewBindingSource2)).EndInit();
            this.CoursesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TeachersPage;
        private System.Windows.Forms.TabPage SchoolsPage;
        private System.Windows.Forms.DataGridView TeachersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.Button CallNTeacherForm;
        private System.Windows.Forms.Button CallNSchoolForm;
        private System.Windows.Forms.DataGridView SchoolsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private System.Windows.Forms.TabPage SubjectsPage;
        private System.Windows.Forms.Button CallNSubjectForm;
        private System.Windows.Forms.DataGridView SubjectsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.TabPage StudentsPage;
        private System.Windows.Forms.DataGridView StudentsGridView;
        private System.Windows.Forms.Button CallNStudentForm;
        private System.Windows.Forms.TabPage CoursesPage;
        private System.Windows.Forms.BindingSource studentViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentViewBindingSource2;
        private System.Windows.Forms.BindingSource studentViewBindingSource1;
        private System.Windows.Forms.Button CallNCourseForm;
        private System.Windows.Forms.DataGridView CoursesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource coursesViewBindingSource;
    }
}

