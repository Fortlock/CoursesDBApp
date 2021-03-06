﻿namespace Courses
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
            this.findTeacherBox = new System.Windows.Forms.TextBox();
            this.CallETeacherForm = new System.Windows.Forms.Button();
            this.CallDTeacherForm = new System.Windows.Forms.Button();
            this.CallNTeacherForm = new System.Windows.Forms.Button();
            this.TeachersGridView = new System.Windows.Forms.DataGridView();
            this.SchoolsPage = new System.Windows.Forms.TabPage();
            this.findSchoolBox = new System.Windows.Forms.TextBox();
            this.CallESchoolForm = new System.Windows.Forms.Button();
            this.CallDSchoolForm = new System.Windows.Forms.Button();
            this.CallNSchoolForm = new System.Windows.Forms.Button();
            this.SchoolsGridView = new System.Windows.Forms.DataGridView();
            this.SubjectsPage = new System.Windows.Forms.TabPage();
            this.findSubjectBox = new System.Windows.Forms.TextBox();
            this.CallESubjectForm = new System.Windows.Forms.Button();
            this.CallDSubjectForm = new System.Windows.Forms.Button();
            this.CallNSubjectForm = new System.Windows.Forms.Button();
            this.SubjectsGridView = new System.Windows.Forms.DataGridView();
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.findStudentBox = new System.Windows.Forms.TextBox();
            this.CallEStudentForm = new System.Windows.Forms.Button();
            this.CallDStudentForm = new System.Windows.Forms.Button();
            this.CallNStudentForm = new System.Windows.Forms.Button();
            this.StudentsGridView = new System.Windows.Forms.DataGridView();
            this.CoursesPage = new System.Windows.Forms.TabPage();
            this.CallECourseForm = new System.Windows.Forms.Button();
            this.CallDCourseForm = new System.Windows.Forms.Button();
            this.CallNCourseForm = new System.Windows.Forms.Button();
            this.CoursesGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesTeachersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WhoLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.TeachersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).BeginInit();
            this.SchoolsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsGridView)).BeginInit();
            this.SubjectsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGridView)).BeginInit();
            this.StudentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).BeginInit();
            this.CoursesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TeachersPage);
            this.tabControl.Controls.Add(this.SchoolsPage);
            this.tabControl.Controls.Add(this.SubjectsPage);
            this.tabControl.Controls.Add(this.StudentsPage);
            this.tabControl.Controls.Add(this.CoursesPage);
            this.tabControl.Location = new System.Drawing.Point(13, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 425);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // TeachersPage
            // 
            this.TeachersPage.Controls.Add(this.findTeacherBox);
            this.TeachersPage.Controls.Add(this.CallETeacherForm);
            this.TeachersPage.Controls.Add(this.CallDTeacherForm);
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
            // findTeacherBox
            // 
            this.findTeacherBox.Location = new System.Drawing.Point(7, 7);
            this.findTeacherBox.Name = "findTeacherBox";
            this.findTeacherBox.Size = new System.Drawing.Size(252, 20);
            this.findTeacherBox.TabIndex = 4;
            this.findTeacherBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // CallETeacherForm
            // 
            this.CallETeacherForm.Location = new System.Drawing.Point(134, 373);
            this.CallETeacherForm.Name = "CallETeacherForm";
            this.CallETeacherForm.Size = new System.Drawing.Size(125, 23);
            this.CallETeacherForm.TabIndex = 3;
            this.CallETeacherForm.Text = "Edit teacher";
            this.CallETeacherForm.UseVisualStyleBackColor = true;
            this.CallETeacherForm.Click += new System.EventHandler(this.CallEditForm_Click);
            // 
            // CallDTeacherForm
            // 
            this.CallDTeacherForm.Location = new System.Drawing.Point(265, 373);
            this.CallDTeacherForm.Name = "CallDTeacherForm";
            this.CallDTeacherForm.Size = new System.Drawing.Size(125, 23);
            this.CallDTeacherForm.TabIndex = 2;
            this.CallDTeacherForm.Text = "Delete teacher";
            this.CallDTeacherForm.UseVisualStyleBackColor = true;
            this.CallDTeacherForm.Click += new System.EventHandler(this.CallDelForm_Click);
            // 
            // CallNTeacherForm
            // 
            this.CallNTeacherForm.Location = new System.Drawing.Point(3, 373);
            this.CallNTeacherForm.Name = "CallNTeacherForm";
            this.CallNTeacherForm.Size = new System.Drawing.Size(125, 23);
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
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.coursesTeachersDataGridViewTextBoxColumn});
            this.TeachersGridView.DataSource = this.teacherBindingSource;
            this.TeachersGridView.Location = new System.Drawing.Point(0, 33);
            this.TeachersGridView.MultiSelect = false;
            this.TeachersGridView.Name = "TeachersGridView";
            this.TeachersGridView.ReadOnly = true;
            this.TeachersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeachersGridView.Size = new System.Drawing.Size(767, 334);
            this.TeachersGridView.TabIndex = 0;
            this.TeachersGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            // 
            // SchoolsPage
            // 
            this.SchoolsPage.Controls.Add(this.findSchoolBox);
            this.SchoolsPage.Controls.Add(this.CallESchoolForm);
            this.SchoolsPage.Controls.Add(this.CallDSchoolForm);
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
            // findSchoolBox
            // 
            this.findSchoolBox.Location = new System.Drawing.Point(7, 7);
            this.findSchoolBox.Name = "findSchoolBox";
            this.findSchoolBox.Size = new System.Drawing.Size(252, 20);
            this.findSchoolBox.TabIndex = 4;
            this.findSchoolBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // CallESchoolForm
            // 
            this.CallESchoolForm.Location = new System.Drawing.Point(134, 373);
            this.CallESchoolForm.Name = "CallESchoolForm";
            this.CallESchoolForm.Size = new System.Drawing.Size(125, 23);
            this.CallESchoolForm.TabIndex = 3;
            this.CallESchoolForm.Text = "Edit school";
            this.CallESchoolForm.UseVisualStyleBackColor = true;
            this.CallESchoolForm.Click += new System.EventHandler(this.CallEditForm_Click);
            // 
            // CallDSchoolForm
            // 
            this.CallDSchoolForm.Location = new System.Drawing.Point(265, 373);
            this.CallDSchoolForm.Name = "CallDSchoolForm";
            this.CallDSchoolForm.Size = new System.Drawing.Size(125, 23);
            this.CallDSchoolForm.TabIndex = 2;
            this.CallDSchoolForm.Text = "Delete school";
            this.CallDSchoolForm.UseVisualStyleBackColor = true;
            this.CallDSchoolForm.Click += new System.EventHandler(this.CallDelForm_Click);
            // 
            // CallNSchoolForm
            // 
            this.CallNSchoolForm.Location = new System.Drawing.Point(3, 373);
            this.CallNSchoolForm.Name = "CallNSchoolForm";
            this.CallNSchoolForm.Size = new System.Drawing.Size(125, 23);
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
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.studentsDataGridViewTextBoxColumn});
            this.SchoolsGridView.DataSource = this.schoolBindingSource;
            this.SchoolsGridView.Location = new System.Drawing.Point(0, 33);
            this.SchoolsGridView.MultiSelect = false;
            this.SchoolsGridView.Name = "SchoolsGridView";
            this.SchoolsGridView.ReadOnly = true;
            this.SchoolsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SchoolsGridView.Size = new System.Drawing.Size(767, 334);
            this.SchoolsGridView.TabIndex = 0;
            this.SchoolsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            // 
            // SubjectsPage
            // 
            this.SubjectsPage.Controls.Add(this.findSubjectBox);
            this.SubjectsPage.Controls.Add(this.CallESubjectForm);
            this.SubjectsPage.Controls.Add(this.CallDSubjectForm);
            this.SubjectsPage.Controls.Add(this.CallNSubjectForm);
            this.SubjectsPage.Controls.Add(this.SubjectsGridView);
            this.SubjectsPage.Location = new System.Drawing.Point(4, 22);
            this.SubjectsPage.Name = "SubjectsPage";
            this.SubjectsPage.Size = new System.Drawing.Size(767, 399);
            this.SubjectsPage.TabIndex = 2;
            this.SubjectsPage.Text = "Subjects";
            this.SubjectsPage.UseVisualStyleBackColor = true;
            // 
            // findSubjectBox
            // 
            this.findSubjectBox.Location = new System.Drawing.Point(7, 7);
            this.findSubjectBox.Name = "findSubjectBox";
            this.findSubjectBox.Size = new System.Drawing.Size(252, 20);
            this.findSubjectBox.TabIndex = 4;
            this.findSubjectBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // CallESubjectForm
            // 
            this.CallESubjectForm.Location = new System.Drawing.Point(134, 373);
            this.CallESubjectForm.Name = "CallESubjectForm";
            this.CallESubjectForm.Size = new System.Drawing.Size(125, 23);
            this.CallESubjectForm.TabIndex = 3;
            this.CallESubjectForm.Text = "Edit subject";
            this.CallESubjectForm.UseVisualStyleBackColor = true;
            this.CallESubjectForm.Click += new System.EventHandler(this.CallEditForm_Click);
            // 
            // CallDSubjectForm
            // 
            this.CallDSubjectForm.Location = new System.Drawing.Point(265, 373);
            this.CallDSubjectForm.Name = "CallDSubjectForm";
            this.CallDSubjectForm.Size = new System.Drawing.Size(125, 23);
            this.CallDSubjectForm.TabIndex = 2;
            this.CallDSubjectForm.Text = "Delete subject";
            this.CallDSubjectForm.UseVisualStyleBackColor = true;
            this.CallDSubjectForm.Click += new System.EventHandler(this.CallDelForm_Click);
            // 
            // CallNSubjectForm
            // 
            this.CallNSubjectForm.Location = new System.Drawing.Point(3, 373);
            this.CallNSubjectForm.Name = "CallNSubjectForm";
            this.CallNSubjectForm.Size = new System.Drawing.Size(125, 23);
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
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.coursesDataGridViewTextBoxColumn});
            this.SubjectsGridView.DataSource = this.subjectBindingSource;
            this.SubjectsGridView.Location = new System.Drawing.Point(0, 33);
            this.SubjectsGridView.MultiSelect = false;
            this.SubjectsGridView.Name = "SubjectsGridView";
            this.SubjectsGridView.ReadOnly = true;
            this.SubjectsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubjectsGridView.Size = new System.Drawing.Size(767, 334);
            this.SubjectsGridView.TabIndex = 0;
            this.SubjectsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            // 
            // StudentsPage
            // 
            this.StudentsPage.Controls.Add(this.findStudentBox);
            this.StudentsPage.Controls.Add(this.CallEStudentForm);
            this.StudentsPage.Controls.Add(this.CallDStudentForm);
            this.StudentsPage.Controls.Add(this.CallNStudentForm);
            this.StudentsPage.Controls.Add(this.StudentsGridView);
            this.StudentsPage.Location = new System.Drawing.Point(4, 22);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Size = new System.Drawing.Size(767, 399);
            this.StudentsPage.TabIndex = 3;
            this.StudentsPage.Text = "Students";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // findStudentBox
            // 
            this.findStudentBox.Location = new System.Drawing.Point(7, 7);
            this.findStudentBox.Name = "findStudentBox";
            this.findStudentBox.Size = new System.Drawing.Size(253, 20);
            this.findStudentBox.TabIndex = 4;
            this.findStudentBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // CallEStudentForm
            // 
            this.CallEStudentForm.Location = new System.Drawing.Point(135, 373);
            this.CallEStudentForm.Name = "CallEStudentForm";
            this.CallEStudentForm.Size = new System.Drawing.Size(125, 23);
            this.CallEStudentForm.TabIndex = 3;
            this.CallEStudentForm.Text = "Edit student";
            this.CallEStudentForm.UseVisualStyleBackColor = true;
            this.CallEStudentForm.Click += new System.EventHandler(this.CallEditForm_Click);
            // 
            // CallDStudentForm
            // 
            this.CallDStudentForm.Location = new System.Drawing.Point(266, 373);
            this.CallDStudentForm.Name = "CallDStudentForm";
            this.CallDStudentForm.Size = new System.Drawing.Size(125, 23);
            this.CallDStudentForm.TabIndex = 2;
            this.CallDStudentForm.Text = "Delete student";
            this.CallDStudentForm.UseVisualStyleBackColor = true;
            this.CallDStudentForm.Click += new System.EventHandler(this.CallDelForm_Click);
            // 
            // CallNStudentForm
            // 
            this.CallNStudentForm.Location = new System.Drawing.Point(4, 373);
            this.CallNStudentForm.Name = "CallNStudentForm";
            this.CallNStudentForm.Size = new System.Drawing.Size(125, 23);
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
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn3,
            this.groupNDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn});
            this.StudentsGridView.DataSource = this.studentViewBindingSource;
            this.StudentsGridView.Location = new System.Drawing.Point(0, 33);
            this.StudentsGridView.MultiSelect = false;
            this.StudentsGridView.Name = "StudentsGridView";
            this.StudentsGridView.ReadOnly = true;
            this.StudentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsGridView.Size = new System.Drawing.Size(767, 334);
            this.StudentsGridView.TabIndex = 0;
            this.StudentsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            // 
            // CoursesPage
            // 
            this.CoursesPage.Controls.Add(this.CallECourseForm);
            this.CoursesPage.Controls.Add(this.CallDCourseForm);
            this.CoursesPage.Controls.Add(this.CallNCourseForm);
            this.CoursesPage.Controls.Add(this.CoursesGridView);
            this.CoursesPage.Location = new System.Drawing.Point(4, 22);
            this.CoursesPage.Name = "CoursesPage";
            this.CoursesPage.Size = new System.Drawing.Size(767, 399);
            this.CoursesPage.TabIndex = 4;
            this.CoursesPage.Text = "Courses";
            this.CoursesPage.UseVisualStyleBackColor = true;
            // 
            // CallECourseForm
            // 
            this.CallECourseForm.Location = new System.Drawing.Point(135, 373);
            this.CallECourseForm.Name = "CallECourseForm";
            this.CallECourseForm.Size = new System.Drawing.Size(125, 23);
            this.CallECourseForm.TabIndex = 3;
            this.CallECourseForm.Text = "Edit course";
            this.CallECourseForm.UseVisualStyleBackColor = true;
            this.CallECourseForm.Click += new System.EventHandler(this.CallEditForm_Click);
            // 
            // CallDCourseForm
            // 
            this.CallDCourseForm.Location = new System.Drawing.Point(266, 373);
            this.CallDCourseForm.Name = "CallDCourseForm";
            this.CallDCourseForm.Size = new System.Drawing.Size(125, 23);
            this.CallDCourseForm.TabIndex = 2;
            this.CallDCourseForm.Text = "Delete course";
            this.CallDCourseForm.UseVisualStyleBackColor = true;
            this.CallDCourseForm.Click += new System.EventHandler(this.CallDelForm_Click);
            // 
            // CallNCourseForm
            // 
            this.CallNCourseForm.Location = new System.Drawing.Point(4, 373);
            this.CallNCourseForm.Name = "CallNCourseForm";
            this.CallNCourseForm.Size = new System.Drawing.Size(125, 23);
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
            this.idDataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn4,
            this.durationDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.CoursesGridView.DataSource = this.courseViewBindingSource;
            this.CoursesGridView.Location = new System.Drawing.Point(0, 0);
            this.CoursesGridView.MultiSelect = false;
            this.CoursesGridView.Name = "CoursesGridView";
            this.CoursesGridView.ReadOnly = true;
            this.CoursesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoursesGridView.Size = new System.Drawing.Size(767, 367);
            this.CoursesGridView.TabIndex = 0;
            this.CoursesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesTeachersDataGridViewTextBoxColumn
            // 
            this.coursesTeachersDataGridViewTextBoxColumn.DataPropertyName = "CoursesTeachers";
            this.coursesTeachersDataGridViewTextBoxColumn.HeaderText = "CoursesTeachers";
            this.coursesTeachersDataGridViewTextBoxColumn.Name = "coursesTeachersDataGridViewTextBoxColumn";
            this.coursesTeachersDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursesTeachersDataGridViewTextBoxColumn.Visible = false;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Courses.DataModel.Teacher);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // studentsDataGridViewTextBoxColumn
            // 
            this.studentsDataGridViewTextBoxColumn.DataPropertyName = "Students";
            this.studentsDataGridViewTextBoxColumn.HeaderText = "Students";
            this.studentsDataGridViewTextBoxColumn.Name = "studentsDataGridViewTextBoxColumn";
            this.studentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataSource = typeof(Courses.DataModel.School);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            this.coursesDataGridViewTextBoxColumn.DataPropertyName = "Courses";
            this.coursesDataGridViewTextBoxColumn.HeaderText = "Courses";
            this.coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            this.coursesDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursesDataGridViewTextBoxColumn.Visible = false;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Courses.DataModel.Subject);
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Visible = false;
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
            // studentViewBindingSource
            // 
            this.studentViewBindingSource.DataSource = typeof(Courses.DataModel.StudentView);
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            this.idDataGridViewTextBoxColumn4.Visible = false;
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
            // courseViewBindingSource
            // 
            this.courseViewBindingSource.DataSource = typeof(Courses.DataModel.CourseView);
            // 
            // WhoLabel
            // 
            this.WhoLabel.AutoSize = true;
            this.WhoLabel.Location = new System.Drawing.Point(618, 4);
            this.WhoLabel.Name = "WhoLabel";
            this.WhoLabel.Size = new System.Drawing.Size(81, 13);
            this.WhoLabel.TabIndex = 1;
            this.WhoLabel.Text = "Вы вошли как ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.WhoLabel);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "CoursesEditor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnabledChanged += new System.EventHandler(this.MainForm_EnabledChanged);
            this.tabControl.ResumeLayout(false);
            this.TeachersPage.ResumeLayout(false);
            this.TeachersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).EndInit();
            this.SchoolsPage.ResumeLayout(false);
            this.SchoolsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsGridView)).EndInit();
            this.SubjectsPage.ResumeLayout(false);
            this.SubjectsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGridView)).EndInit();
            this.StudentsPage.ResumeLayout(false);
            this.StudentsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).EndInit();
            this.CoursesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TeachersPage;
        private System.Windows.Forms.TabPage SchoolsPage;
        private System.Windows.Forms.DataGridView TeachersGridView;
        private System.Windows.Forms.Button CallNTeacherForm;
        private System.Windows.Forms.Button CallNSchoolForm;
        private System.Windows.Forms.DataGridView SchoolsGridView;
        private System.Windows.Forms.TabPage SubjectsPage;
        private System.Windows.Forms.Button CallNSubjectForm;
        private System.Windows.Forms.DataGridView SubjectsGridView;
        private System.Windows.Forms.TabPage StudentsPage;
        private System.Windows.Forms.DataGridView StudentsGridView;
        private System.Windows.Forms.Button CallNStudentForm;
        private System.Windows.Forms.TabPage CoursesPage;
        private System.Windows.Forms.Button CallNCourseForm;
        private System.Windows.Forms.DataGridView CoursesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesTeachersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseViewBindingSource;
        private System.Windows.Forms.Button CallDTeacherForm;
        private System.Windows.Forms.Button CallDSchoolForm;
        private System.Windows.Forms.Button CallDSubjectForm;
        private System.Windows.Forms.Button CallDStudentForm;
        private System.Windows.Forms.Button CallDCourseForm;
        private System.Windows.Forms.Button CallETeacherForm;
        private System.Windows.Forms.Button CallESchoolForm;
        private System.Windows.Forms.Button CallESubjectForm;
        private System.Windows.Forms.Button CallEStudentForm;
        private System.Windows.Forms.Button CallECourseForm;
        private System.Windows.Forms.TextBox findTeacherBox;
        private System.Windows.Forms.TextBox findSchoolBox;
        private System.Windows.Forms.TextBox findSubjectBox;
        private System.Windows.Forms.TextBox findStudentBox;
        private System.Windows.Forms.Label WhoLabel;
    }
}

