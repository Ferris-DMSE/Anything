namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Students = new System.Windows.Forms.GroupBox();
            this.StudentListView = new System.Windows.Forms.ListView();
            this.Courses = new System.Windows.Forms.GroupBox();
            this.CoursesListView = new System.Windows.Forms.ListView();
            this.CourseID = new System.Windows.Forms.Label();
            this.CourseNumber = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.CourseType = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenEdCompletion = new System.Windows.Forms.Label();
            this.CoreCompletion = new System.Windows.Forms.Label();
            this.ElectiveCompletion = new System.Windows.Forms.Label();
            this.Students.SuspendLayout();
            this.Courses.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.Controls.Add(this.StudentListView);
            this.Students.Location = new System.Drawing.Point(9, 10);
            this.Students.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Students.Size = new System.Drawing.Size(252, 444);
            this.Students.TabIndex = 0;
            this.Students.TabStop = false;
            this.Students.Text = "Students";
            // 
            // StudentListView
            // 
            this.StudentListView.Location = new System.Drawing.Point(4, 17);
            this.StudentListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentListView.MultiSelect = false;
            this.StudentListView.Name = "StudentListView";
            this.StudentListView.Size = new System.Drawing.Size(244, 422);
            this.StudentListView.TabIndex = 0;
            this.StudentListView.UseCompatibleStateImageBehavior = false;
            this.StudentListView.SelectedIndexChanged += new System.EventHandler(this.StudentListView_SelectedIndexChanged);
            // 
            // Courses
            // 
            this.Courses.Controls.Add(this.CoursesListView);
            this.Courses.Location = new System.Drawing.Point(266, 10);
            this.Courses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Courses.Name = "Courses";
            this.Courses.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Courses.Size = new System.Drawing.Size(202, 301);
            this.Courses.TabIndex = 1;
            this.Courses.TabStop = false;
            this.Courses.Text = "Courses";
            // 
            // CoursesListView
            // 
            this.CoursesListView.LabelWrap = false;
            this.CoursesListView.Location = new System.Drawing.Point(4, 17);
            this.CoursesListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CoursesListView.MultiSelect = false;
            this.CoursesListView.Name = "CoursesListView";
            this.CoursesListView.Size = new System.Drawing.Size(194, 280);
            this.CoursesListView.TabIndex = 0;
            this.CoursesListView.UseCompatibleStateImageBehavior = false;
            this.CoursesListView.SelectedIndexChanged += new System.EventHandler(this.CoursesListView_SelectedIndexChanged);
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(261, 314);
            this.CourseID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(60, 13);
            this.CourseID.TabIndex = 2;
            this.CourseID.Text = "Course ID: ";
            // 
            // CourseNumber
            // 
            this.CourseNumber.AutoSize = true;
            this.CourseNumber.Location = new System.Drawing.Point(261, 327);
            this.CourseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.Size = new System.Drawing.Size(86, 13);
            this.CourseNumber.TabIndex = 2;
            this.CourseNumber.Text = "Course Number: ";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(261, 355);
            this.Credits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(45, 13);
            this.Credits.TabIndex = 2;
            this.Credits.Text = "Credits: ";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(261, 369);
            this.Semester.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(57, 13);
            this.Semester.TabIndex = 2;
            this.Semester.Text = "Semester: ";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(261, 383);
            this.Year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(35, 13);
            this.Year.TabIndex = 2;
            this.Year.Text = "Year: ";
            // 
            // CourseType
            // 
            this.CourseType.AutoSize = true;
            this.CourseType.Location = new System.Drawing.Point(261, 396);
            this.CourseType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseType.Name = "CourseType";
            this.CourseType.Size = new System.Drawing.Size(73, 13);
            this.CourseType.TabIndex = 2;
            this.CourseType.Text = "Course Type: ";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(261, 341);
            this.Grade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(42, 13);
            this.Grade.TabIndex = 2;
            this.Grade.Text = "Grade: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Completion";
            // 
            // GenEdCompletion
            // 
            this.GenEdCompletion.AutoSize = true;
            this.GenEdCompletion.Location = new System.Drawing.Point(7, 473);
            this.GenEdCompletion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenEdCompletion.Name = "GenEdCompletion";
            this.GenEdCompletion.Size = new System.Drawing.Size(63, 13);
            this.GenEdCompletion.TabIndex = 4;
            this.GenEdCompletion.Text = "Gen Ed: 0%";
            // 
            // CoreCompletion
            // 
            this.CoreCompletion.AutoSize = true;
            this.CoreCompletion.Location = new System.Drawing.Point(84, 473);
            this.CoreCompletion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoreCompletion.Name = "CoreCompletion";
            this.CoreCompletion.Size = new System.Drawing.Size(49, 13);
            this.CoreCompletion.TabIndex = 4;
            this.CoreCompletion.Text = "Core: 0%";
            // 
            // ElectiveCompletion
            // 
            this.ElectiveCompletion.AutoSize = true;
            this.ElectiveCompletion.Location = new System.Drawing.Point(148, 473);
            this.ElectiveCompletion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ElectiveCompletion.Name = "ElectiveCompletion";
            this.ElectiveCompletion.Size = new System.Drawing.Size(65, 13);
            this.ElectiveCompletion.TabIndex = 4;
            this.ElectiveCompletion.Text = "Elective: 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 494);
            this.Controls.Add(this.ElectiveCompletion);
            this.Controls.Add(this.CoreCompletion);
            this.Controls.Add(this.GenEdCompletion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.CourseType);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.CourseNumber);
            this.Controls.Add(this.CourseID);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.Students);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Students.ResumeLayout(false);
            this.Courses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Students;
        private System.Windows.Forms.GroupBox Courses;
        private System.Windows.Forms.ListView CoursesListView;
        private System.Windows.Forms.Label CourseID;
        private System.Windows.Forms.Label CourseNumber;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label CourseType;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.ListView StudentListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GenEdCompletion;
        private System.Windows.Forms.Label CoreCompletion;
        private System.Windows.Forms.Label ElectiveCompletion;
    }
}

