namespace OptionalLesson
{
    partial class StaticsForm
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
            this.LessonNumber = new System.Windows.Forms.Panel();
            this.lblLessonNum = new System.Windows.Forms.Label();
            this.lessonSum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.StudentNumber = new System.Windows.Forms.Label();
            this.lblTeacherNum = new System.Windows.Forms.Label();
            this.TeacherSum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.TeacherNumber = new System.Windows.Forms.Panel();
            this.LessonNumber.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TeacherNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // LessonNumber
            // 
            this.LessonNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.LessonNumber.Controls.Add(this.lblLessonNum);
            this.LessonNumber.Controls.Add(this.lessonSum);
            this.LessonNumber.Location = new System.Drawing.Point(603, 81);
            this.LessonNumber.Name = "LessonNumber";
            this.LessonNumber.Size = new System.Drawing.Size(171, 151);
            this.LessonNumber.TabIndex = 10;
            // 
            // lblLessonNum
            // 
            this.lblLessonNum.AutoSize = true;
            this.lblLessonNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLessonNum.Location = new System.Drawing.Point(14, 12);
            this.lblLessonNum.Name = "lblLessonNum";
            this.lblLessonNum.Size = new System.Drawing.Size(123, 60);
            this.lblLessonNum.TabIndex = 31;
            this.lblLessonNum.Text = "Toplam Ders \r\n\r\nSayısı";
            // 
            // lessonSum
            // 
            this.lessonSum.AutoSize = true;
            this.lessonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lessonSum.Location = new System.Drawing.Point(14, 104);
            this.lessonSum.Name = "lessonSum";
            this.lessonSum.Size = new System.Drawing.Size(29, 20);
            this.lessonSum.TabIndex = 32;
            this.lessonSum.Text = "00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblStudentNum);
            this.panel1.Controls.Add(this.StudentNumber);
            this.panel1.Location = new System.Drawing.Point(26, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 151);
            this.panel1.TabIndex = 9;
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNum.Location = new System.Drawing.Point(14, 12);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(139, 60);
            this.lblStudentNum.TabIndex = 31;
            this.lblStudentNum.Text = "Kayıtlı Öğrenci \r\n\r\nSayısı";
            // 
            // StudentNumber
            // 
            this.StudentNumber.AutoSize = true;
            this.StudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentNumber.Location = new System.Drawing.Point(14, 104);
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Size = new System.Drawing.Size(29, 20);
            this.StudentNumber.TabIndex = 32;
            this.StudentNumber.Text = "00";
            // 
            // lblTeacherNum
            // 
            this.lblTeacherNum.AutoSize = true;
            this.lblTeacherNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherNum.Location = new System.Drawing.Point(14, 12);
            this.lblTeacherNum.Name = "lblTeacherNum";
            this.lblTeacherNum.Size = new System.Drawing.Size(141, 60);
            this.lblTeacherNum.TabIndex = 31;
            this.lblTeacherNum.Text = "Kayıtlı Eğitmen \r\n\r\nSayısı";
            // 
            // TeacherSum
            // 
            this.TeacherSum.AutoSize = true;
            this.TeacherSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeacherSum.Location = new System.Drawing.Point(14, 104);
            this.TeacherSum.Name = "TeacherSum";
            this.TeacherSum.Size = new System.Drawing.Size(29, 20);
            this.TeacherSum.TabIndex = 32;
            this.TeacherSum.Text = "00";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(26, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 43);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TeacherNumber
            // 
            this.TeacherNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.TeacherNumber.Controls.Add(this.lblTeacherNum);
            this.TeacherNumber.Controls.Add(this.TeacherSum);
            this.TeacherNumber.Location = new System.Drawing.Point(320, 81);
            this.TeacherNumber.Name = "TeacherNumber";
            this.TeacherNumber.Size = new System.Drawing.Size(171, 151);
            this.TeacherNumber.TabIndex = 11;
            this.TeacherNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.TeacherNumber_Paint);
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LessonNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.TeacherNumber);
            this.Name = "StaticsForm";
            this.Text = "İstatistikler";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.LessonNumber.ResumeLayout(false);
            this.LessonNumber.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TeacherNumber.ResumeLayout(false);
            this.TeacherNumber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LessonNumber;
        private System.Windows.Forms.Label lblLessonNum;
        private System.Windows.Forms.Label lessonSum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStudentNum;
        private System.Windows.Forms.Label StudentNumber;
        private System.Windows.Forms.Label lblTeacherNum;
        private System.Windows.Forms.Label TeacherSum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel TeacherNumber;
    }
}