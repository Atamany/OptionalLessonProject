namespace OptionalLessonProject.Forms
{
    partial class StartForm
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
            this.btnStatics = new System.Windows.Forms.Button();
            this.btnLesson = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatics
            // 
            this.btnStatics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStatics.Location = new System.Drawing.Point(233, 285);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(305, 49);
            this.btnStatics.TabIndex = 13;
            this.btnStatics.Text = "İstatistikler";
            this.btnStatics.UseVisualStyleBackColor = true;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
            // 
            // btnLesson
            // 
            this.btnLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLesson.Location = new System.Drawing.Point(233, 230);
            this.btnLesson.Name = "btnLesson";
            this.btnLesson.Size = new System.Drawing.Size(305, 49);
            this.btnLesson.TabIndex = 12;
            this.btnLesson.Text = "Ders İşlemleri";
            this.btnLesson.UseVisualStyleBackColor = true;
            this.btnLesson.Click += new System.EventHandler(this.btnLesson_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText.Location = new System.Drawing.Point(140, 116);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(520, 25);
            this.lblText.TabIndex = 11;
            this.lblText.Text = "Hoşgeldiniz! Lütfen yapmak istediğiniz işlemi seçiniz.";
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudent.Location = new System.Drawing.Point(233, 175);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(305, 49);
            this.btnStudent.TabIndex = 10;
            this.btnStudent.Text = "Öğrenci İşlemleri";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStatics);
            this.Controls.Add(this.btnLesson);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnStudent);
            this.Name = "StartForm";
            this.Text = "Başlangıç Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatics;
        private System.Windows.Forms.Button btnLesson;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnStudent;
    }
}