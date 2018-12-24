namespace Courses
{
    partial class InfoSchool
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
            this.CoursesGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesGridView
            // 
            this.CoursesGridView.AllowUserToAddRows = false;
            this.CoursesGridView.AllowUserToDeleteRows = false;
            this.CoursesGridView.AutoGenerateColumns = false;
            this.CoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.groupNDataGridViewTextBoxColumn,
            this.schoolIdDataGridViewTextBoxColumn,
            this.coursesStudentsDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn});
            this.CoursesGridView.DataSource = this.studentBindingSource;
            this.CoursesGridView.Location = new System.Drawing.Point(12, 29);
            this.CoursesGridView.MultiSelect = false;
            this.CoursesGridView.Name = "CoursesGridView";
            this.CoursesGridView.ReadOnly = true;
            this.CoursesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoursesGridView.Size = new System.Drawing.Size(775, 409);
            this.CoursesGridView.TabIndex = 0;
            this.CoursesGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesGridView_CellDoubleClick);
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
            // groupNDataGridViewTextBoxColumn
            // 
            this.groupNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupNDataGridViewTextBoxColumn.DataPropertyName = "GroupN";
            this.groupNDataGridViewTextBoxColumn.HeaderText = "GroupN";
            this.groupNDataGridViewTextBoxColumn.Name = "groupNDataGridViewTextBoxColumn";
            this.groupNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolIdDataGridViewTextBoxColumn
            // 
            this.schoolIdDataGridViewTextBoxColumn.DataPropertyName = "SchoolId";
            this.schoolIdDataGridViewTextBoxColumn.HeaderText = "SchoolId";
            this.schoolIdDataGridViewTextBoxColumn.Name = "schoolIdDataGridViewTextBoxColumn";
            this.schoolIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.schoolIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // coursesStudentsDataGridViewTextBoxColumn
            // 
            this.coursesStudentsDataGridViewTextBoxColumn.DataPropertyName = "CoursesStudents";
            this.coursesStudentsDataGridViewTextBoxColumn.HeaderText = "CoursesStudents";
            this.coursesStudentsDataGridViewTextBoxColumn.Name = "coursesStudentsDataGridViewTextBoxColumn";
            this.coursesStudentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursesStudentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "School";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.schoolDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Courses.DataModel.Student);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(58, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label2";
            // 
            // InfoSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoursesGridView);
            this.Name = "InfoSchool";
            this.Text = "InfoSchool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Info_FormClosed);
            this.Load += new System.EventHandler(this.Info_Load);
            this.EnabledChanged += new System.EventHandler(this.InfoSchool_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CoursesGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}