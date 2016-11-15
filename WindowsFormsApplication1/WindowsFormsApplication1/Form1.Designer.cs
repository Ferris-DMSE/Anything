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
            this.Students.Location = new System.Drawing.Point(12, 12);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(336, 546);
            this.Students.TabIndex = 0;
            this.Students.TabStop = false;
            this.Students.Text = "Students";
            // 
            // StudentListView
            // 
            this.StudentListView.Location = new System.Drawing.Point(6, 21);
            this.StudentListView.Name = "StudentListView";
            this.StudentListView.Size = new System.Drawing.Size(324, 519);
            this.StudentListView.TabIndex = 0;
            this.StudentListView.UseCompatibleStateImageBehavior = false;
            this.StudentListView.SelectedIndexChanged += new System.EventHandler(this.StudentListView_SelectedIndexChanged);
            // 
            // Courses
            // 
            this.Courses.Controls.Add(this.CoursesListView);
            this.Courses.Location = new System.Drawing.Point(354, 12);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(269, 371);
            this.Courses.TabIndex = 1;
            this.Courses.TabStop = false;
            this.Courses.Text = "Courses";
            // 
            // CoursesListView
            // 
            this.CoursesListView.Location = new System.Drawing.Point(6, 21);
            this.CoursesListView.Name = "CoursesListView";
            this.CoursesListView.Size = new System.Drawing.Size(257, 344);
            this.CoursesListView.TabIndex = 0;
            this.CoursesListView.UseCompatibleStateImageBehavior = false;
            this.CoursesListView.SelectedIndexChanged += new System.EventHandler(this.CoursesListView_SelectedIndexChanged);
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(348, 386);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(78, 17);
            this.CourseID.TabIndex = 2;
            this.CourseID.Text = "Course ID: ";
            // 
            // CourseNumber
            // 
            this.CourseNumber.AutoSize = true;
            this.CourseNumber.Location = new System.Drawing.Point(348, 403);
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.Size = new System.Drawing.Size(115, 17);
            this.CourseNumber.TabIndex = 2;
            this.CourseNumber.Text = "Course Number: ";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(348, 437);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(60, 17);
            this.Credits.TabIndex = 2;
            this.Credits.Text = "Credits: ";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(348, 454);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(76, 17);
            this.Semester.TabIndex = 2;
            this.Semester.Text = "Semester: ";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(348, 471);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(46, 17);
            this.Year.TabIndex = 2;
            this.Year.Text = "Year: ";
            // 
            // CourseType
            // 
            this.CourseType.AutoSize = true;
            this.CourseType.Location = new System.Drawing.Point(348, 488);
            this.CourseType.Name = "CourseType";
            this.CourseType.Size = new System.Drawing.Size(97, 17);
            this.CourseType.TabIndex = 2;
            this.CourseType.Text = "Course Type: ";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(348, 420);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(56, 17);
            this.Grade.TabIndex = 2;
            this.Grade.Text = "Grade: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Completion";
            // 
            // GenEdCompletion
            // 
            this.GenEdCompletion.AutoSize = true;
            this.GenEdCompletion.Location = new System.Drawing.Point(9, 582);
            this.GenEdCompletion.Name = "GenEdCompletion";
            this.GenEdCompletion.Size = new System.Drawing.Size(84, 17);
            this.GenEdCompletion.TabIndex = 4;
            this.GenEdCompletion.Text = "Gen Ed: 0%";
            // 
            // CoreCompletion
            // 
            this.CoreCompletion.AutoSize = true;
            this.CoreCompletion.Location = new System.Drawing.Point(112, 582);
            this.CoreCompletion.Name = "CoreCompletion";
            this.CoreCompletion.Size = new System.Drawing.Size(66, 17);
            this.CoreCompletion.TabIndex = 4;
            this.CoreCompletion.Text = "Core: 0%";
            // 
            // ElectiveCompletion
            // 
            this.ElectiveCompletion.AutoSize = true;
            this.ElectiveCompletion.Location = new System.Drawing.Point(197, 582);
            this.ElectiveCompletion.Name = "ElectiveCompletion";
            this.ElectiveCompletion.Size = new System.Drawing.Size(85, 17);
            this.ElectiveCompletion.TabIndex = 4;
            this.ElectiveCompletion.Text = "Elective: 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 608);
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
            this.Name = "Form1";
            this.Text = "Form1";
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

