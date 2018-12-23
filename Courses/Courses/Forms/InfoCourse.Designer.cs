namespace Courses
{
    partial class InfoCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TopicsPage = new System.Windows.Forms.TabPage();
            this.CallDTopicForm = new System.Windows.Forms.Button();
            this.CallNTopicForm = new System.Windows.Forms.Button();
            this.TopicsGridView = new System.Windows.Forms.DataGridView();
            this.TeachersPage = new System.Windows.Forms.TabPage();
            this.CallDBTeacherForm = new System.Windows.Forms.Button();
            this.CallBTeacherForm = new System.Windows.Forms.Button();
            this.TeachersGridView = new System.Windows.Forms.DataGridView();
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.CallDBStudentForm = new System.Windows.Forms.Button();
            this.CallBStudentForm = new System.Windows.Forms.Button();
            this.StudentsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectlabel = new System.Windows.Forms.Label();
            this.durationlabel = new System.Windows.Forms.Label();
            this.costlabel = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesTeachersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPaidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sertificateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesStudentsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.TopicsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopicsGridView)).BeginInit();
            this.TeachersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).BeginInit();
            this.StudentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesStudentsViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TopicsPage);
            this.tabControl.Controls.Add(this.TeachersPage);
            this.tabControl.Controls.Add(this.StudentsPage);
            this.tabControl.Location = new System.Drawing.Point(12, 51);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(398, 301);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // TopicsPage
            // 
            this.TopicsPage.Controls.Add(this.CallDTopicForm);
            this.TopicsPage.Controls.Add(this.CallNTopicForm);
            this.TopicsPage.Controls.Add(this.TopicsGridView);
            this.TopicsPage.Location = new System.Drawing.Point(4, 22);
            this.TopicsPage.Name = "TopicsPage";
            this.TopicsPage.Padding = new System.Windows.Forms.Padding(3);
            this.TopicsPage.Size = new System.Drawing.Size(390, 275);
            this.TopicsPage.TabIndex = 0;
            this.TopicsPage.Text = "Topics";
            this.TopicsPage.UseVisualStyleBackColor = true;
            // 
            // CallDTopicForm
            // 
            this.CallDTopicForm.Location = new System.Drawing.Point(138, 246);
            this.CallDTopicForm.Name = "CallDTopicForm";
            this.CallDTopicForm.Size = new System.Drawing.Size(125, 23);
            this.CallDTopicForm.TabIndex = 2;
            this.CallDTopicForm.Text = "Delete topic";
            this.CallDTopicForm.UseVisualStyleBackColor = true;
            this.CallDTopicForm.Click += new System.EventHandler(this.CallDelForm_Click);
            // 
            // CallNTopicForm
            // 
            this.CallNTopicForm.Location = new System.Drawing.Point(7, 246);
            this.CallNTopicForm.Name = "CallNTopicForm";
            this.CallNTopicForm.Size = new System.Drawing.Size(125, 23);
            this.CallNTopicForm.TabIndex = 1;
            this.CallNTopicForm.Text = "New topic";
            this.CallNTopicForm.UseVisualStyleBackColor = true;
            this.CallNTopicForm.Click += new System.EventHandler(this.CallNForm_Click);
            // 
            // TopicsGridView
            // 
            this.TopicsGridView.AllowUserToAddRows = false;
            this.TopicsGridView.AllowUserToDeleteRows = false;
            this.TopicsGridView.AutoGenerateColumns = false;
            this.TopicsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopicsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.courseIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.coursDataGridViewTextBoxColumn});
            this.TopicsGridView.DataSource = this.topicBindingSource;
            this.TopicsGridView.Location = new System.Drawing.Point(0, 0);
            this.TopicsGridView.MultiSelect = false;
            this.TopicsGridView.Name = "TopicsGridView";
            this.TopicsGridView.ReadOnly = true;
            this.TopicsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TopicsGridView.Size = new System.Drawing.Size(390, 240);
            this.TopicsGridView.TabIndex = 0;
            // 
            // TeachersPage
            // 
            this.TeachersPage.Controls.Add(this.CallDBTeacherForm);
            this.TeachersPage.Controls.Add(this.CallBTeacherForm);
            this.TeachersPage.Controls.Add(this.TeachersGridView);
            this.TeachersPage.Location = new System.Drawing.Point(4, 22);
            this.TeachersPage.Name = "TeachersPage";
            this.TeachersPage.Padding = new System.Windows.Forms.Padding(3);
            this.TeachersPage.Size = new System.Drawing.Size(390, 275);
            this.TeachersPage.TabIndex = 1;
            this.TeachersPage.Text = "Teachers";
            this.TeachersPage.UseVisualStyleBackColor = true;
            // 
            // CallDBTeacherForm
            // 
            this.CallDBTeacherForm.Location = new System.Drawing.Point(137, 246);
            this.CallDBTeacherForm.Name = "CallDBTeacherForm";
            this.CallDBTeacherForm.Size = new System.Drawing.Size(125, 23);
            this.CallDBTeacherForm.TabIndex = 2;
            this.CallDBTeacherForm.Text = "Delete bind";
            this.CallDBTeacherForm.UseVisualStyleBackColor = true;
            this.CallDBTeacherForm.Click += new System.EventHandler(this.CallDelForm_Click);
            // 
            // CallBTeacherForm
            // 
            this.CallBTeacherForm.Location = new System.Drawing.Point(6, 246);
            this.CallBTeacherForm.Name = "CallBTeacherForm";
            this.CallBTeacherForm.Size = new System.Drawing.Size(125, 23);
            this.CallBTeacherForm.TabIndex = 1;
            this.CallBTeacherForm.Text = "Bind teacher";
            this.CallBTeacherForm.UseVisualStyleBackColor = true;
            this.CallBTeacherForm.Click += new System.EventHandler(this.CallNForm_Click);
            // 
            // TeachersGridView
            // 
            this.TeachersGridView.AllowUserToAddRows = false;
            this.TeachersGridView.AllowUserToDeleteRows = false;
            this.TeachersGridView.AutoGenerateColumns = false;
            this.TeachersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.coursesTeachersDataGridViewTextBoxColumn});
            this.TeachersGridView.DataSource = this.teacherBindingSource;
            this.TeachersGridView.Location = new System.Drawing.Point(0, 0);
            this.TeachersGridView.MultiSelect = false;
            this.TeachersGridView.Name = "TeachersGridView";
            this.TeachersGridView.ReadOnly = true;
            this.TeachersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeachersGridView.Size = new System.Drawing.Size(390, 240);
            this.TeachersGridView.TabIndex = 0;
            // 
            // StudentsPage
            // 
            this.StudentsPage.Controls.Add(this.CallDBStudentForm);
            this.StudentsPage.Controls.Add(this.CallBStudentForm);
            this.StudentsPage.Controls.Add(this.StudentsGridView);
            this.StudentsPage.Location = new System.Drawing.Point(4, 22);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Size = new System.Drawing.Size(390, 275);
            this.StudentsPage.TabIndex = 2;
            this.StudentsPage.Text = "Students";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // CallDBStudentForm
            // 
            this.CallDBStudentForm.Location = new System.Drawing.Point(137, 246);
            this.CallDBStudentForm.Name = "CallDBStudentForm";
            this.CallDBStudentForm.Size = new System.Drawing.Size(125, 23);
            this.CallDBStudentForm.TabIndex = 2;
            this.CallDBStudentForm.Text = "Delete bind";
            this.CallDBStudentForm.UseVisualStyleBackColor = true;
            this.CallDBStudentForm.Click += new System.EventHandler(this.CallDelForm_Click);
            // 
            // CallBStudentForm
            // 
            this.CallBStudentForm.Location = new System.Drawing.Point(6, 246);
            this.CallBStudentForm.Name = "CallBStudentForm";
            this.CallBStudentForm.Size = new System.Drawing.Size(125, 23);
            this.CallBStudentForm.TabIndex = 1;
            this.CallBStudentForm.Text = "Bind student";
            this.CallBStudentForm.UseVisualStyleBackColor = true;
            this.CallBStudentForm.Click += new System.EventHandler(this.CallNForm_Click);
            // 
            // StudentsGridView
            // 
            this.StudentsGridView.AllowUserToAddRows = false;
            this.StudentsGridView.AllowUserToDeleteRows = false;
            this.StudentsGridView.AutoGenerateColumns = false;
            this.StudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.StudentId,
            this.nameDataGridViewTextBoxColumn2,
            this.isPaidDataGridViewCheckBoxColumn,
            this.sertificateNumberDataGridViewTextBoxColumn});
            this.StudentsGridView.DataSource = this.coursesStudentsViewBindingSource;
            this.StudentsGridView.Location = new System.Drawing.Point(0, 0);
            this.StudentsGridView.MultiSelect = false;
            this.StudentsGridView.Name = "StudentsGridView";
            this.StudentsGridView.ReadOnly = true;
            this.StudentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsGridView.Size = new System.Drawing.Size(390, 240);
            this.StudentsGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration(hours):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost:";
            // 
            // subjectlabel
            // 
            this.subjectlabel.AutoSize = true;
            this.subjectlabel.Location = new System.Drawing.Point(100, 9);
            this.subjectlabel.Name = "subjectlabel";
            this.subjectlabel.Size = new System.Drawing.Size(35, 13);
            this.subjectlabel.TabIndex = 4;
            this.subjectlabel.Text = "label4";
            // 
            // durationlabel
            // 
            this.durationlabel.AutoSize = true;
            this.durationlabel.Location = new System.Drawing.Point(100, 22);
            this.durationlabel.Name = "durationlabel";
            this.durationlabel.Size = new System.Drawing.Size(35, 13);
            this.durationlabel.TabIndex = 5;
            this.durationlabel.Text = "label5";
            // 
            // costlabel
            // 
            this.costlabel.AutoSize = true;
            this.costlabel.Location = new System.Drawing.Point(100, 35);
            this.costlabel.Name = "costlabel";
            this.costlabel.Size = new System.Drawing.Size(35, 13);
            this.costlabel.TabIndex = 6;
            this.costlabel.Text = "label6";
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursDataGridViewTextBoxColumn
            // 
            this.coursDataGridViewTextBoxColumn.DataPropertyName = "Cours";
            this.coursDataGridViewTextBoxColumn.HeaderText = "Cours";
            this.coursDataGridViewTextBoxColumn.Name = "coursDataGridViewTextBoxColumn";
            this.coursDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursDataGridViewTextBoxColumn.Visible = false;
            // 
            // topicBindingSource
            // 
            this.topicBindingSource.DataSource = typeof(Courses.DataModel.Topic);
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
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // isPaidDataGridViewCheckBoxColumn
            // 
            this.isPaidDataGridViewCheckBoxColumn.DataPropertyName = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.HeaderText = "IsPaid";
            this.isPaidDataGridViewCheckBoxColumn.Name = "isPaidDataGridViewCheckBoxColumn";
            this.isPaidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sertificateNumberDataGridViewTextBoxColumn
            // 
            this.sertificateNumberDataGridViewTextBoxColumn.DataPropertyName = "SertificateNumber";
            this.sertificateNumberDataGridViewTextBoxColumn.HeaderText = "SertificateNumber";
            this.sertificateNumberDataGridViewTextBoxColumn.Name = "sertificateNumberDataGridViewTextBoxColumn";
            this.sertificateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesStudentsViewBindingSource
            // 
            this.coursesStudentsViewBindingSource.DataSource = typeof(Courses.DataModel.CoursesStudentsView);
            // 
            // InfoCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 362);
            this.Controls.Add(this.costlabel);
            this.Controls.Add(this.durationlabel);
            this.Controls.Add(this.subjectlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Name = "InfoCourseForm";
            this.Text = "Info about course";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoCourse_FormClosed);
            this.Load += new System.EventHandler(this.InfoCourse_Load);
            this.EnabledChanged += new System.EventHandler(this.InfoCourseForm_EnabledChanged);
            this.tabControl.ResumeLayout(false);
            this.TopicsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopicsGridView)).EndInit();
            this.TeachersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).EndInit();
            this.StudentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesStudentsViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TopicsPage;
        private System.Windows.Forms.TabPage TeachersPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subjectlabel;
        private System.Windows.Forms.Label durationlabel;
        private System.Windows.Forms.Label costlabel;
        private System.Windows.Forms.TabPage StudentsPage;
        private System.Windows.Forms.DataGridView TopicsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource topicBindingSource;
        private System.Windows.Forms.DataGridView TeachersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesTeachersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridView StudentsGridView;
        private System.Windows.Forms.Button CallNTopicForm;
        private System.Windows.Forms.Button CallBTeacherForm;
        private System.Windows.Forms.Button CallBStudentForm;
        private System.Windows.Forms.Button CallDTopicForm;
        private System.Windows.Forms.Button CallDBTeacherForm;
        private System.Windows.Forms.Button CallDBStudentForm;
        private System.Windows.Forms.BindingSource coursesStudentsViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPaidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sertificateNumberDataGridViewTextBoxColumn;
    }
}