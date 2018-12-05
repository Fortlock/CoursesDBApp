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
            this.SchoolsPage = new System.Windows.Forms.TabPage();
            this.CallNSchoolForm = new System.Windows.Forms.Button();
            this.SchoolsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubjectsPage = new System.Windows.Forms.TabPage();
            this.SubjectsGridView = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallNSubjectForm = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.TeachersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).BeginInit();
            this.SchoolsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            this.SubjectsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TeachersPage);
            this.tabControl.Controls.Add(this.SchoolsPage);
            this.tabControl.Controls.Add(this.SubjectsPage);
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
            this.TeachersGridView.AutoGenerateColumns = false;
            this.TeachersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.TeachersGridView.DataSource = this.teacherBindingSource;
            this.TeachersGridView.Location = new System.Drawing.Point(0, 0);
            this.TeachersGridView.Name = "TeachersGridView";
            this.TeachersGridView.Size = new System.Drawing.Size(767, 367);
            this.TeachersGridView.TabIndex = 0;
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
            this.SchoolsGridView.AutoGenerateColumns = false;
            this.SchoolsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.SchoolsGridView.DataSource = this.schoolBindingSource;
            this.SchoolsGridView.Location = new System.Drawing.Point(0, 0);
            this.SchoolsGridView.Name = "SchoolsGridView";
            this.SchoolsGridView.Size = new System.Drawing.Size(767, 367);
            this.SchoolsGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Courses.DataModel.Teacher);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
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
            // SubjectsGridView
            // 
            this.SubjectsGridView.AutoGenerateColumns = false;
            this.SubjectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2});
            this.SubjectsGridView.DataSource = this.subjectBindingSource;
            this.SubjectsGridView.Location = new System.Drawing.Point(0, 0);
            this.SubjectsGridView.Name = "SubjectsGridView";
            this.SubjectsGridView.Size = new System.Drawing.Size(767, 367);
            this.SubjectsGridView.TabIndex = 0;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Courses.DataModel.Subject);
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
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
            this.SchoolsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            this.SubjectsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
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
    }
}

