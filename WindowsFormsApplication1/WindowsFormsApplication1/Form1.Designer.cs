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
            this.Courses = new System.Windows.Forms.GroupBox();
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
            this.CoursesListBox = new System.Windows.Forms.ListBox();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.Students.SuspendLayout();
            this.Courses.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.Controls.Add(this.StudentsListBox);
            this.Students.Location = new System.Drawing.Point(18, 19);
            this.Students.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Students.Size = new System.Drawing.Size(504, 853);
            this.Students.TabIndex = 0;
            this.Students.TabStop = false;
            this.Students.Text = "Students";
            // 
            // Courses
            // 
            this.Courses.Controls.Add(this.CoursesListBox);
            this.Courses.Location = new System.Drawing.Point(532, 19);
            this.Courses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Courses.Name = "Courses";
            this.Courses.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Courses.Size = new System.Drawing.Size(536, 578);
            this.Courses.TabIndex = 1;
            this.Courses.TabStop = false;
            this.Courses.Text = "Courses";
            // 
            // CourseID
            // 
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(522, 603);
            this.CourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(119, 25);
            this.CourseID.TabIndex = 2;
            this.CourseID.Text = "Course ID: ";
            // 
            // CourseNumber
            // 
            this.CourseNumber.AutoSize = true;
            this.CourseNumber.Location = new System.Drawing.Point(522, 628);
            this.CourseNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.Size = new System.Drawing.Size(174, 25);
            this.CourseNumber.TabIndex = 2;
            this.CourseNumber.Text = "Course Number: ";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(522, 683);
            this.Credits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(92, 25);
            this.Credits.TabIndex = 2;
            this.Credits.Text = "Credits: ";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(522, 709);
            this.Semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(115, 25);
            this.Semester.TabIndex = 2;
            this.Semester.Text = "Semester: ";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(522, 736);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(70, 25);
            this.Year.TabIndex = 2;
            this.Year.Text = "Year: ";
            // 
            // CourseType
            // 
            this.CourseType.AutoSize = true;
            this.CourseType.Location = new System.Drawing.Point(522, 761);
            this.CourseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseType.Name = "CourseType";
            this.CourseType.Size = new System.Drawing.Size(147, 25);
            this.CourseType.TabIndex = 2;
            this.CourseType.Text = "Course Type: ";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(522, 656);
            this.Grade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(83, 25);
            this.Grade.TabIndex = 2;
            this.Grade.Text = "Grade: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 877);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Completion";
            // 
            // GenEdCompletion
            // 
            this.GenEdCompletion.AutoSize = true;
            this.GenEdCompletion.Location = new System.Drawing.Point(14, 909);
            this.GenEdCompletion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenEdCompletion.Name = "GenEdCompletion";
            this.GenEdCompletion.Size = new System.Drawing.Size(127, 25);
            this.GenEdCompletion.TabIndex = 4;
            this.GenEdCompletion.Text = "Gen Ed: 0%";
            // 
            // CoreCompletion
            // 
            this.CoreCompletion.AutoSize = true;
            this.CoreCompletion.Location = new System.Drawing.Point(189, 909);
            this.CoreCompletion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CoreCompletion.Name = "CoreCompletion";
            this.CoreCompletion.Size = new System.Drawing.Size(101, 25);
            this.CoreCompletion.TabIndex = 4;
            this.CoreCompletion.Text = "Core: 0%";
            // 
            // ElectiveCompletion
            // 
            this.ElectiveCompletion.AutoSize = true;
            this.ElectiveCompletion.Location = new System.Drawing.Point(352, 909);
            this.ElectiveCompletion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElectiveCompletion.Name = "ElectiveCompletion";
            this.ElectiveCompletion.Size = new System.Drawing.Size(131, 25);
            this.ElectiveCompletion.TabIndex = 4;
            this.ElectiveCompletion.Text = "Elective: 0%";
            // 
            // CoursesListBox
            // 
            this.CoursesListBox.FormattingEnabled = true;
            this.CoursesListBox.ItemHeight = 25;
            this.CoursesListBox.Location = new System.Drawing.Point(7, 39);
            this.CoursesListBox.Name = "CoursesListBox";
            this.CoursesListBox.Size = new System.Drawing.Size(512, 529);
            this.CoursesListBox.TabIndex = 0;
            this.CoursesListBox.SelectedIndexChanged += new System.EventHandler(this.CoursesListView_SelectedIndexChanged);
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.ItemHeight = 25;
            this.StudentsListBox.Location = new System.Drawing.Point(7, 30);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(490, 829);
            this.StudentsListBox.TabIndex = 5;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentListView_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 950);
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
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.Label CourseID;
        private System.Windows.Forms.Label CourseNumber;
        private System.Windows.Forms.Label Credits;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label CourseType;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GenEdCompletion;
        private System.Windows.Forms.Label CoreCompletion;
        private System.Windows.Forms.Label ElectiveCompletion;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.ListBox CoursesListBox;
    }
}

